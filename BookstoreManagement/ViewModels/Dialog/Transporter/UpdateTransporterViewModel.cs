using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Supplier
{
    public partial class UpdateTransporterViewModel : BaseViewModel,IDialog
    {
        private readonly IModelRemote _model;

        public UpdateTransporterViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }
        //TODO: thiết kế nhà cung cấp chưa đúng còn thiếu
        
        public void SetPublisher(Publisher publisher)
        { 
            this.Id = "#" + publisher.Id;
            this.Name = publisher.Name;
            this.Description = publisher.Description;
            this.CoopDate = publisher.CreatedAt;
        }

        [ObservableProperty]
        private string? _image;
        
        [ObservableProperty]
        private string? _id;

        [ObservableProperty]
        [Required]
        private string? _name;
        
        [ObservableProperty]
        private string? _address;
        
        [ObservableProperty]
        private DateTime? _coopDate;
        
        [ObservableProperty]
        private DateTime? _createDate;

        [ObservableProperty]
        private string? _bookType;
        
        [ObservableProperty]
        private string? _phone;
        
        [ObservableProperty]
        private string? _email;
        
        [ObservableProperty]
        private string? _description;


        public PublisherUpdateRequest? ToRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new PublisherUpdateRequest()
            {
                /*//TODO: Chưa tự generate id
                Name = Name,*/
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
            CloseAction?.Invoke(ToRequest());
            
        }
    }
}
