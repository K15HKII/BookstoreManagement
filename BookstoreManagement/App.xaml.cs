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
                .AddViewModels();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            new MainWindow().Show();
        }

    }
}
