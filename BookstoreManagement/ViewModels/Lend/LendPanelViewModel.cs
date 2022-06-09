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
            Initialize();
        }
        
        private void Initialize()
        {
            Dispose(_model.GetLends().Select(lends => lends.Select(lend =>
            {
                LendInfoViewModel vm = _factory.Create<LendInfoViewModel>();
                vm.SetLend(lend);
                return vm;
            })), books =>
            {
                Source.Clear();
                foreach (var vm in books)
                {
                    Source.Add(vm);
                }
                Filter(Source, UsingLends, vm => vm.Status == LendStatus.USING);
                Filter(Source, FinishLends, vm => vm.Status == LendStatus.FINISHED);
                Filter(Source, CancelledLends, vm => vm.Status == LendStatus.CANCELED);
            });
        }

        private void Filter(ObservableCollection<LendInfoViewModel> source, ObservableCollection<LendInfoViewModel> target,
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

        [ObservableProperty] private ObservableCollection<LendInfoViewModel> _source = new();
        [ObservableProperty] private ObservableCollection<LendInfoViewModel> _usingLends = new();
        [ObservableProperty] private ObservableCollection<LendInfoViewModel> _finishLends = new();
        [ObservableProperty] private ObservableCollection<LendInfoViewModel> _cancelledLends = new();


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
