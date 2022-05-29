using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Account
{
    public interface IAccountNavigator : INavigator
    {
        void BackWard();
    }
}
