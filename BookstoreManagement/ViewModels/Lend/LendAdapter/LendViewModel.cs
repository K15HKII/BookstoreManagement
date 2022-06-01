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
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter
{
    public partial class LendViewModel : BaseViewModel
    {
        private readonly IModelRemote _model;

        public LendViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        
        [ObservableProperty] string? _id;

        [ObservableProperty] string? _userId;
        
        [ObservableProperty] string? _userImage;

        [ObservableProperty] object? _start;

        [ObservableProperty] object? _end;

        [ObservableProperty] object? _state;

        [ObservableProperty] ObservableCollection<BaseBookViewModel<DumpNavigator>>? _books;

        [ObservableProperty] bool? _selected;
    }
}
