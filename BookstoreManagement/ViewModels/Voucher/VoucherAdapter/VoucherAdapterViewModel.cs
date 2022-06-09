using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.Voucher;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher.VoucherAdapter
{
    public partial class VoucherAdapterViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IVoucherAdapterNavigator _navigator;

        public VoucherAdapterViewModel(IVoucherAdapterNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }
        
        public void SetVoucher(VoucherProfile voucher)
        {
            this.Name = voucher.Discount + "% " + voucher.Name;
            this.Description = voucher.Description;
            this.ApplyType = "Áp dụng cho Sách thể loại ";
            /*for(int i = 0;i< voucher.RequireBookTags.Count;i++)
            {
                this.ApplyType += voucher.RequireBookTags[i] + ",";
            }*/

            this.RequireMinValue = voucher.RequireMinValue;
        }

        [ObservableProperty] string? _name;

        [ObservableProperty] string? _description;

        [ObservableProperty] int? _requireMinValue;

        [ObservableProperty] string? _applyType;

        [ObservableProperty] DiscountType? _discountType;

        [ObservableProperty] float? _discount;

        [ICommand]
        public void OpenInfo()
        {
            //TODO: cast to edit request
            object? request = _navigator.OpenDetailVoucherDialog(_factory.Create<VoucherDetailViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
