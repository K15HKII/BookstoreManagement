using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter
{
    public partial class LendInfoViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ILendInfoNavigator _navigator;

        public LendInfoViewModel(ILendInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }

        public void SetLend(Data.Model.Lend lend)
        {
            this.Id = lend.Id;
            this.UserId = lend.UserId;
            User cus = _model.getUser(lend.UserId).Wait();
            this.UserName = cus.FirstName + cus.LastName;
            this.Price = lend.UnitPrice;
            this.BookId = lend.BookId;
            this.Start = lend.StartDate;
            this.End = lend.EndDate;
        }

        [ObservableProperty] string? _id;

        [ObservableProperty] string? _userId;
        
        [ObservableProperty] string? _userName;
        
        [ObservableProperty] string? _userImage;

        [ObservableProperty] double? _price;

        [ObservableProperty] DateTime? _start;

        [ObservableProperty] DateTime? _end;

        [ObservableProperty] object? _state;

        [ObservableProperty] string? _bookId;

        [ObservableProperty] bool? _selected;
    }
}
