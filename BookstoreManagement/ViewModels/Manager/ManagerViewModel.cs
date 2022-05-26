using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Manager
{
    public class ManagerViewModel : BaseViewModel<ManagerNavigator>
    {
        // Thiếu mở dialog thêm nhân viên, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsEmployees;

        [ObservableProperty] public object? selectedEmployee;
    }
}
