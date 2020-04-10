using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Scheduler
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void EditPassBtn_Click(object sender, EventArgs e)
        {
            ChangePassword goToChangePass = new ChangePassword();
            this.Hide();
            goToChangePass.Show();
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            EditUsername goToEditUser = new EditUsername();
            this.Hide();
            goToEditUser.Show();
        }






    }
}
