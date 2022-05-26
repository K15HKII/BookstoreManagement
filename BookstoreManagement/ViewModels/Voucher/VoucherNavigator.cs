using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher
{
    public interface VoucherNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
