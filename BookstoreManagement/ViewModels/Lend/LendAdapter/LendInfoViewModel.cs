using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter
{
    public partial class LendInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? lendId;

        [ObservableProperty] object? lendOwner;

        [ObservableProperty] object? lendQuantity;

        [ObservableProperty] object? lendDate;

        [ObservableProperty] object? lendExpire;

        [ObservableProperty] object? lendStatus;

        [ObservableProperty] ObservableCollection<object>? lsLendBooks;

        [ObservableProperty] object? selectedLendBook;
    }
}
