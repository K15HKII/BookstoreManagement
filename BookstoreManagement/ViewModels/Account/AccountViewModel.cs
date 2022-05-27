using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels.Account
{
    public partial class AccountViewModel : BaseViewModel<AccountNavigator>
    {
        //Thiếu dialog đổi mật khẩu và đổi thông tin cá nhân
        public void BackWard() { }

        [ObservableProperty] object? accountName;

        [ObservableProperty] object? accountEmail;

        [ObservableProperty] object? accountPhoneNum;

        [ObservableProperty] object? accountCreateDate;

        [ObservableProperty] object? accountGender;

        [ObservableProperty] object? accountAddress;

        [ObservableProperty] object? accountFaceBook;

        [ObservableProperty] object? accountInstagram;
    }
}
