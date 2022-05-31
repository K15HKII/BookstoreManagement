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

namespace BookstoreManagement.ViewModels.Order.Page
{
    public partial class ArrivedPageViewModel : BaseViewModel
    {
        private readonly IModelRemote _model;

        public ArrivedPageViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        
        [ObservableProperty] public ObservableCollection<object>? _lsorders;

        [ObservableProperty] public object? _selectedorder;
    }
}
