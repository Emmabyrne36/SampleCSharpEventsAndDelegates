using System;
using System.Collections.Generic;

namespace EventsAndDelegates2
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher t1 = new Teacher();
            t1.PaperGraded += OnPaperGraded;

            new List<Paper>
            {
                new Paper{Name = "On the Origin of Species"},
                new Paper{Name = "To Kill a Mockingbird"},
                new Paper{Name = "Romeo and Juliet"},
                new Paper{Name = "Macbeth"}
            }.ForEach(p => t1.GradePaper(p));
        }

        public static void OnPaperGraded(object sender, PaperGradedEventArgs args)
        {
            Console.WriteLine($"The paper {args.PaperName} received a grade of: {args.PaperGrade}");
        }
    }
}
