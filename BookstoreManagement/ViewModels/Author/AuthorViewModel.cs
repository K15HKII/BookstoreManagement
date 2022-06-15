using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Supplier;
using Microsoft.Toolkit.Mvvm.Input;
using BookstoreManagement.ViewModels.Suppier.SupplierAdapter;

namespace BookstoreManagement.ViewModels.Suppier
{
    public partial class AuthorViewModel : PanelViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IAuthorNavigator _navigator;

        public AuthorViewModel(IAuthorNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
            Initialize();
        }

        public void Initialize()
        {
            Dispose(_model.GetAuthors().Select(publishers => publishers.Select(publisher =>
            {
                SupplierInfoViewModel vm = _factory.Create<SupplierInfoViewModel>();
                vm.SetAuthor(publisher);
                Quantity++;
                return vm;
            })), publishers =>
            {
                LsSuppliers.Clear();
                foreach (var vm in publishers)
                {
                    LsSuppliers.Add(vm);
                }
            });
        }
        
        public string TitlePanel
        {
            get => "Tác giả";
        }

        // Thiếu mở dialog thêm nhà cung cấp, xoá, filter

        [ObservableProperty] public ObservableCollection<object>? _lsSuppliers = new();

        [ObservableProperty] public int _quantity;

        [ObservableProperty] public object? _selectedSupplier = new();
        
        [ICommand]
        public async void AddNew()
        {
            PublisherUpdateRequest? request = await _navigator.OpenNewAuthorDialog(_factory.Create<UpdateSupplierViewModel>());
            if (request == null)
                return;

            Dispose(_model.CreatePublisher(request!), book =>
            {
                Console.WriteLine("Publisher created successfully");
                Initialize();
                //TODO: Notify
            });
        }
    }
}
