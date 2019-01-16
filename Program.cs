using System;
using System.Collections.Generic;
using System.Linq;

namespace EventsAndDelegates2
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher t1 = new Teacher();
            t1.PaperGraded += OnPaperGraded;
            //Student.StudentList.ForEach(s => s.GradeChanged += s.OnGradeChanged);
            //Student.StudentList.ForEach(s => s.PassedExam += OnPassedPaper);
            // Assign the events
            Student.StudentList.ForEach(s =>
            {
                s.GradeChanged += s.OnGradeChanged;
                s.PassedExam += OnPassedPaper;
            });
            Paper.ListOfPapers.ForEach(p => t1.GradePaper(p));
        }

        private static void OnPassedPaper(object sender, PassedExamEventArgs e)
        {
            System.Console.WriteLine($"Student {e.StudentName} passed their paper '{e.PaperName}' with a grade of {e.Grade}\n");
        }

        public static void OnPaperGraded(object sender, PaperGradedEventArgs args)
        {
            Console.WriteLine($"The paper {args.PaperName} received a grade of: {args.PaperGrade}");
        }
    }
}
