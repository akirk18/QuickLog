using System;
using System.ComponentModel;
using System.Threading.Tasks;
using QuickLog.ViewModels;

namespace QuickLog.Services
{
    public interface INavService
    {
        bool CanGoBack { get; }
        Task GoBack();
        Task NavigateTo<TVM>() where TVM : BaseViewModel;
        Task NavigateTo<TVM, TParameter>(TParameter parameter) where TVM : BaseViewModel;
        Task NavigateToUriAsync(Uri uri);
        void RemoveLastView();
        void ClearBackStack();
        event PropertyChangedEventHandler CanGoBackChanged;
    }
}
