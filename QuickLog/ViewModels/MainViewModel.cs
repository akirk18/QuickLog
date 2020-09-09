using System;
using System.Collections.ObjectModel;
using QuickLog.Models;

namespace QuickLog.ViewModels
{
    public class MainViewModel : BaseViewModel
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
    }
}
