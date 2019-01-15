using System;

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
            PaperGraded?.Invoke(this, new PaperGradedEventArgs() { PaperName = paper.Name, PaperGrade = paper.Grade});
        }
    }
}