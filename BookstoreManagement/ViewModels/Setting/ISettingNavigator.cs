using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Setting
{
    public interface ISettingNavigator : INavigator
    {
        void Backward();
    }
}
