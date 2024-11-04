using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class Classes
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int TeacherID { get; set; }
        public bool IsDeleted { get; set; }

        public Classes()
        {
        }

        public Classes(int classID, string className, int teacherID, bool isDeleted)
        {
            ClassID = classID;
            ClassName = className;
            TeacherID = teacherID;
            IsDeleted = isDeleted;
        }
    }
}
