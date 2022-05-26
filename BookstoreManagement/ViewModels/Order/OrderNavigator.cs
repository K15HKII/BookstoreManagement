using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Order
{
    public interface OrderNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
