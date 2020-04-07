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
    public partial class SetDateTime : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4USG0EK\\SQLEXPRESS;Initial Catalog=examScheduler;Integrated Security=True");
        static int count = 0;
        string selectedDepartment;

        public SetDateTime()
        {
            InitializeComponent();
        }

        void GetCourses(string selectedSemester)
        {
            //SqlCommand sqlCmd = new SqlCommand("select * from Courses where Semester='" + selectedSemester + " '", connect);
        }

        private void SetDateTime_Load(object sender, EventArgs e)
        {
            GetDepartments();
        }

        private void GetDepartments()
        {
            con.Open();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Department_ID ,Department_Name FROM departments", con))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select department";
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                departDropdown.DataSource = dt;
                departDropdown.DisplayMember = "Department_Name";
                departDropdown.ValueMember = "Department_ID";

            }
            con.Close();

        }

        private void GetAvailableCourses(string selectedDepart, string selectedSemester)
        {
            con.Open();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Courses where Course_Department='"+selectedDepart+"' AND Semester='"+selectedSemester+"'", con))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Available courses";
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                CoursesDropdown.DataSource = dt;
                CoursesDropdown.DisplayMember = "Course_Name";
                CoursesDropdown.ValueMember = "Course_ID";           
            }
            con.Close();
        }

        private void semsDropdown_TextChanged(object sender, EventArgs e)
        {
            string selectedSemester = semsDropdown.Text;

            // Just for guide
            //message += Environment.NewLine;
            //string message = "Selected Semester: " + semsDropdown.Text;
            //MessageBox.Show(message);

            GetAvailableCourses(selectedDepartment, selectedSemester);
        }

        private void departDropdown_TextChanged(object sender, EventArgs e)
        {
            count++;
            if (count > 2)
            {
                selectedDepartment = departDropdown.Text;
                
                // Just for guide
                //message += Environment.NewLine;
                //string message = "Department_ID: " + departDropdown.SelectedValue + "Depart Name:" + departDropdown.Text;
                //MessageBox.Show(message);
            }
        }

        private void CoursesDropdown_TextChanged(object sender, EventArgs e)
        {
            string courseIDselected = CoursesDropdown.SelectedValue.ToString();
            if (courseIDselected == "System.Data.DataRowView")
            {
                courseIDBox.Text = "";
            }
            else
            {
                courseIDBox.Text = courseIDselected;
            }
        }
    }
}