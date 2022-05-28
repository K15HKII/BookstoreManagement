using System;
using System.Windows;
using BookstoreManagement.Data;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
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
using BookstoreManagement.ViewModels.Login;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Refit;
using BookstoreManagement.ViewModels.Setting;
using BookstoreManagement.ViewModels.Lend.LendAdapter;
using BookstoreManagement.ViewModels.Lend.LendInfoAdapter;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Order;
using BookstoreManagement.ViewModels.DialogView.Order.Adapter;
using BookstoreManagement.ViewModels.DialogView.Voucher;
using BookstoreManagement.ViewModels.DialogView.Customer;
using BookstoreManagement.ViewModels.DialogView.Manager;
using BookstoreManagement.ViewModels.DialogView.Supplier;
using BookstoreManagement.ViewModels.DialogView;
using BookstoreManagement.Views.ViewStates;

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

        public static IHostBuilder Application(this IHostBuilder host, Application application)
        {
            host.ConfigureServices((context, service) =>
            {
                service.AddSingleton(application);
            });
            return host;
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
                service.AddSingleton<ScheluderProvider>();
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

        public static IHostBuilder AddViewStates(this IHostBuilder host)
        {
            host.ConfigureServices((context, service) =>
            {
                service.AddSingleton<MainViewState>();
            });
            return host;
        }

        private static void AddViewModel<T>(this IServiceCollection c) where T : BaseViewModel
        {
            c.AddTransient<T>();
            c.AddSingleton<ViewModelCreator<T>>(s => s.GetRequiredService<T>);
        }

        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices((context, service) =>
            {
                service.AddSingleton<ILoginNavigator, LoginNavigator>();
                service.AddViewModel<LoginViewModel>();
                service.AddViewModel<HomeViewModel>();
                service.AddViewModel<DashboardViewModel>();
                service.AddViewModel<ReportViewModel>();
                service.AddViewModel<BookStoreViewModel>();
                service.AddViewModel<OrderViewModel>();
                service.AddViewModel<VoucherViewModel>();
                service.AddViewModel<RatingViewModel>();
                service.AddViewModel<CustomerViewModel>();
                service.AddViewModel<ManagerViewModel>();
                service.AddViewModel<LendViewModel>();
                service.AddViewModel<SupplierViewModel>();

                //Adapter
                //Home
                service.AddViewModel<UserAdapterViewModel>();
                service.AddViewModel<BookAdapterViewModel>();

                //BookStore
                service.AddViewModel<BookInfoViewModel>();

                //Order
                service.AddViewModel<OrderInfoViewModel>();

                //Voucher
                service.AddViewModel<VoucherAdapterViewModel>();

                //Rating
                service.AddViewModel<RatingInfoViewModel>();
                service.AddViewModel<RatingExpanderViewModel>();

                //Customer
                service.AddViewModel<CustomerInfoViewModel>();

                //Manager
                service.AddViewModel<EmployeeInfoViewModel>();

                //Supplier
                service.AddViewModel<SupplierInfoViewModel>();

                //OrderPage
                service.AddViewModel<ArrivedPageViewModel>();
                service.AddViewModel<CancleViewModel>();
                service.AddViewModel<RateOrderPageViewModel>();
                service.AddViewModel<ShippingPageViewModel>();
                service.AddViewModel<WaitingConfirmPageViewModel>();

                //Setting
                service.AddViewModel<SettingViewModel>();

                //Account
                service.AddViewModel<AccountViewModel>();

                //Lend
                service.AddViewModel<LendInfoViewModel>();
                //LendExpander
                service.AddViewModel<LendInfoExpandViewModel>();


                //Dialog
                //BookStore.DetailView
                service.AddViewModel<BookDetailViewModel>();
                service.AddViewModel<AddBookViewModel>();
                service.AddViewModel<EditBookViewModel>();

                //Order
                service.AddViewModel<OrderBillViewModel>();
                service.AddViewModel<OrderItemViewModel>();
                service.AddViewModel<AddOrderViewModel>();

                //Voucher
                service.AddViewModel<AddVoucherViewModel>();

                //Customer
                service.AddViewModel<CustomerDetailViewModel>();
                service.AddViewModel<AddCustomerViewModel>();
                service.AddViewModel<EditCustomerViewModel>();

                //Manager
                service.AddViewModel<EmployeeDetailViewModel>();
                service.AddViewModel<AddEmployeeViewModel>();
                service.AddViewModel<EditEmployeeViewModel>();

                //Supplier
                service.AddViewModel<SupplierDetailViewModel>();
                service.AddViewModel<AddSupplierViewModel>();
                service.AddViewModel<EditSupplierViewModel>();

                //Lend
                service.AddViewModel<AddLendBillViewModel>();
                
                service.AddSingleton<IViewModelFactory, ViewModelFactory>();
            });
            return host;
        }

    }

}
