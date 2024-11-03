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
        public string className { get; set; }
        public int TeacherID { get; set; }

        public Classes()
        {
        }

        public Classes(int classID, string className, int teacherID)
        {
            ClassID = classID;
            this.className = className;
            TeacherID = teacherID;
        }
    }
}
