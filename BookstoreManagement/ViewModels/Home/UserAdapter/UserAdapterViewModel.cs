using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Home.UserAdapter
{
    public class UserAdapterViewModel : BaseViewModel
    {
        [ObservableProperty] object? UserImage;

        [ObservableProperty] object? UserName;

        [ObservableProperty] object? UserEmail;

        [ObservableProperty] object? BillQuantity;
    }
}
