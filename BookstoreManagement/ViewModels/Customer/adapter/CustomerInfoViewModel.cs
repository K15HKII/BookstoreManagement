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

namespace BookstoreManagement.ViewModels.Customer.adapter
{
    public partial class CustomerInfoViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ICustomerInfoNavigator _navigator;

        public CustomerInfoViewModel(ICustomerInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        public void SetUser(User user)
        {
            this.Id = user.Id;
            this.Name = user.FirstName + user.LastName;
            this.Email = user.Email;
            /*this.QuantityOrders = user;
            this.Description = user.Description;*/
            //TODO:
        }

        [ObservableProperty] string? _id;
        [ObservableProperty] string? _name;
        [ObservableProperty] string? _email;
        [ObservableProperty] int? _quantityOrders;
        [ObservableProperty] float? _inCome;
        [ObservableProperty] DateTime? _createDate;
    }
}
