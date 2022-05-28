using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels;
using MaterialDesignThemes.Wpf;

namespace BookstoreManagement.Services.Common
{
    public class DialogService : IDialogService
    {
        public async Task<object?> Show<T>(T viewModel, string? hostId = null) where T : BaseViewModel
        {
            if (viewModel is IDialog dialog)
            {
                void OnClose(object? o)
                {
                    Close(hostId, o);
                    dialog.CloseAction -= OnClose;
                }
                dialog.CloseAction += OnClose;
            }
            return await DialogHost.Show(viewModel, hostId);
        }

        public void Close(string? hostId = null, object? parameter = null)
        {
            DialogHost.Close(hostId, parameter);
        }
    }
}
