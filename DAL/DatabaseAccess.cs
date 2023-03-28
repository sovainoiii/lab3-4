using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=MINH\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True");
    }
}
