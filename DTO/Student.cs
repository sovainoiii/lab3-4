using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {
        public string _STUDENT_ID;
        public string _STUDENT_NAME;
        public string _CLASS_ID;
        public string STUDENT_ID
        {
            get { return _STUDENT_ID;}
            set { _STUDENT_ID = value;}
        }
        public string STUDENT_NAME
        {
            get { return _STUDENT_NAME;}
            set { _STUDENT_NAME = value;}
        }
        public string CLASS_ID
        {
            get { return _CLASS_ID;}
            set { _CLASS_ID = value;}
        }
        public Student()
        {
        }
        public Student(string sTUDENT_ID, string sTUDENT_NAME, string cLASS_ID)
        {
            STUDENT_ID = sTUDENT_ID;
            STUDENT_NAME = sTUDENT_NAME;
            CLASS_ID = cLASS_ID;
        }
    }
}
