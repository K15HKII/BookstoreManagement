using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels.Account
{
    public class AccountViewModel : BaseViewModel<AccountNavigator>
    {
        //Thiếu dialog đổi mật khẩu và đổi thông tin cá nhân
        public void BackWard() { }

        [ObservableProperty] object? AccountName;

        [ObservableProperty] object? AccountEmail;

        [ObservableProperty] object? AccountPhoneNum;

        [ObservableProperty] object? AccountCreateDate;

        [ObservableProperty] object? AccountGender;

        [ObservableProperty] object? AccountAddress;

        [ObservableProperty] object? AccountFaceBook;

        [ObservableProperty] object? AccountInstagram;
    }
}
