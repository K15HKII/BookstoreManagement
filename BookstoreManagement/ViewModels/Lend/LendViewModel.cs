using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.DialogView;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Lend
{
    public partial class LendViewModel : BaseViewModel<ILendNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public LendViewModel(ILendNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }
        
        // Thiếu mở dialog thêm đơn mượn, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsLendBills;

        [ObservableProperty] public object? selectedLendBill;
        
        [ICommand]
        public void AddNew()
        {
            LendAddRequest? request = Navigator!.OpenNewLendBillDialog(_factory.Create<AddLendBillViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
