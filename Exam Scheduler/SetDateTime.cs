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
        string selectedSemester;
        string selectedCourseName;
        string selectedCourseID;
        string selectedDate;
        string selectedSlot;

        public SetDateTime()
        {
            InitializeComponent();
        }

       
        private void SetDateTime_Load(object sender, EventArgs e)
        {
            GetDepartments();
            displaySchedule();
        }

        private void displaySchedule()
        {
            con.Open();
            using (SqlDataAdapter getScheduleReq = new SqlDataAdapter("Select * from Schedule join Courses on Courses.Course_ID=Schedule.CourseID", con))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                getScheduleReq.Fill(dt);

                CoursesScheduleGrid.DataSource = dt;

            }
            con.Close();
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
            selectedSemester = semsDropdown.Text;

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
            selectedCourseID = CoursesDropdown.SelectedValue.ToString();
            selectedCourseName = CoursesDropdown.Text;

            if (selectedCourseID == "System.Data.DataRowView")
            {
                courseIDBox.Text = "";
                
            }
            else
            {
                courseIDBox.Text = selectedCourseID;
            }
        }

        private void calenderSchedule_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = calenderSchedule.Value.ToLongDateString().ToString();
        }

        private void SlotDropDown_TextChanged(object sender, EventArgs e)
        {
            selectedSlot =  SlotDropDown.Text;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            //departDropdown.Items.Clear();
            //semsDropdown.Items.Clear();
            //CoursesDropdown.Items.Clear();
            //SlotDropDown.Items.Clear();

            //selectedDepartment = "";
            //selectedSemester = "";
            //selectedCourseName = "";
            //selectedCourseID = "";
            //selectedDate = "";
            //selectedSlot = "";

            MessageBox.Show("not functional yet","Information");
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            checkSameDateInDB();
            //checkSameCourseInDB();
            //pushExamToDB();
        }

        private void checkSameDateInDB()
        {
            try
            {
                con.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                string sql, output = "";
                sql = "SELECT * from Schedule Where date='" + selectedDate + "' AND slot='" + selectedSlot + "' ";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
                }

                //MessageBox.Show(output);
                command.Dispose();
                con.Close();

                if (output == "")
                {
                    pushExamToDB();
                    //MessageBox.Show("Done.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else
                {
                    MessageBox.Show("The selected date and slot is already scheduled.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            //if (true)
            //{
            //pushExamToDB();
            //}
            //else
            //{
            //MessageBox.Show("This exam is already scheduled","Error");
            //}
        }

        private void checkSameCourseInDB() { }

        private void pushExamToDB()
        {
            //string selectedDepartment;
            //string selectedSemester;
            //string selectedCourseName;
            //string selectedCourseID;
            //string selectedDate;
            //string selectedSlot;

           try
            {

                con.Open();
                SqlCommand pushCommand;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "";

                sql = "INSERT INTO Schedule(examID,CourseID,date,slot) VALUES ('PAF_" + selectedCourseID + "', '" + Int32.Parse(selectedCourseID) + "','" + selectedDate + "','" + selectedSlot + "')";
                pushCommand = new SqlCommand(sql,con);
                adapter.InsertCommand = new SqlCommand(sql, con);
                adapter.InsertCommand.ExecuteNonQuery();
                pushCommand.Dispose();
                con.Close();
                MessageBox.Show("Record inserted sucessfully");

                displaySchedule();
            }
            catch (Exception e)
            {
                MessageBox.Show("This slot is already scheduled   \n" + e.Message, "Error");
            }
        }
    }
}