using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Rating.RatingAdapter
{
    public class RatingInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? RatingId;

        [ObservableProperty] object? ProductId;

        [ObservableProperty] object? BookName;

        [ObservableProperty] object? RateOwner;

        [ObservableProperty] object? StarQuantity;
    }
}
