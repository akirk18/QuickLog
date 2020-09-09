using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using QuickLog.Services;
using Xamarin.Forms;

namespace QuickLog.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected INavService NavService { get; set; }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        protected BaseViewModel(INavService navService)
        {
            NavService = navService;
        }

        public virtual void Init() { }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class BaseViewModel<TParameter> : BaseViewModel
    {
        protected BaseViewModel(INavService navService) : base(navService) { }

        public override void Init()
        {
            Init(default(TParameter));
        }

        public virtual void Init(TParameter parameter) { }
    }
}

