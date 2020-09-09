using System;
namespace QuickLog.Models
{
    public class LogEntry
    {
        public string EntryType { get; set; }
        public string Data { get; set; }
        public DateTime Date { get; set; }
    }
}
