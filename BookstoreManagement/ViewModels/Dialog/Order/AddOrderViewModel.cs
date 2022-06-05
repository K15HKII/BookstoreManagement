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
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Order
{
    public partial class AddOrderViewModel : BaseViewModel, IDialog
    {
        //Còn khúc thêm sách chưa rõ ràng
        
        private readonly IModelRemote _model;

        public AddOrderViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }

        [ObservableProperty] object? _id;
        [ObservableProperty] object? _name;
        [ObservableProperty] object? _phone;
        [ObservableProperty] object? _address;
        [ObservableProperty] object? _description;
        
        public BillUpdateRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new BillUpdateRequest()
            {

            };
        }
        
        public event Action<object?>? CloseAction;
        
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public void Accept()
        {
            CloseAction?.Invoke(ToAddRequest());
        }
    }
}
