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

namespace BookstoreManagement.ViewModels.Rating.RatingAdapter
{
    public partial class RatingInfoViewModel : BaseViewModel
    {
        private readonly IModelRemote _model;

        public RatingInfoViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }

        
        [ObservableProperty] object? _id;

        [ObservableProperty] object? _productId;

        [ObservableProperty] private object? _bookImage;

        [ObservableProperty] object? _bookName;

        [ObservableProperty] object? _rateOwner;

        [ObservableProperty] object? _starQuantity;
        
        [ObservableProperty] object? _ratingContent;
        
        [ObservableProperty] ObservableCollection<object>? _lsRatingImage;
        
        [ObservableProperty] object? _RatingReply;
    }
}
