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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home goToHome = new Home();
            this.Hide();
            goToHome.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Home viewHome = new Home();
            viewHome.TopLevel = false;
            viewHome.AutoScroll = true;
            viewHome.Show();
        }

    }
}
