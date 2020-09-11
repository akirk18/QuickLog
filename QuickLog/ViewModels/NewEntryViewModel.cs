using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using QuickLog.Models;
using QuickLog.Services;
using Xamarin.Forms;

namespace QuickLog.ViewModels
{
    public class NewEntryViewModel : BaseValidationViewModel
    {
        private string _entryType;
        public string EntryType
        {
            get => _entryType;
            set
            {
                _entryType = value;
                Validate(() => !string.IsNullOrWhiteSpace(_entryType), "Need entry type");

            }
        }

        private string _data;
        public string Data
        {
            get => _data;
            set
            {
                _data = value;
                Validate(() => !string.IsNullOrWhiteSpace(_data), "Need data");

            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        private Command _saveCommand;
        public Command SaveCommand => _saveCommand ?? (_saveCommand = new Command(async () => await Save(), CanSave));

        public NewEntryViewModel(INavService navService) : base(navService)
        {
            Date = DateTime.Today;
        }

        private async Task Save()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var newLog = new LogEntry
                {
                    EntryType = EntryType,
                    Data = Data,
                    Date = Date
                };

                await NavService.GoBack();
            }
            finally
            {
                IsBusy = false;
            }
        }

        private bool CanSave() => !string.IsNullOrWhiteSpace(EntryType) && !string.IsNullOrWhiteSpace(Data) && !HasErrors;
    }
}
