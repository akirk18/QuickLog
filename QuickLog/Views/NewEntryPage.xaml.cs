using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using QuickLog.ViewModels;
using Xamarin.Forms;

namespace QuickLog.Views
{
    public partial class NewEntryPage : ContentPage
    {
        NewEntryViewModel ViewModel => BindingContext as NewEntryViewModel;

        public NewEntryPage()
        {
            InitializeComponent();

            BindingContextChanged += NewEntryPage_BindingContextChanged;
        }

        private void NewEntryPage_BindingContextChanged(object sender, EventArgs e)
        {
            ViewModel.ErrorsChanged += ViewModel_ErrorsChanged;
        }

        private void ViewModel_ErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        {
            var propHasErrors = (ViewModel.GetErrors(e.PropertyName) as List<string>)?.Any() == true;

            switch (e.PropertyName)
            {
                case nameof(ViewModel.EntryType):
                    type.LabelColor = propHasErrors ? Color.Red : Color.Black;
                    break;
                case nameof(ViewModel.Data):
                    data.LabelColor = propHasErrors ? Color.Red : Color.Black;
                    break;
                default:
                    break;
            }
        }
    }
}
