using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.Rating.RatingAdapter;

namespace BookstoreManagement.ViewModels.Rating
{
    public partial class RatingViewModel : PanelViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IRatingNavigator _navigator;

        public RatingViewModel(IRatingNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
            Initialize();
        }

        public void Initialize()
        {
            /*Dispose(_model.GetFeedbacks().Select(feedbacks => feedbacks.Select(book =>
            {
                RatingInfoViewModel vm = _factory.Create<RatingInfoViewModel>();
                
                ++Quantity;
                string a = Quantity.ToString();
                return vm;
            })), feedbacks =>
            {
                feedbacks.Clear();
                foreach (var vm in feedbacks)
                {
                    feedbacks.Add(vm);
                }
            });*/
        }

        [ObservableProperty] public ObservableCollection<RatingInfoViewModel> _feedbacks = new();

        [ObservableProperty] public object? _selectedRatingView = new();
        
        [ObservableProperty] private int _quantity = 0;
    }
}
