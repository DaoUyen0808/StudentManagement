using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class Subjects
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }

        public Subjects()
        {
        }

        public Subjects(int subjectID, string subjectName, string description)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            Description = description;
        }
    }
}
