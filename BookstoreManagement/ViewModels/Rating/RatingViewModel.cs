﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
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
            /*Dispose(_model.GetFeedbacks(), feedbacks =>
            {
                Feedbacks.Clear();
                feedbacks.ForEach(feedback =>
                {
                    RatingInfoViewModel vm = _factory.Create<RatingInfoViewModel>();
                    vm.SetFeedback(feedback);
                    Feedbacks.Add(vm);
                });
            });*/
        }

        [ObservableProperty] public ObservableCollection<RatingInfoViewModel> _feedbacks = new();

        [ObservableProperty] public object? _selectedRatingView;
    }
}
