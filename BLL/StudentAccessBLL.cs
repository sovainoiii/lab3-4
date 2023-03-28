using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class StudentAccessBLL
    {
        StudentAccess dalStudent = new StudentAccess();
        public DataSet GetStudent()
        {
            return dalStudent.GetStudent();
        }
        public bool InsertStudent(Student st)
        {
            return dalStudent.InsertStudent(st);
        }
        public bool UpdateStudent(Student st)
        {
            return dalStudent.UpdateStudent(st);
        }
        public bool DeleteStudent(Student st)
        {
            return dalStudent.DeleteStudent(st);
        }
    }
}
