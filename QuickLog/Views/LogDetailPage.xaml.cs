using System;
using System.Collections.Generic;
using QuickLog.ViewModels;
using Xamarin.Forms;

namespace QuickLog.Views
{
    public partial class LogDetailPage : ContentPage
    {
        LogDetailViewModel ViewModel => BindingContext as LogDetailViewModel;

        public LogDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel?.Init();
        }
    }
}
