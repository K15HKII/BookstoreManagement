using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels
{
    public interface IDialog
    {

        public event Action<object?> CloseAction;

    }
}
