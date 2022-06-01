﻿using BookstoreManagement.Data.Remote;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using BookstoreManagement.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;
using BookstoreManagement.ViewModels.DialogView.Customer;

namespace BookstoreManagement.ViewModels.Customer.CustomerAdapter
{
    public partial class CustomerViewModel : BaseViewModel<ICustomerInfoNavigator>
    {

        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public CustomerViewModel(ICustomerInfoNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        [ObservableProperty] object? _id;
        
        [ObservableProperty] object? _image;

        [ObservableProperty] object? _name;

        [ObservableProperty] object? _email;

        [ObservableProperty] object? _type;

        [ObservableProperty] object? _billquantity;

        [ObservableProperty] object? _customerincome;

        [ObservableProperty] object? _createdate;

        [ICommand]
        public void OpenEdit()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenEditCustomerDialog(_factory.Create<EditCustomerViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
