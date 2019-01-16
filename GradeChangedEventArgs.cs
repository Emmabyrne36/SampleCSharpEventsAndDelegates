using System;

namespace EventsAndDelegates2
{
    public class GradeChangedEventArgs : EventArgs
    {
        public string NewGrade { get; set; }
    }
}