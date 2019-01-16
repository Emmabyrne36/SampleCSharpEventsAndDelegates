using System;

namespace EventsAndDelegates2
{
    public class PassedExamEventArgs : EventArgs
    {
        public string StudentName { get; set; }
        public string PaperName { get; set; }
        public char Grade { get; set; }
    }
}