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
    public partial class RatingExpanderViewModel : BaseViewModel
    {
        private readonly IModelRemote _model;

        public RatingExpanderViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        
        [ObservableProperty] private object? _ratingid;
        [ObservableProperty] object? _ratingcontent;
        [ObservableProperty] ObservableCollection<object>? _lsratingimage;
        [ObservableProperty] object? _ratingreply;
    }
}
