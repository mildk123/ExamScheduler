using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Exam_Scheduler
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4USG0EK\\SQLEXPRESS;Initial Catalog=examScheduler;Integrated Security=True");

            con.Open();
            using (SqlDataAdapter getScheduleReq = new SqlDataAdapter("Select CourseID,Course_Name,Course_CrHours,Course_Department,Semester,date,slot,examID from Schedule join Courses on Courses.Course_ID=Schedule.CourseID", con))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                getScheduleReq.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
                dataGridView1.RowTemplate.Height = 30;


                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 350;
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].Width = 170;
                dataGridView1.Columns[4].Width = 170;
                dataGridView1.Columns[5].Width = 180;
                dataGridView1.Columns[6].Width = 270;
                dataGridView1.Columns[7].Width = 100;

            }
            con.Close();


        }

      
    }
}
