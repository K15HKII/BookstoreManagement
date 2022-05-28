using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.Views
{
    public abstract partial class ViewState : BaseViewModel
    {

        [ObservableProperty] private BaseViewModel? _currentView;

        public event Action<BaseViewModel?>? StateChanged;

        protected ViewState()
        {
            this.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName!.Equals(nameof(CurrentView)))
                {
                    StateChanged?.Invoke(CurrentView);
                }
            };
        }

    }
}
