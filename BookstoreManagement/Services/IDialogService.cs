using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels;

namespace BookstoreManagement.Services
{
    public interface IDialogService
    {

        Task<object?> Show<T>(T viewModel, string? hostId = null) where T : BaseViewModel;

        void Close(string? hostId = null, object? parameters = null);

    }
}
