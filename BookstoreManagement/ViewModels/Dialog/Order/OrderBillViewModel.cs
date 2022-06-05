using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Order
{
    public partial class OrderBillViewModel : BaseViewModel, IDialog
    {
        //TODO: thiếu function chấp nhận đơn hàng
        private readonly IModelRemote _model;

        public OrderBillViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }

        [ObservableProperty] object? _customername;
        [ObservableProperty] object? _customerphone;
        [ObservableProperty] object? _customeremail;
        [ObservableProperty] object? _customeraddress;
        [ObservableProperty] object? _paymentmethod;

        //Voucher thì đã có adapter binding sẵn trong VoucherWindow
        [ObservableProperty] ObservableCollection<object>? _lsvoucherapply;
        [ObservableProperty] ObservableCollection<object>? _lsorderbooks;
        [ObservableProperty] object? _bookprice;
        [ObservableProperty] object? _billstatus;
        [ObservableProperty] object? _billnote;
        [ObservableProperty] object? _allbookprice;
        [ObservableProperty] object? _shippingfee;
        [ObservableProperty] object? _discountprice;
        [ObservableProperty] object? _totalmoney;

        public event Action<object?>? CloseAction;
        
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
    }
}
