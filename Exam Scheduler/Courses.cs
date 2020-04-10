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
    public partial class Courses : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4USG0EK\\SQLEXPRESS;Initial Catalog=examScheduler;Integrated Security=True");
        public Courses()
        {
            InitializeComponent();
        }

       private void getAddedCourses()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Courses", con);
            adapter.Fill(dt);
            CoursesGrid.DataSource = dt;
            CoursesGrid.Columns[0].Width = 100;
            CoursesGrid.Columns[1].Width = 350;
            CoursesGrid.Columns[2].Width = 150;
            CoursesGrid.Columns[3].Width = 150;
            CoursesGrid.Columns[4].Width = 200;
            CoursesGrid.Columns[5].Width = 150;
            CoursesGrid.RowTemplate.Height = 30;
            con.Close();
        }

       private void clear()
       {
           courseNameBox.Clear();
           courseIDBox.Clear();
           semsBox.SelectedIndex = -1;
           crHourBox.SelectedIndex = -1;
       }

       private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes == true)
            {
                if (courseNameBox.Text != "" && departBox.Text != "" && courseIDBox.Text != "" && semsBox.Text != "" && crHourBox.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"insert into Courses (Course_Name,Course_Department,Course_ID,Semester,Course_CrHours) 
                    values(@courseName,@CourseDepart,@CourseID,@sems,@crHours)", con);
                    cmd.Parameters.AddWithValue("@courseName", courseNameBox.Text);
                    cmd.Parameters.AddWithValue("@CourseDepart", departBox.Text);
                    cmd.Parameters.AddWithValue("@CourseID", courseIDBox.Text);
                    cmd.Parameters.AddWithValue("@sems", semsBox.Text);
                    cmd.Parameters.AddWithValue("@crHours", crHourBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record inserted sucessfully");
                    getAddedCourses();
                    clear();
                }
                else
                {
                    MessageBox.Show("Data Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            getAddedCourses();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            getAddedCourses();
        }

    }
}
