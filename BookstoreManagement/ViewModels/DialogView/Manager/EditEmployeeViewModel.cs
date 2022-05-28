using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Manager
{
    public partial class EditEmployeeViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        [ObservableProperty] object? employeeId;
        [ObservableProperty] object? employeeUserName;
        [ObservableProperty] object? employeeImage;
        [ObservableProperty] object? employeeName;
        [ObservableProperty] object? employeeDayCreate;
        [ObservableProperty] object? employeeGender;
        [ObservableProperty] object? employeeCharacter;
        [ObservableProperty] object? employeeBirth;
        [ObservableProperty] object? employeePhone;
        [ObservableProperty] object? employeeEmail;
    }
}

