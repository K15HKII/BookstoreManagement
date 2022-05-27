using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Customer
{
    public interface CustomerNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
