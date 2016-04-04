using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Student: EventArgs
    {
        

        public Student(String studentID, String firstName, String lastName, String department, String enrollmentType)
        {
            this.department = department;
            this.enrollmentType = enrollmentType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = studentID;
            

        }
        public String studentID {  get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String department { get; set; }
        public String enrollmentType { get; set; }

        public override string ToString()
        {
            return studentID;
        }




    }
}
