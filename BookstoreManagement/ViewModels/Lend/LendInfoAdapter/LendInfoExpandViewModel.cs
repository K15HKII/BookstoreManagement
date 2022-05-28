using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Lend.LendInfoAdapter
{
    public partial class LendInfoExpandViewModel : BaseViewModel
    {
        [ObservableProperty] object? lendBookId;
        [ObservableProperty] object? lendBookName;

        [ObservableProperty] object? lendBookType;
        [ObservableProperty] object? lendPrice;
        [ObservableProperty] object? bookSupplier;
        [ObservableProperty] object? lendStatus;
        [ObservableProperty] object? lendDateExpired;
    }
}
