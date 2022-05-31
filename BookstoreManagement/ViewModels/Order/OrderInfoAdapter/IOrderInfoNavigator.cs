using BookstoreManagement.ViewModels.DialogView.Order;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter;

public interface IOrderInfoNavigator : INavigator
{
    object? OpenDetailOrdedrDialog(OrderBillViewModel viewModel); //TODO: return edit request
}