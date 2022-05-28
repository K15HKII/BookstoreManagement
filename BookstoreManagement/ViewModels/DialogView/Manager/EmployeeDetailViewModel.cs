using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Manager
{
    public partial class EmployeeDetailViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        [ObservableProperty] object? employeeId;
        [ObservableProperty] object? employeePosition;
        [ObservableProperty] object? employeeName;
        [ObservableProperty] object? employeeImage;
        [ObservableProperty] object? employeePhone;
        [ObservableProperty] object? employeeBirth;
        [ObservableProperty] object? employeeGender;
        [ObservableProperty] object? employeeAddress;
        [ObservableProperty] object? employeeDayOff;
        [ObservableProperty] object? employeeDayOffMax;
        [ObservableProperty] object? employeeCharacter;
        [ObservableProperty] object? employeeCreateDay;

    }
}
