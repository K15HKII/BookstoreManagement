using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Customer
{
    public class CustomerViewModel : BaseViewModel<CustomerNavigator>
    {
        // Thiếu mở dialog thêm khách hàng và filter và xoá
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsCustomers;

        [ObservableProperty] public object? selectedBook;
    }
}
