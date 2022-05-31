using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;

namespace BookstoreManagement.ViewModels.Order.Page
{
    public partial class CancleViewModel : BaseViewModel
    {
        private readonly IModelRemote _model;

        public CancleViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        
        [ObservableProperty] public ObservableCollection<object>? lsOrders;

        [ObservableProperty] public object? _selectedorder;
    }
}
