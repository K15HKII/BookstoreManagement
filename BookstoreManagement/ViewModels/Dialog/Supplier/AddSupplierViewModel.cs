﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Supplier
{
    public partial class AddSupplierViewModel : BaseViewModel,IDialog
    {
        private readonly IModelRemote _model;

        public AddSupplierViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        //TODO: thiết kế nhà cung cấp chưa đúng còn thiếu

        [ObservableProperty]
        [Required]
        private string? _image;
        
        [ObservableProperty]
        [Required]
        private string? _id;

        [ObservableProperty]
        [Required]
        private string? _name;
        
        [ObservableProperty]
        [Required]
        private string? _address;
        
        [ObservableProperty]
        [Required]
        private DateTime? _coopDate;
        
        [ObservableProperty]
        [Required]
        private DateTime? _createDate;

        [ObservableProperty] 
        [Required]
        private string? _bookType;
        
        [ObservableProperty]
        [Required]
        private string? _phone;
        
        [ObservableProperty]
        [Required]
        private string? _email;


        public PublisherUpdateRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new PublisherUpdateRequest()
            {

            };
        }

        public event Action<object?>? CloseAction;

        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public void Accept()
        {
            CloseAction?.Invoke(ToAddRequest());
        }
    }
}
