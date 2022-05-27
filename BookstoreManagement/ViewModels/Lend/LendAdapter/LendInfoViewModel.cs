using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter
{
    public class LendInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? LendId;

        [ObservableProperty] object? LendOwner;

        [ObservableProperty] object? LendQuantity;

        [ObservableProperty] object? LendDate;

        [ObservableProperty] object? LendExpire;

        [ObservableProperty] object? LendStatus;
    }
}
