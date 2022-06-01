using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Order;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter
{
    public partial class OrderInfoViewModel : BaseViewModel<IOrderInfoNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public OrderInfoViewModel(IOrderInfoNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }
        
        [ObservableProperty] object? _iD;

        [ObservableProperty] DateTime? _date;

        [ObservableProperty] object? _owner;

        [ObservableProperty] object? _price;

        [ObservableProperty] object? _bookId;

        [ObservableProperty] object? _unitPrice;

        [ICommand]
        public void OpenInfo()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenDetailOrdedrDialog(_factory.Create<OrderBillViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
