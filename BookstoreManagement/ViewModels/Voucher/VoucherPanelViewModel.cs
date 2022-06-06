using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Reactive.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Voucher;
using BookstoreManagement.ViewModels.Voucher.VoucherAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Voucher
{
    public partial class VoucherPanelViewModel : PanelViewModel

    {
    private readonly IViewModelFactory _factory;
    private readonly IModelRemote _model;
    private readonly IVoucherNavigator _navigator;

    public VoucherPanelViewModel(IVoucherNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,
        IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
    {
        _navigator = navigator;
        _factory = factory;
        _model = model;
        Initialize();
    }

    [ObservableProperty] public ObservableCollection<VoucherAdapterViewModel>? _lsVouchers;

    [ObservableProperty] public ObservableCollection<VoucherAdapterViewModel>? _selectedVoucher;

    private void Initialize()
    {
        //TODO: cần tạo IVoucherRepository
        /*Dispose(_model.().Select(vouchers => vouchers.Select(voucher =>
        {
            VoucherAdapterViewModel vm = _factory.Create<VoucherAdapterViewModel>();
            vm.SetVoucher(voucher);
            return vm;
        })), books =>
        {
            LsVouchers.Clear();
            foreach (var vm in books)
            {
                LsVouchers.Add(vm);
            }
        });*/
    }

    [ICommand]
    public async void AddNew()
    {
        VoucherUpdateRequest? request = await _navigator.OpenAddVoucherDialog(_factory.Create<AddVoucherViewModel>());
        if (request == null)
            return;

        //TODO: Send request through IModelRemote
    }

    }
}
