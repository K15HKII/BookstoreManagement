using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Rating.RatingAdapter
{
    public partial class RatingExpanderViewModel : BaseViewModel
    {
        [ObservableProperty] object? ratingContent;
        [ObservableProperty] ObservableCollection<object>? lsRatingImage;
        [ObservableProperty] object? lsRatingReply;
    }
}
