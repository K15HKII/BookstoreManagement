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
            this.current = voucher;
            this.Name = voucher.Discount + "% " + voucher.Name;
            this.Description = voucher.Description;
            this.ApplyType = "Áp dụng cho sách thể loại ";
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

            this.RequireMinValue = "Cho đơn hàng từ " + voucher.RequireMinValue + "đ";
        }

        private VoucherProfile current;
        
        [ObservableProperty] string? _name;

        [ObservableProperty] string? _description;

        [ObservableProperty] string? _requireMinValue;

        [ObservableProperty] string? _applyType;

        [ObservableProperty] DiscountType? _discountType;

        [ObservableProperty] float? _discount;

        [ICommand]
        public async void OpenInfo()
        {
            VoucherDetailViewModel vm = _factory.Create<VoucherDetailViewModel>();
            vm.SetVoucher(current);
            object? request = await _navigator.OpenDetailVoucherDialog(vm);

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
