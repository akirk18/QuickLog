using System;

using Xamarin.Forms;

namespace QuickLog.ViewModels
{
    public class BaseViewModel : ContentPage
    {
        public BaseViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

