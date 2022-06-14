using System;
using System.Reactive.Linq;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

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

        public void SetLend(Data.Model.Api.Lend lend, int count)
        {
            current = lend;
            this.Id = "#" + count;
            this.UserId = lend.UserId;
            Dispose(_model.GetUser(lend.UserId), user =>
            {
                this.UserName = user.FullName;
            });
            this.Price = lend.UnitPrice.ToString("C") + "đ";
            this.BookId = lend.BookId;
            this.Start = lend.StartDate.Date.ToString("dd/MM/yyyy");
            this.End = lend.EndDate;
            this.Status = lend.Status;
        }

        private Data.Model.Api.Lend current;

        [ObservableProperty] string? _id;

        [ObservableProperty] string? _userId;

        [ObservableProperty] private string? _userName;

        [ObservableProperty] string? _userImage;

        [ObservableProperty] string? _price;

        [ObservableProperty] string? _start;

        [ObservableProperty] DateTime? _end;

        [ObservableProperty] object? _state;

        [ObservableProperty] string? _bookId;

        [ObservableProperty] bool? _selected;

        [ObservableProperty] private LendStatus? _status;

        [ICommand]
        public async void OpenInfo()
        {
            LendBillDetailViewModel vm = _factory.Create<LendBillDetailViewModel>();
            vm.SetLend(current);
            object? request = await _navigator.OpenInfoLendDialog(vm);

            if (request == null)
                return;
        }
    }
}
