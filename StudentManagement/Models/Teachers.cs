using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class Teachers
    {
        public int TeacherID { get; set; }
        public string FullName { get; set; }
        public int SubjectID { get; set; }
        public string PhoneNumber { get; set; }

        public Teachers()
        {
        }

        public Teachers(int teacherID, string fullName, int subjectID, string phoneNumber)
        {
            TeacherID = teacherID;
            FullName = fullName;
            SubjectID = subjectID;
            PhoneNumber = phoneNumber;
        }
    }
}
