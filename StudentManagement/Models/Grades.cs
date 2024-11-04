using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class Grades
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public Semester Semester { get; set; }
        public decimal Grade { get; set; }
        public bool IsDeleted { get; set; }

        public Grades()
        {
        }

        public Grades(int gradeID, int studentID, int subjectID, Semester semester, decimal grade, bool isDeleted)
        {
            GradeID = gradeID;
            StudentID = studentID;
            SubjectID = subjectID;
            Semester = semester;
            Grade = grade;
            IsDeleted = isDeleted;
        }
    }
    public enum Semester
    {
        Semester1 = 1,
        Semester2 = 2
    }
}

