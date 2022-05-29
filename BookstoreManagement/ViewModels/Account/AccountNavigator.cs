using BookstoreManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Account
{
    public class AccountNavigator : IAccountNavigator
    {
        private readonly IDialogService _dialogService;

        public AccountNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public void BackWard()
        {
            throw new NotImplementedException();
        }
    }
}
