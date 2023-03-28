using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class StudentAccess : DatabaseAccess
    {
        //Lay toan bo du lieu trong bang STUDENT
        public DataSet GetStudent()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from STUDENT", _conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //Them Student
        public bool InsertStudent(Student st)
        {
            try
            {
                _conn.Open();
                string sql = $"insert into STUDENT(StudentID, Name, ClassID) values ('{st.STUDENT_ID}','{st.STUDENT_NAME}','{st.CLASS_ID}')";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
            return false;
        }
        //Sua Student
        public bool UpdateStudent(Student st)
        {
            try
            {
                _conn.Open();
                string sql = $"update STUDENT set Name = '{st.STUDENT_NAME}', ClassID = '{st.CLASS_ID}' where  StudentID = '{st.STUDENT_ID}'";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
            return false;
        }
        //Xoa Student
        public bool DeleteStudent(Student st)
        {
            try
            {
                _conn.Open();
                string sql = $"delete from STUDENT where  StudentID = '{st.STUDENT_ID}'";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
            return false;
        }
    }
}
