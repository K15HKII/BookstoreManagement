using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using BookstoreManagement.Data;
using BookstoreManagement.Data.Model.Auth;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.Login;
using BookstoreManagement.Views.ViewStates;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookstoreManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly IHost _host;
        


        public IServiceProvider ServiceProvider => _host.Services;
        
        public App()
        {
            _host = CreateHostBuilder().Build();
        }


        private IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .Application(this)
                .AddLogging()
                .AddStores()
                .AddViewStates()
                .AddViewModels();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            bool test = false;

            if (!test)
            {
                MainViewState view = _host.Services.GetRequiredService<MainViewState>();
                view.CurrentView = _host.Services.GetRequiredService<LoginViewModel>();
                IModelRemote _model = _host.Services.GetRequiredService<IModelRemote>();
                MainWindowRelease main = new MainWindowRelease()
                {
                    DataContext = view
                };
                main.Show();
            }
            else
            {
                new MainWindow().Show();
            }
        }

    }
}
