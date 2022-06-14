using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Supplier
{
    public partial class TransporterDetailViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;
        private readonly ITransporterDetailNavigator _navigator;

        public TransporterDetailViewModel(ITransporterDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }
        
        public void SetPublisher(Publisher publisher)
        {
            current = publisher;
            this.Id = "#" + publisher.Id;
            this.Name = publisher.Name;
            this.Description = publisher.Description;
            this.CoopDate = publisher.CreatedAt;
        }

        private Publisher current;
        [ObservableProperty] string? _id;
        [ObservableProperty] Image? _image;
        [ObservableProperty] object? _name;
        [ObservableProperty] object? _phone;
        [ObservableProperty] object? _email;
        [ObservableProperty] object? _address;
        [ObservableProperty] object? _bookQuantity;
        [ObservableProperty] object? _bookType;
        [ObservableProperty] DateTime? _coopDate;
        [ObservableProperty] object? _description;
        
        public event Action<object?>? CloseAction;
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public async void OpenEdit()
        {
            UpdateTransporterViewModel vm = _factory.Create <UpdateTransporterViewModel>();
            /*vm.SetPublisher(current);*/
            /*object? request = await _navigator.OpenEditTransporterDialog(vm);*/

            /*if (request == null)
                return;*/

            //TODO: send request to server*/
        }
    }
}
