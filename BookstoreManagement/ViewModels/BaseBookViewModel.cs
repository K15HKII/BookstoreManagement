using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Linq;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace BookstoreManagement.ViewModels;

public partial class BaseBookViewModel : BaseViewModel
{
    private readonly IModelRemote _model;
    public BaseBookViewModel([NotNull] ScheluderProvider scheluderProvider,IModelRemote model) : base(scheluderProvider)
    {
        _model = model;
    }

    public void SetBook(Book book, int count)
    {
        this.Id = "#"+count;
        this.Title = book.Title;
        this.Price = book.Price;
        Publisher pub = _model.GetPublisher(book.PublisherId).Wait();
        this.Publisher = pub.Name;
        this.Description = book.Description;
        this.Quantity = book.Stock;
        if (this.Quantity > 0)
        {
            this.Status = "Còn hàng";
            
        }
        else
        {
            this.Status = "Hêt hàng";
        }
        
    }

    [ObservableProperty] private string? _id;
    [ObservableProperty] [Required] [MinLength(1)] private string? _title;
    [ObservableProperty] private string? _description;
    [ObservableProperty] private BookTag[] _tags;
    [ObservableProperty] private string? _authorId;
    [ObservableProperty] private string? _publisher;
    [ObservableProperty] [Required] [Range(Double.Epsilon, Double.MaxValue)] private double? _price;
    [ObservableProperty] private string? _status;
    [ObservableProperty] [Range(1, Int64.MaxValue)] private int _quantity = 0;
    [ObservableProperty] private ObservableCollection<string> _imageIds = new();

}