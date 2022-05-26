using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Lend
{
    public class LendViewModel : BaseViewModel<LendNavigator>
    {
        // Thiếu mở dialog thêm đơn mượn, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsLendBills;

        [ObservableProperty] public object? selectedLendBill;
    }
}
