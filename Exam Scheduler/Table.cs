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
            string query = "SELECT * from schedule ";
            using (SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-4USG0EK\\SQLEXPRESS;Initial Catalog=examScheduler;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    dataGridView1.DataSource = dt;
                    myConnection.Close();
                    
                }
            }
            
        }

      
    }
}
