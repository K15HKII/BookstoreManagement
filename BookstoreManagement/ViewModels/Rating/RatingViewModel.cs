using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Rating
{
    public class RatingViewModel : BaseViewModel<RatingNavigator>
    {
        //Thiếu xoá đánh giá
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsRatingViews;

        [ObservableProperty] public object? selectedRatingView;
    }
}
