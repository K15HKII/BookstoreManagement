using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
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
                .AddRetrofit();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            IAuthRemote auth = _host.Services.GetRequiredService<IAuthRemote>();
            HandleLogin(auth);
        }

        private void HandleLogin(IAuthRemote auth)
        {
            Console.WriteLine("Start login");
            Task<LoginResponse> task = auth.login(new LoginRequest()
            {
                Username = "admin",
                Password = "admasdasdin"
            });
            task.Wait();
            LoginResponse response = task.Result;
            if (response != null)
            {
                Console.WriteLine(response.AccessToken);
                Console.WriteLine(response.RefreshToken);
                Console.WriteLine(response.IsAuthenticated);
            }
        }

    }
}
