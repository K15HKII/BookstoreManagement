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
        [Required]
        private string? _id;
        
        [ObservableProperty]
        [Required]
        private int? _discount;
        
        [ObservableProperty] 
        [Required]
        private int? _quantity;
        
        [ObservableProperty]
        [Required]
        private DateTime? _datestart;
        
        [ObservableProperty]
        [Required]
        private DateTime? _dateexpired;
        
        [ObservableProperty]
        [Required]
        private int? _maxuse;
        
        [ObservableProperty]
        [Required]
        private string? _condition;
        
        [ObservableProperty]
        [Required]
        private string? _morecondition;

        public VoucherAddRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new VoucherAddRequest()
            {

            };
        }

        public event Action<object?>? CloseAction;

        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(ToAddRequest());
        }
    }
}
