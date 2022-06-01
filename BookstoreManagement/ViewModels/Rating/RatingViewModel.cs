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
    public partial class RatingViewModel : BaseViewModel<IRatingNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public RatingViewModel(IRatingNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
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
