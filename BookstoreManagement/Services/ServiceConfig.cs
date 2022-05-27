using System;
using BookstoreManagement.Data;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.ViewModels;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.Dashboard;
using BookstoreManagement.ViewModels.Order;
using BookstoreManagement.ViewModels.Rating;
using BookstoreManagement.ViewModels.Report;
using BookstoreManagement.ViewModels.Voucher;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Refit;

namespace BookstoreManagement.Services
{
    public static class ServiceConfig
    {

        private static IHttpClientBuilder ConfigHttpClientBuilder(this IHttpClientBuilder builder)
        {
            return builder.ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://upbeat-resolver-316305.df.r.appspot.com");
            }).AddHttpMessageHandler(() => new HttpLoggingHandler());
        }

        public static IHostBuilder AddLogging(this IHostBuilder host)
        {
            host.ConfigureLogging((context, builder) =>
            {
                //builder.ClearProviders();
                builder.AddConsole();
            });
            host.ConfigureServices((context, service) =>
            {
                service.AddLogging();
            });
            return host;
        }

        public static IHostBuilder AddStores(this IHostBuilder host)
        {
            host.ConfigureServices((context, service) =>
            {
                service.AddSingleton<LoginSession>();
                service.AddSingleton<IAuthenticator, Authenticator>();
            });
            return host;
        }

        public static IHostBuilder AddRetrofit(this IHostBuilder host)
        {
            host.ConfigureServices((context, service) =>
            {
                RefitSettings settings = new RefitSettings(new NewtonsoftJsonContentSerializer());
                service.AddRefitClient<IAuthRemote>(settings).ConfigHttpClientBuilder();
                service.AddRefitClient<IModelRemote>(settings).ConfigHttpClientBuilder();
            });
            return host;
        }

        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices((context, service) =>
            {
                service.AddTransient<HomeViewModel>();
                service.AddTransient<DashboardViewModel>();
                service.AddTransient<ReportViewModel>();
                service.AddTransient<BookStoreViewModel>();
                service.AddTransient<OrderViewModel>();
                service.AddTransient<VoucherViewModel>();
                service.AddTransient<RatingViewModel>();
            });
            return host;
        }

    }

}
