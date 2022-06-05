using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;

namespace BookstoreManagement.ViewModels.DialogView.Order.Adapter
{
    public partial class OrderItemViewModel : BaseViewModel
    {
        private readonly IModelRemote _model;

        public OrderItemViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        
        [ObservableProperty] object? _image;
        [ObservableProperty] object? _type;
        [ObservableProperty] object? _quantity;
        [ObservableProperty] object? _price;
    }
}
