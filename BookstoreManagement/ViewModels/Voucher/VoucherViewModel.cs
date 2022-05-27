using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher
{
    public partial class VoucherViewModel : BaseViewModel<VoucherNavigator>
    {
        //Thiếu dialog thêm voucher
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsVouchers;

        [ObservableProperty] public object? selectedVoucher;
    }
}
