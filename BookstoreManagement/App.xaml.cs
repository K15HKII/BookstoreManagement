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

        public App()
        {
            _host = CreateHostBuilder().Build();
        }


        private static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .AddLogging()
                .AddRetrofit()
                .AddStores()
                .AddViewStates()
                .AddViewModels();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            MainViewState view = _host.Services.GetRequiredService<MainViewState>();
            view.CurrentView = _host.Services.GetRequiredService<LoginViewModel>();
            MainWindowRelease main = new MainWindowRelease()
            {
                DataContext = view
            };
            main.Show();
        }

    }
}
