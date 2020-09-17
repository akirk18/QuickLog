using System;
using System.Collections.ObjectModel;
using QuickLog.Models;
using QuickLog.Services;
using Xamarin.Forms;

namespace QuickLog.ViewModels
{
    public class LogDetailViewModel : BaseViewModel
    {
        private ObservableCollection<LogEntry> _logEntries;
        public ObservableCollection<LogEntry> LogEntries
        {
            get => _logEntries;
            set
            {
                _logEntries = value;
                OnPropertyChanged();
            }
        }

        public Command NewEntryCommand => new Command(async () =>
        {
            await NavService.NavigateTo<NewEntryViewModel>();
        });

        public LogDetailViewModel(INavService navService) : base(navService)
        {
            LogEntries = new ObservableCollection<LogEntry>();
        }

        public override void Init()
        {
            LoadEntries();
        }

        private void LoadEntries()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                LogEntries.Clear();
                LogEntries.Add(new LogEntry
                {
                    EntryType = "Weight",
                    Data = "100",
                    Date = DateTime.Now
                });

                LogEntries.Add(new LogEntry
                {
                    EntryType = "Weight",
                    Data = "120",
                    Date = DateTime.Now
                });

                LogEntries.Add(new LogEntry
                {
                    EntryType = "Weight",
                    Data = "140",
                    Date = DateTime.Now
                });
            }

            finally
            {
                IsBusy = false;
            }
        }
    }
}
