using System;
using System.Collections.Generic;
using QuickLog.ViewModels;
using Xamarin.Forms;

namespace QuickLog.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel ViewModel => BindingContext as HomeViewModel;

        public HomePage()
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
