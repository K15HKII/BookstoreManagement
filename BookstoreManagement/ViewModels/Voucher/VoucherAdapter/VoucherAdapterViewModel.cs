using BookstoreManagement.Annotations;
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
    public partial class VoucherAdapterViewModel : BaseViewModel<IVoucherAdapterNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public VoucherAdapterViewModel(IVoucherAdapterNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        [ObservableProperty] object? voucherTitle;

        [ObservableProperty] object? voucherDescription;

        [ObservableProperty] object? voucherExpire;

        [ObservableProperty] object? voucherMaxUse;

        [ObservableProperty] object? voucherUsedQuantity;

        [ObservableProperty] object? voucherApplyType;

        [ICommand]
        public void OpenInfo()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenDetailVoucherDialog(_factory.Create<VoucherDetailViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
