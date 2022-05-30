namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter;

public interface IOrderInfoViewModel : INavigator
{
    object? OpenDetailBookDialog(OrderInfoViewModel viewModel); //TODO: return edit request
}