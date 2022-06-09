using Microsoft.Toolkit.Mvvm.ComponentModel;
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

namespace BookstoreManagement.ViewModels.DialogView.Voucher
{
    public partial class AddVoucherViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;

        public AddVoucherViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }

        [ObservableProperty]
        private string? _code;
        
        [ObservableProperty]
        private int? _discount;
        
        [ObservableProperty]
        private int? _quantity;
        
        [ObservableProperty]
        private DateTime? _datestart;
        
        [ObservableProperty]
        private DateTime? _dateexpired;
        
        [ObservableProperty]
        private int? _maxuse;
        
        [ObservableProperty]
        private string? _condition;
        
        [ObservableProperty]
        private string? _morecondition;

        public VoucherUpdateRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new VoucherUpdateRequest()
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
