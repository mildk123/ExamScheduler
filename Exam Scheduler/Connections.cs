using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exam_Scheduler
{
    class Connections
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-TCRJGIG;Initial Catalog=examScheduler;Integrated Security=True");
        int id = 0;

        public void display()
        {
            Courses cor1 = new Courses();
            connect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Courses", connect);
            adapter.Fill(dt);
            cor1.CoursesGrid.DataSource = dt;
            connect.Close();

        }
    }
}
