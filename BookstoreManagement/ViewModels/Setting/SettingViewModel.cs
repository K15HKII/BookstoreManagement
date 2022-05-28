using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Setting
{
    public partial class SettingViewModel : BaseViewModel<ISettingNavigator>
    {
        public SettingViewModel(ISettingNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider) : base(navigator, scheluderProvider)
        {
        }

        [ICommand]
        public void Backward()
        {
            Navigator!.Backward();
        }
    }
}
