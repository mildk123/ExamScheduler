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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       
        private void StripLogOutBtn_Click(object sender, EventArgs e)
        {
            Welcome goToLogout = new Welcome();
            this.Hide();
            goToLogout.Show();
        }

        private void StripHomeBtn_Click(object sender, EventArgs e)
        {
            Home_Data goToHome = new Home_Data();
            goToHome.TopLevel = false;
            goToHome.AutoScroll = true;
            this.mainPanel.Controls.Add(goToHome);
            goToHome.Show();
        }

        private void StripAddBtn_Click(object sender, EventArgs e)
        {
            Courses goToCourses = new Courses();
            goToCourses.TopLevel = false;
            goToCourses.AutoScroll = true;
            this.mainPanel.Controls.Add(goToCourses);
            goToCourses.Show();
        }

        private void StripDateBtn_Click(object sender, EventArgs e)
        {
            DateTime goToDateTime = new DateTime();
            goToDateTime.TopLevel = false;
            goToDateTime.AutoScroll = true;
            this.mainPanel.Controls.Add(goToDateTime);
            goToDateTime.Show();
        }

        private void StripTableBtn_Click(object sender, EventArgs e)
        {
            Table goToTable = new Table();
            goToTable.TopLevel = false;
            goToTable.AutoScroll = true;
            this.mainPanel.Controls.Add(goToTable);
            goToTable.Show();
        }

        private void StripSettingsBtn_Click(object sender, EventArgs e)
        {
            Settings goToSettings = new Settings();
            goToSettings.TopLevel = false;
            goToSettings.AutoScroll = true;
            this.mainPanel.Controls.Add(goToSettings);
            goToSettings.Show();
        }
    }
}
