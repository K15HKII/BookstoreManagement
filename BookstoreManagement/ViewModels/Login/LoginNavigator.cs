using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Login
{
    public interface LoginNavigator : INavigator
    {
        void openApp(Object obj = null);
    }
}
