﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Dashboard
{
    public interface DashboardNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
