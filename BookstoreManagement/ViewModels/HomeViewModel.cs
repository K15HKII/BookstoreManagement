﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {

        [ObservableProperty] public ObservableCollection<object>? tabContents;

        [ObservableProperty] public object? selectedContent;

    }
}
