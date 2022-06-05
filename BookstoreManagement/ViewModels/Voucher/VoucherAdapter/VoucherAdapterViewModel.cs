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

        [ObservableProperty] string? _title;

        [ObservableProperty] string? _description;

        [ObservableProperty] DateTime? _expireDate;

        [ObservableProperty] object? _maxUse;

        [ObservableProperty] int? _usedQuantity;

        [ObservableProperty] object? _applyType;

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
