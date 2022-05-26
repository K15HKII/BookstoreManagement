using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Manager
{
    public interface ManagerNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
