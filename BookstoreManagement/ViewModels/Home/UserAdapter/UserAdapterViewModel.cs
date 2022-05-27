using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Home.UserAdapter
{
    public partial class UserAdapterViewModel : BaseViewModel
    {
        [ObservableProperty] object? userImage;

        [ObservableProperty] object? userName;

        [ObservableProperty] object? userEmail;

        [ObservableProperty] object? billQuantity;
    }
}
