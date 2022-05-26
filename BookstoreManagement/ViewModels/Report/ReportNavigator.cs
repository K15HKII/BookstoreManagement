﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Report
{
    public interface ReportNavigator:INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
    }
}
