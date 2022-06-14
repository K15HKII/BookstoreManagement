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
    public partial class UpdateVoucherViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;

        public UpdateVoucherViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        
        public void SetVoucher(VoucherProfile voucher)
        {
            /*this.Name = voucher.Discount + "% " + voucher.Name;
            this.Description = voucher.Description;
            this.ApplyType = "Áp dụng cho Sách thể loại ";
            for(int i = 0;i< voucher.RequireBookTags.Count;i++)
            {
                if(i==voucher.RequireBookTags.Count-1)
                {
                    this.ApplyType += voucher.RequireBookTags[i];
                }
                else
                {
                    this.ApplyType += voucher.RequireBookTags[i] + ", ";
                }
            }

            this.RequireMinValue = voucher.RequireMinValue;*/
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
                //TODO: thêm function add hoặc update cho voucher
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
