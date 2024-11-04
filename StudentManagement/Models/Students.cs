using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class Students
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ClassID { get; set; }
        public bool IsDeleted { get; set; }

        public Students()
        {
        }

        public Students(int studentID, string fullName, DateTime dateOfBirth, bool gender, string address, string phoneNumber, string email, int classID, bool isDeleted)
        {
            StudentID = studentID;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            ClassID = classID;
            IsDeleted = isDeleted;
        }
    }
}
