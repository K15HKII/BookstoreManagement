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

        [ObservableProperty] object? _productid;

        [ObservableProperty] private object? _bookimage;

        [ObservableProperty] object? _bookname;

        [ObservableProperty] object? _rateowner;

        [ObservableProperty] object? _starquantity;
        
        [ObservableProperty] object? _ratingcontent;
        
        [ObservableProperty] ObservableCollection<object>? _lsratingimage;
        
        [ObservableProperty] object? _ratingreply;
    }
}
