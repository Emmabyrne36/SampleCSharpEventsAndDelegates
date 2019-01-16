using System;
using System.Collections.Generic;

namespace EventsAndDelegates2
{
    public class Student
    {
        public event EventHandler<GradeChangedEventArgs> GradeChanged;
        public event EventHandler<PassedExamEventArgs> PassedExam;

        public static List<Student> StudentList = new List<Student>()
        {
            new Student {Name = "Juan", PaperSubmitted = Paper.ListOfPapers[0]},
            new Student {Name = "Jess", PaperSubmitted =  Paper.ListOfPapers[1]},
            new Student {Name = "David", PaperSubmitted =  Paper.ListOfPapers[2]},
            new Student {Name = "Lauren", PaperSubmitted =  Paper.ListOfPapers[3]}
        };        
        public string Name { get; set; }
        public bool IsGoodGrade { get; set; }
        public Paper PaperSubmitted { get; set; }

        private string _grade;
        public string Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                var oldGrade = _grade;
                _grade = value;
                GradeChangedEventArgs args = new GradeChangedEventArgs() { NewGrade = value };
                GradeChanged?.Invoke(this, args);
            }
        }

        public void OnGradeChanged(object sender, GradeChangedEventArgs args)
        {
            // Raise the other event here

            // 67 is the numeric value of 'C', so if the given grade is less than 67, it will be
            // a higher grade - A or B
            if ((int)args.NewGrade[0] < 67)
            {
                this.IsGoodGrade = true;
                PassedExam?.Invoke(this, new PassedExamEventArgs() { StudentName = this.Name, Grade = args.NewGrade[0], PaperName = this.PaperSubmitted.Name });
            }
        }
    }
}