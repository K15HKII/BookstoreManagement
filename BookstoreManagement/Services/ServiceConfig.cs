using System;
using System.Windows;
using BookstoreManagement.Data;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Services.Common;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels;
using BookstoreManagement.ViewModels.Account;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
using BookstoreManagement.ViewModels.Customer;
using BookstoreManagement.ViewModels.Customer.adapter;
using BookstoreManagement.ViewModels.Dashboard;
using BookstoreManagement.ViewModels.DialogView;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer;
using BookstoreManagement.ViewModels.DialogView.Manager;
using BookstoreManagement.ViewModels.DialogView.Order;
using BookstoreManagement.ViewModels.DialogView.Order.Adapter;
using BookstoreManagement.ViewModels.DialogView.Supplier;
using BookstoreManagement.ViewModels.DialogView.Voucher;
using BookstoreManagement.ViewModels.Home;
using BookstoreManagement.ViewModels.Home.BookAdapter;
using BookstoreManagement.ViewModels.Home.UserAdapter;
using BookstoreManagement.ViewModels.Lend;
using BookstoreManagement.ViewModels.Lend.LendAdapter;
using BookstoreManagement.ViewModels.Login;
using BookstoreManagement.ViewModels.Manager;
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;
using BookstoreManagement.ViewModels.Order;
using BookstoreManagement.ViewModels.Order.OrderInfoAdapter;
using BookstoreManagement.ViewModels.Order.Page;
using BookstoreManagement.ViewModels.Rating;
using BookstoreManagement.ViewModels.Rating.RatingAdapter;
using BookstoreManagement.ViewModels.Report;
using BookstoreManagement.ViewModels.Setting;
using BookstoreManagement.ViewModels.Suppier;
using BookstoreManagement.ViewModels.Suppier.SupplierAdapter;
using BookstoreManagement.ViewModels.Voucher;
using BookstoreManagement.ViewModels.Voucher.VoucherAdapter;
using BookstoreManagement.Views.ViewStates;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Refit;
using LendNavigator = BookstoreManagement.ViewModels.Lend.LendNavigator;

namespace BookstoreManagement.Services
{
    public static class ServiceConfig
    {

        private static IHttpClientBuilder ConfigHttpClientBuilder(this IHttpClientBuilder builder, bool auth = false, bool logging = false)
        {
            builder = builder.ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://upbeat-resolver-316305.df.r.appspot.com");
                //c.BaseAddress = new Uri("http://localhost:3000");
            });
            if (auth)
            {
                builder.AddHttpMessageHandler<HttpAuthHandler>();
            }
            if (logging)
            {
                builder.AddHttpMessageHandler(() => new HttpLoggingHandler());
            }
            return builder;
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
                
                RefitSettings settings = new RefitSettings(new NewtonsoftJsonContentSerializer(new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                }));
                service.AddTransient<HttpAuthHandler>();
                service.AddRefitClient<IAuthRemote>(settings).ConfigHttpClientBuilder(false, true);
                service.AddRefitClient<IModelRemote>(settings).ConfigHttpClientBuilder(true, true);
                
                service.AddSingleton<IAuthenticator, Authenticator>();
                service.AddSingleton<ScheluderProvider>();
                service.AddSingleton<IDialogService, DialogService>();
                //service.Decorate<IModelRemote, CacheModelRemote>();
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

                service.AddSingleton<IHomeNavigator, HomeNavigator>();
                service.AddViewModel<HomeViewModel>();

                service.AddSingleton<IDashboardNavigator, DashboardNavigator>();
                service.AddViewModel<DashBoardPanelViewModel>();

                service.AddSingleton<IReportNavigator, ReportNavigator>();
                service.AddViewModel<ReportPanelViewModel>();

                service.AddSingleton<IBookStoreNavigator, BookStoreNavigator>();
                service.AddViewModel<BookPanelViewModel>();

                service.AddSingleton<IOrderNavigator, OrderNavigator>();
                service.AddViewModel<OrderViewModel>();

                service.AddSingleton<IVoucherNavigator, VoucherNavigator>();
                service.AddViewModel<VoucherPanelViewModel>();

                service.AddSingleton<IRatingNavigator, RatingNavigator>();
                service.AddViewModel<RatingViewModel>();

                service.AddSingleton<ICustomerNavigator, CustomerNavigator>();
                service.AddViewModel<CustomerPanelViewModel>();

                service.AddSingleton<IManagerNavigator, ManagerNavigator>();
                service.AddViewModel<ManagerViewModel>();
                
                service.AddSingleton<ILendNavigator, LendNavigator>();
                service.AddViewModel<LendViewModel>();

                service.AddSingleton<ISupplierNavigator, SupplierNavigator>();
                service.AddViewModel<SupplierViewModel>();

                //Setting
                service.AddSingleton<ISettingNavigator, SettingNavigator>();
                service.AddViewModel<SettingViewModel>();
                //Account
                service.AddSingleton<IAccountNavigator, AccountNavigator>();
                service.AddViewModel<AccountViewModel>();

                //Adapter
                //Home
                service.AddViewModel<UserAdapterViewModel>();
                service.AddViewModel<BookAdapterViewModel>();

                //BookStore
                service.AddSingleton<IBookInfoNavigator, BookInfoNavigator>();
                service.AddViewModel<BookDetailViewModel>();

                //Customer
                service.AddSingleton<ICustomerInfoNavigator, CustomerInfoNavigator>();
                service.AddViewModel<CustomerInfoViewModel>();

                //Order
                service.AddSingleton<IOrderInfoNavigator, OrderInfoNavigator>();
                service.AddViewModel<OrderInfoViewModel>();

                //Voucher
                service.AddSingleton<IVoucherAdapterNavigator, VoucherAdapterNavigator>();
                service.AddViewModel<VoucherAdapterViewModel>();

                //Rating
                service.AddSingleton<IRatingInfoNavigator, RatingInfoNavigator>();
                service.AddViewModel<RatingInfoViewModel>();

                //Manager
                service.AddSingleton<IEmployeeInfoNavigator, EmployeeInfoNavigator>();
                service.AddViewModel<EmployeeInfoViewModel>();

                //Supplier
                service.AddSingleton<ISupplierInfoNavigator, SupplierInfoNavigator>();
                service.AddViewModel<SupplierInfoViewModel>();

                //OrderPage
                service.AddViewModel<ArrivedPageViewModel>();
                service.AddViewModel<CancleViewModel>();
                service.AddViewModel<RateOrderPageViewModel>();
                service.AddViewModel<ShippingPageViewModel>();
                service.AddViewModel<WaitingConfirmPageViewModel>();

                

                

                //Lend
                service.AddSingleton<ILendInfoNavigator, LendInfoNavigator>();
                service.AddViewModel<LendInfoViewModel>();


                //Dialog
                //BookStore.DetailView
                service.AddSingleton<IBookDetailNavigator, BookDetailNavigator>();
                service.AddViewModel<BookDialogViewModel>();
                service.AddViewModel<UpdateBookViewModel>();

                //Order
                service.AddViewModel<OrderBillViewModel>();
                service.AddViewModel<OrderItemViewModel>();
                service.AddViewModel<AddOrderViewModel>();

                //Voucher
                service.AddViewModel<AddVoucherViewModel>();

                //Customer
                service.AddSingleton<ICustomerDetailNavigator, CustomerDetailNavigator>();
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
