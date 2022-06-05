using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace BookstoreManagement.ViewModels;

public partial class BaseBookViewModel : BaseViewModel
{
    
    public BaseBookViewModel([NotNull] ScheluderProvider scheluderProvider) : base(scheluderProvider)
    {
    }

    public void SetBook(Book book)
    {
        this.Id = book.Id;
        this.Title = book.Title;
        this.Description = book.Description;
        //TODO:
    }

    [ObservableProperty] private string? _id;
    [ObservableProperty] [Required] [MinLength(1)] private string? _title;
    [ObservableProperty] private string? _description;
    [ObservableProperty] private BookTag[] _tags;
    [ObservableProperty] private string? _authorId;
    [ObservableProperty] private string? _publisherId;
    [ObservableProperty] [Required] [Range(Double.Epsilon, Double.MaxValue)] private double? _price;
    [ObservableProperty] [Range(1, Int64.MaxValue)] private int _quantity = 1;
    [ObservableProperty] private ObservableCollection<string> _imageIds = new();

}