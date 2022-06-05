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

namespace BookstoreManagement.ViewModels.DialogView
{
    public partial class AddLendBillViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;

        public AddLendBillViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }

        [ObservableProperty] 
        [Required]
        private string? _customerId;
        
        [ObservableProperty]
        [Required]
        private string? _customerName;
        
        [ObservableProperty] 
        [Required]
        private string? _customerPhone;
        
        [ObservableProperty] 
        [Required]
        private string? _customerAddress;
        
        [ObservableProperty] 
        [Required]
        private string? _lendBookName;
        
        // [NotNull]
        // [ItemNotNull]
        // public List<Book> PublisherSource
        // {
        //     get
        //     {
        //         List<Book>? publisherSource = null;
        //         Dispose(_model.getListBook(), result => publisherSource = result);
        //         return publisherSource!;
        //     }
        // }
        // [ObservableProperty] private Book? _book;
        
//        [ObservableProperty] object? lendBookId;
//        [ObservableProperty] object? lendBookName;

        [ObservableProperty]
        [Required]
        private string? _voucher;

        [ObservableProperty]
        [Required]
        private int? _price;
        
        [ObservableProperty]
        [Required]
        private string? _type;
        
        [ObservableProperty]
        [Required]
        private DateTime? _lendDate;
        
        [ObservableProperty] 
        [Required]
        private DateTime? _lendExpired;
        
        [ObservableProperty] 
        [Required]
        private string? _bookImage;
        
        [ObservableProperty]
        [Required]
        private string? _note;
        
        public LendUpdateRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new LendUpdateRequest()
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
