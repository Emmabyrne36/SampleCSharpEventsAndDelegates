using System;

namespace EventsAndDelegates2
{
    public class PaperGradedEventArgs : EventArgs
    {
        public string PaperName { get; set; }
        public string PaperGrade { get; set; }
    }
}