using BookstoreManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Report
{
    public class ReportNavigator : IReportNavigator
    {

        private readonly IDialogService _dialogService;

        public ReportNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }
        public void openAccountScreen()
        {
            throw new NotImplementedException();
        }

        public void openNotificationScreen()
        {
            throw new NotImplementedException();
        }
    }
}
