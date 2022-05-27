using System;
using BookstoreManagement.Data;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.ViewModels;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
using BookstoreManagement.ViewModels.Customer;
using BookstoreManagement.ViewModels.Customer.CustomerAdapter;
using BookstoreManagement.ViewModels.Dashboard;
using BookstoreManagement.ViewModels.Home.BookAdapter;
using BookstoreManagement.ViewModels.Home.UserAdapter;
using BookstoreManagement.ViewModels.Lend;
using BookstoreManagement.ViewModels.Manager;
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;
using BookstoreManagement.ViewModels.Order;
using BookstoreManagement.ViewModels.Order.OrderInfoAdapter;
using BookstoreManagement.ViewModels.Rating;
using BookstoreManagement.ViewModels.Rating.RatingAdapter;
using BookstoreManagement.ViewModels.Report;
using BookstoreManagement.ViewModels.Suppier;
using BookstoreManagement.ViewModels.Suppier.SupplierAdapter;
using BookstoreManagement.ViewModels.Voucher;
using BookstoreManagement.ViewModels.Voucher.VoucherAdapter;
using BookstoreManagement.ViewModels.Order.Page;
using BookstoreManagement.ViewModels.Account;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Refit;
using BookstoreManagement.ViewModels.Setting;

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
                service.AddTransient<CustomerViewModel>();
                service.AddTransient<ManagerViewModel>();
                service.AddTransient<LendViewModel>();
                service.AddTransient<SupplierViewModel>();

                //Adapter
                //Home
                service.AddTransient<UserAdapterViewModel>();
                service.AddTransient<BookAdapterViewModel>();

                //BookStore
                service.AddTransient<BookInfoViewModel>();

                //Order
                service.AddTransient<OrderInfoViewModel>();

                //Voucher
                service.AddTransient<VoucherAdapterViewModel>();

                //Rating
                service.AddTransient<RatingInfoViewModel>();

                //Customer
                service.AddTransient<CustomerInfoViewModel>();

                //Manager
                service.AddTransient<EmployeeInfoViewModel>();

                //Supplier
                service.AddTransient<SupplierInfoViewModel>();

                //OrderPage
                service.AddTransient<ArrivedPageViewModel>();
                service.AddTransient<CancleViewModel>();
                service.AddTransient<RateOrderPageViewModel>();
                service.AddTransient<ShippingPageViewModel>();
                service.AddTransient<WaitingConfirmPageViewModel>();

                //Setting
                service.AddTransient<SettingViewModel>();

                //Account
                service.AddTransient<AccountViewModel>();
            });
            return host;
        }

    }

}
