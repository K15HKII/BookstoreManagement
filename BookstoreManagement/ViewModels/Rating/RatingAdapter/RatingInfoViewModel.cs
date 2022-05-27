using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Rating.RatingAdapter
{
    public partial class RatingInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? ratingId;

        [ObservableProperty] object? productId;

        [ObservableProperty] object? bookName;

        [ObservableProperty] object? rateOwner;

        [ObservableProperty] object? starQuantity;
    }
}
