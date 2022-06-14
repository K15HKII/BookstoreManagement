using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
using BookstoreManagement.ViewModels.DialogView.Supplier;
using BookstoreManagement.Data.Model.Api;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter
{
    public partial class AuthorInfoViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ISupplierInfoNavigator _navigator;

        public AuthorInfoViewModel(ISupplierInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _factory = factory;
            _model = model;
            _navigator = navigator;
        }

        public void SetAuthor(Publisher publisher)
        {
            this._publisher = publisher;
            this.Id = "#" + publisher.Id.ToString();
            this.Name = publisher.Name;
        }
        
        private Publisher _publisher;

        [ObservableProperty] string? _id;

        [ObservableProperty] string? _image;

        [ObservableProperty] object? _name;

        [ObservableProperty] object? _email;

        [ObservableProperty] object? _coopDate;

        [ObservableProperty] object? _type;

        [ObservableProperty] object? _quantity;


        public event Action<object?>? CloseAction;
        [ICommand]
        public async void OpenDetail()
        {
            //TODO: factory tạo viewModel không được
            SupplierDetailViewModel vm = _factory.Create<SupplierDetailViewModel>();
            vm.SetPublisher(_publisher);
            object? request = await _navigator.OpenDetailSupplierDialog(vm);

            if (request == null)
                return;
            
        }
    }
}
