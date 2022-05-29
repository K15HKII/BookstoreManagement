using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Annotations;
using BookstoreManagement.Utils;

namespace BookstoreManagement.ViewModels.Account
{
    public partial class AccountViewModel : BaseViewModel<IAccountNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public AccountViewModel(IAccountNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

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
