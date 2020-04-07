using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Exam_Scheduler
{
    public partial class Courses : Form
    {
        //SqlConnection connect = new SqlConnection("Data Source=DESKTOP-TCRJGIG;Initial Catalog=examScheduler;Integrated Security=True");
        public Courses()
        {
            InitializeComponent();
            GetCourses();
        }
     
        void GetCourses()
        {
        //    connect.Open();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter("select * from Courses", connect);
        //    adapter.Fill(dt);
        //    CoursesGrid.DataSource = dt;
        //    connect.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Home viewHome = new Home();
            viewHome.TopLevel = false;
            viewHome.AutoScroll = true;
            viewHome.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            courseNameBox.Clear();
            courseIDBox.Clear();
            semsBox.Items.Clear();
            crHourBox.Items.Clear();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to add this course?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            GetCourses();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examSchedulerDataSet.Courses' table. You can move, or remove it, as needed.
            //this.coursesTableAdapter.Fill(this.examSchedulerDataSet.Courses);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDateTime s1 = new SetDateTime();
            this.Hide();
            s1.Show();
        }

        

       
    }
}
