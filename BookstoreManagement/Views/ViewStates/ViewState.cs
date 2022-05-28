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

        private readonly Queue<BaseViewModel> _viewQueue = new();

        public void NavigateAndQueue(BaseViewModel destination)
        {
            if (_currentView != null)
            {
                _viewQueue.Enqueue(_currentView);
            }
            CurrentView = destination;
        }

        public BaseViewModel? Backward()
        {
            if (_viewQueue.TryPeek(out var peek))
            {
                CurrentView = peek;
                return peek;
            }
            return null;
        }

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
