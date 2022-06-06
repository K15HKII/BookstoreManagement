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
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.DialogView;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.Lend.LendAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Lend
{
    public partial class LendViewModel : PanelViewModel
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
        
        private void Initialize()
        {
            Dispose(_model.getListLend().Select(lends => lends.Select(lend =>
            {
                LendInfoViewModel vm = _factory.Create<LendInfoViewModel>();
                vm.SetLend(lend);
                return vm;
            })), books =>
            {
                /*Books.Clear();
                foreach (var vm in books)
                {
                    Books.Add(vm);
                }*/
            });
        }
        // Thiếu mở dialog thêm đơn mượn, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        private ObservableCollection<LendInfoViewModel> _sourceLends;
        public ObservableCollection<LendInfoViewModel>? SourceLends
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

        private void filter(ObservableCollection<LendInfoViewModel> source, ObservableCollection<LendInfoViewModel> target,
            Func<LendInfoViewModel, bool> predicate)
        {
            //TODO: tạo filter cho list Lend
            target.Clear();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    target.Add(item);
                }
            }
        }

        [ObservableProperty] private ObservableCollection<LendInfoViewModel>? _waitingLends;
        [ObservableProperty] private ObservableCollection<LendInfoViewModel>? _usingLends;
        [ObservableProperty] private ObservableCollection<LendInfoViewModel>? _finishLends;
        [ObservableProperty] private ObservableCollection<LendInfoViewModel>? _cancelledLends;


        [ObservableProperty] public ObservableCollection<LendInfoViewModel> _selectedLends;
        
        [ICommand]
        public async void AddNew()
        {
            LendUpdateRequest? request = await _navigator.OpenNewLendBillDialog(_factory.Create<AddLendBillViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
