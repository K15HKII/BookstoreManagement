using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.Order;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter;

public interface IOrderInfoNavigator : INavigator
{
    Task<object?> OpenDetailOrdedrDialog(OrderBillViewModel viewModel); //TODO: return edit request
}