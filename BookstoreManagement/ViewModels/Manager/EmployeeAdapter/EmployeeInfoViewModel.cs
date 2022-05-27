using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Manager.EmployeeAdapter
{
    public partial class EmployeeInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? employeeId;

        [ObservableProperty] object? employeeName;

        [ObservableProperty] object? employeeStatus;

        [ObservableProperty] object? employeeDescription;

        [ObservableProperty] object? employeeJoinDate;

        [ObservableProperty] object? dayOffQuantity;
    }
}
