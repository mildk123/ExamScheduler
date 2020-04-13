using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Exam_Scheduler
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void login()
        {
            string username = usernameBox.Text.ToString();
            string password = passBox.Text.ToString();

            if ( (Regex.IsMatch(username, @"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$")) &&
                 (Regex.IsMatch(password, "(?=^.{6,}$)(?=.*\\d)(?=.*[a-zA-Z])" )) 
                )
            {

                MessageBox.Show("Welcome " +username, "Information");
                Home goToHome = new Home();
                this.Hide();
                goToHome.Show();
            }
            else
            {
                MessageBox.Show("Username/Password must be 8-20 charecters long. \nNo underscore(_) or dot(.) at the beginning or end", "Invalid Username");
            }

           
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
             login();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
