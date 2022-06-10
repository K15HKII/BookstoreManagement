using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Order;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter;

public class OrderInfoNavigator : IOrderInfoNavigator
{
    private readonly IDialogService _dialogService;

    public OrderInfoNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    public object? OpenDetailOrdedrDialog(OrderBillViewModel viewModel)
    {
        object? value = _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value;
    }
}