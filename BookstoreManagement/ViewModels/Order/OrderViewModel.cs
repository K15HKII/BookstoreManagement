using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Order
{
    public partial class OrderViewModel : BaseViewModel<IOrderNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public OrderViewModel(IOrderNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        //TODO: Thiếu mở dialog xoá đơn và thêm đơn hàng

        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? tabContents;

        [ObservableProperty] public object? selectedContent;

        [ObservableProperty] public object? orderBillQuantity;
    }
}
