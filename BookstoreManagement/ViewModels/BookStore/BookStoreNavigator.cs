using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.BookStore
{
    public interface BookStoreNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
