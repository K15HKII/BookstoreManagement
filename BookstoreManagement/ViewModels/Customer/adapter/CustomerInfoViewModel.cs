using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using BookstoreManagement.Data.Model.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Customer.adapter
{
    public partial class CustomerInfoViewModel : BaseUserViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ICustomerInfoNavigator _navigator;

        public CustomerInfoViewModel(ICustomerInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider,model)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }
        private User user;
        public void SetUser(User user,int count)
        {
            this.user = user;
            this.Id = "#" + count;
            this.Name = user.FirstName + user.LastName;
            this.CreateDate = user.CreateAt.Value.ToString("dd/MM/yyyy");
            /*this.QuantityOrders = user;
            this.Description = user.Description;*/
            //TODO:
        }

        [ObservableProperty] string? _id;
        [ObservableProperty] string? _name;
        [ObservableProperty] string? _email;
        [ObservableProperty] int? _quantityOrders;
        [ObservableProperty] float? _inCome;
        [ObservableProperty] string? _createDate;
        
        [ICommand]
        public async void OpenInfo()
        {
            CustomerDetailViewModel vm = _factory.Create<CustomerDetailViewModel>();
            vm.SetUser(this.user);
            object? request = await _navigator.OpenDetailUserDialog(vm);

            if (request == null)
                return;

            //TODO: send request to server
        }

    }
}
