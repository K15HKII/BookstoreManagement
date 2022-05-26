using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Manager.EmployeeAdapter
{
    public class EmployeeInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? EmployeeId;

        [ObservableProperty] object? EmployeeName;

        [ObservableProperty] object? EmployeeStatus;

        [ObservableProperty] object? EmployeeDescription;

        [ObservableProperty] object? EmployeeJoinDate;

        [ObservableProperty] object? DayOffQuantity;
    }
}
