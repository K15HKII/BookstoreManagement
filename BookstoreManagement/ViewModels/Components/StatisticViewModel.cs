using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels.Components;

public partial class StatisticViewModel : BaseViewModel
{

    [ObservableProperty] private string _title;
    [ObservableProperty] private double _growth;
    [ObservableProperty] private string _displayValue;

}