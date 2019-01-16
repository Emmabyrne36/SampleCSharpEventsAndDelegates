using System;
using System.Linq;

namespace EventsAndDelegates2
{
    public class Teacher
    {
        // Create the event handler
        public event EventHandler<PaperGradedEventArgs> PaperGraded;

        public void GradePaper(Paper paper)
        {
            string[] letterGrades = { "A", "B", "C", "D", "E", "F" };
            Random rnd = new Random();
            int r = rnd.Next(letterGrades.Length);

            // Get a random grade to give to the paper
            paper.Grade = letterGrades[r];
            // Call the event here
            PaperGraded?.Invoke(this, new PaperGradedEventArgs() { PaperName = paper.Name, PaperGrade = paper.Grade });

            // Get a student
            Student s1 = (Student)Student.StudentList
                            .Select(s => s)
                            .Where(s => s.PaperSubmitted.Name.Equals(paper.Name))
                            .ToList()[0];
            s1.Grade = paper.Grade;
        }
    }
}