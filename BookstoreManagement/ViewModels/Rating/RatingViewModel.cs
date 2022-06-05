using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;

namespace BookstoreManagement.ViewModels.Rating
{
    public partial class RatingViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IRatingNavigator _navigator;

        public RatingViewModel(IRatingNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }
        
        //Thiếu xoá đánh giá
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? _lsRatingViews;

        [ObservableProperty] public object? _selectedRatingView;
    }
}
