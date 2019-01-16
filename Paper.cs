using System.Collections.Generic;

namespace EventsAndDelegates2
{
    public class Paper
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public static List<Paper> ListOfPapers = new List<Paper>
        {
            new Paper{Name = "On the Origin of Species"},
            new Paper{Name = "To Kill a Mockingbird"},
            new Paper{Name = "Romeo and Juliet"},
            new Paper{Name = "Macbeth"}
        };

    }
}