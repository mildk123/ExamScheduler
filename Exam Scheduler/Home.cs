﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Welcome goToHome = new Welcome();
            this.Hide();
            goToHome.Show();
        }
    }
}
