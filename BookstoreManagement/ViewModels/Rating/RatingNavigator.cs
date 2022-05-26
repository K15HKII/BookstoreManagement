using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Rating
{
    public interface RatingNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
