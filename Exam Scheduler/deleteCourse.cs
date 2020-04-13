using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exam_Scheduler
{
    public partial class deleteCourse : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4USG0EK\\SQLEXPRESS;Initial Catalog=examScheduler;Integrated Security=True");

        public deleteCourse()
        {
            InitializeComponent();
            getAllCourses();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string courseIdToDelete = courseIDBox.Text;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Courses where Course_ID='" + courseIdToDelete + "'", con);
            adapter.Fill(dt);
            AllCourses.DataSource = dt;
            AllCourses.Columns[0].Width = 100;
            AllCourses.Columns[1].Width = 350;
            AllCourses.Columns[2].Width = 150;
            AllCourses.Columns[3].Width = 150;
            AllCourses.Columns[4].Width = 200;
            AllCourses.Columns[5].Width = 150;
            AllCourses.RowTemplate.Height = 30;
            con.Close();
        }


        private void getAllCourses()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Courses", con);
            adapter.Fill(dt);
            AllCourses.DataSource = dt;
            AllCourses.Columns[0].Width = 100;
            AllCourses.Columns[1].Width = 350;
            AllCourses.Columns[2].Width = 150;
            AllCourses.Columns[3].Width = 150;
            AllCourses.Columns[4].Width = 200;
            AllCourses.Columns[5].Width = 150;
            AllCourses.RowTemplate.Height = 30;
            con.Close();
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string courseIdToDelete = courseIDBox.Text;
                con.Open();
                SqlCommand cmd1 = new SqlCommand("delete from schedule where CourseID='" + courseIdToDelete + "'", con);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("delete from Courses where Course_ID='" + courseIdToDelete + "'", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                getAllCourses();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error");   
            }
           
        }
    }
}
