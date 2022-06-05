using BookstoreManagement.Annotations;
using BookstoreManagement.Utils;

namespace BookstoreManagement.ViewModels;

public abstract class PanelViewModel : BaseViewModel
{
    public PanelViewModel([NotNull] ScheluderProvider scheluderProvider) : base(scheluderProvider)
    {
    }

    public void openAccount()
    {
    }

    public void openNotificaiton()
    {
    }
    
}