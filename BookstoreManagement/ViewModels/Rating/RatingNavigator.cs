using BookstoreManagement.Services;

namespace BookstoreManagement.ViewModels.Rating;

public class RatingNavigator : IRatingNavigator
{
    private readonly IDialogService _dialogService;

    public RatingNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
}