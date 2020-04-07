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
    public partial class DateTime : Form
    {
        public DateTime()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string StrNumberOfShifts = Convert.ToString(numOfShiftBox.Value);
            int numberOfShifts = Convert.ToInt32(numOfShiftBox.Value);
            MessageBox.Show(StrNumberOfShifts, "Tilte", MessageBoxButtons.OKCancel);

            DateTimeTable.RowCount = numberOfShifts;
            //DateTimeTable.ColumnCount = numberOfShifts;
            
        }

        private void DateTime_Load(object sender, EventArgs e)
        {

        }
    }
}
