using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Suppier
{
    public interface SupplierNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
