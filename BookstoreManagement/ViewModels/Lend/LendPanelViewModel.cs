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
using BookstoreManagement.ViewModels.Lend.LendAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Lend
{
    public partial class LendViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ILendNavigator _navigator;

        public LendViewModel(ILendNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }
        
        // Thiếu mở dialog thêm đơn mượn, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        private ObservableCollection<LendViewModel> _sourceLends;
        public ObservableCollection<LendViewModel>? SourceLends
        {
            get => _sourceLends;
            set
            {
                _sourceLends = value;
                _sourceLends.CollectionChanged += (sender, args) =>
                {
                    //TODO: apply filter logic
                    filter(_sourceLends, WaitingLends, model =>
                    {
                        return true;
                    });
                };
            }
        }

        private void filter(ObservableCollection<LendViewModel> source, ObservableCollection<LendViewModel> target,
            Func<LendViewModel, bool> predicate)
        {
            target.Clear();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    target.Add(item);
                }
            }
        }

        [ObservableProperty] private ObservableCollection<LendViewModel>? _waitingLends;
        [ObservableProperty] private ObservableCollection<LendViewModel>? _usingLends;
        [ObservableProperty] private ObservableCollection<LendViewModel>? _finishLends;
        [ObservableProperty] private ObservableCollection<LendViewModel>? _cancelledLends;


        [ObservableProperty] public ObservableCollection<LendViewModel> _selectedLends;
        
        [ICommand]
        public void AddNew()
        {
            LendAddRequest? request = _navigator.OpenNewLendBillDialog(_factory.Create<AddLendBillViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
