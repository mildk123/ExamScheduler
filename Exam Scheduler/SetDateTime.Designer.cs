namespace Exam_Scheduler
{
    partial class SetDateTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageTitle = new System.Windows.Forms.Label();
            this.CoursesScheduleGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.departDropdown = new System.Windows.Forms.ComboBox();
            this.semsLabel = new System.Windows.Forms.Label();
            this.semsDropdown = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.CoursesDropdown = new System.Windows.Forms.ComboBox();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.courseIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SlotDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calenderSchedule = new System.Windows.Forms.DateTimePicker();
            this.clearBTN = new System.Windows.Forms.Button();
            this.DoneBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesScheduleGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(618, 9);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(196, 59);
            this.pageTitle.TabIndex = 1;
            this.pageTitle.Text = "Schedule";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoursesScheduleGrid
            // 
            this.CoursesScheduleGrid.AllowUserToAddRows = false;
            this.CoursesScheduleGrid.AllowUserToDeleteRows = false;
            this.CoursesScheduleGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CoursesScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesScheduleGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.CoursesScheduleGrid.Location = new System.Drawing.Point(-1, 422);
            this.CoursesScheduleGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CoursesScheduleGrid.Name = "CoursesScheduleGrid";
            this.CoursesScheduleGrid.ReadOnly = true;
            this.CoursesScheduleGrid.Size = new System.Drawing.Size(1401, 406);
            this.CoursesScheduleGrid.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77309F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.22691F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 534F));
            this.tableLayoutPanel1.Controls.Add(this.departDropdown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.semsLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.semsDropdown, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.departmentLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseNameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CoursesDropdown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.courseIdLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.courseIDBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.SlotDropDown, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.calenderSchedule, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.clearBTN, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.DoneBTN, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1401, 304);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // departDropdown
            // 
            this.departDropdown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.departDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.departDropdown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.departDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departDropdown.FormattingEnabled = true;
            this.departDropdown.Location = new System.Drawing.Point(236, 53);
            this.departDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.departDropdown.Name = "departDropdown";
            this.departDropdown.Size = new System.Drawing.Size(219, 24);
            this.departDropdown.TabIndex = 9;
            this.departDropdown.TextChanged += new System.EventHandler(this.departDropdown_TextChanged);
            // 
            // semsLabel
            // 
            this.semsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.semsLabel.AutoSize = true;
            this.semsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semsLabel.ForeColor = System.Drawing.Color.Black;
            this.semsLabel.Location = new System.Drawing.Point(772, 53);
            this.semsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semsLabel.Name = "semsLabel";
            this.semsLabel.Size = new System.Drawing.Size(90, 24);
            this.semsLabel.TabIndex = 6;
            this.semsLabel.Text = "Semester";
            // 
            // semsDropdown
            // 
            this.semsDropdown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.semsDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.semsDropdown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.semsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semsDropdown.FormattingEnabled = true;
            this.semsDropdown.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "3rd Semester",
            "4th Semester",
            "5th Semester",
            "6th Semester",
            "7th Semester",
            "8th Semester"});
            this.semsDropdown.Location = new System.Drawing.Point(870, 53);
            this.semsDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.semsDropdown.Name = "semsDropdown";
            this.semsDropdown.Size = new System.Drawing.Size(219, 24);
            this.semsDropdown.TabIndex = 3;
            this.semsDropdown.TextChanged += new System.EventHandler(this.semsDropdown_TextChanged);
            // 
            // departmentLabel
            // 
            this.departmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.ForeColor = System.Drawing.Color.Black;
            this.departmentLabel.Location = new System.Drawing.Point(121, 53);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(107, 24);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "Department";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.ForeColor = System.Drawing.Color.Black;
            this.courseNameLabel.Location = new System.Drawing.Point(104, 128);
            this.courseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(124, 24);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course name";
            // 
            // CoursesDropdown
            // 
            this.CoursesDropdown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CoursesDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.CoursesDropdown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CoursesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoursesDropdown.FormattingEnabled = true;
            this.CoursesDropdown.Location = new System.Drawing.Point(236, 127);
            this.CoursesDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.CoursesDropdown.Name = "CoursesDropdown";
            this.CoursesDropdown.Size = new System.Drawing.Size(219, 24);
            this.CoursesDropdown.TabIndex = 10;
            this.CoursesDropdown.TextChanged += new System.EventHandler(this.CoursesDropdown_TextChanged);
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdLabel.ForeColor = System.Drawing.Color.Black;
            this.courseIdLabel.Location = new System.Drawing.Point(769, 128);
            this.courseIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(93, 24);
            this.courseIdLabel.TabIndex = 4;
            this.courseIdLabel.Text = "Course ID";
            // 
            // courseIDBox
            // 
            this.courseIDBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.courseIDBox.Location = new System.Drawing.Point(870, 129);
            this.courseIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.courseIDBox.Name = "courseIDBox";
            this.courseIDBox.ReadOnly = true;
            this.courseIDBox.Size = new System.Drawing.Size(219, 22);
            this.courseIDBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(236, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Step 1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(870, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Step 2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(764, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Slot";
            // 
            // SlotDropDown
            // 
            this.SlotDropDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SlotDropDown.BackColor = System.Drawing.SystemColors.Window;
            this.SlotDropDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SlotDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SlotDropDown.FormattingEnabled = true;
            this.SlotDropDown.Items.AddRange(new object[] {
            "1st Slot (9:15 AM - 11:15 AM)",
            "2nd Slot (11:45 AM to 01:45 PM)"});
            this.SlotDropDown.Location = new System.Drawing.Point(870, 175);
            this.SlotDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.SlotDropDown.Name = "SlotDropDown";
            this.SlotDropDown.Size = new System.Drawing.Size(219, 24);
            this.SlotDropDown.TabIndex = 12;
            this.SlotDropDown.TextChanged += new System.EventHandler(this.SlotDropDown_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(123, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Date";
            // 
            // calenderSchedule
            // 
            this.calenderSchedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.calenderSchedule.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.calenderSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calenderSchedule.Location = new System.Drawing.Point(235, 174);
            this.calenderSchedule.Name = "calenderSchedule";
            this.calenderSchedule.Size = new System.Drawing.Size(267, 27);
            this.calenderSchedule.TabIndex = 17;
            this.calenderSchedule.ValueChanged += new System.EventHandler(this.calenderSchedule_ValueChanged);
            // 
            // clearBTN
            // 
            this.clearBTN.AllowDrop = true;
            this.clearBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearBTN.BackColor = System.Drawing.Color.LightCoral;
            this.clearBTN.FlatAppearance.BorderSize = 0;
            this.clearBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBTN.ForeColor = System.Drawing.Color.White;
            this.clearBTN.Location = new System.Drawing.Point(559, 236);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(124, 42);
            this.clearBTN.TabIndex = 18;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // DoneBTN
            // 
            this.DoneBTN.AllowDrop = true;
            this.DoneBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoneBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DoneBTN.FlatAppearance.BorderSize = 0;
            this.DoneBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DoneBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneBTN.ForeColor = System.Drawing.Color.White;
            this.DoneBTN.Location = new System.Drawing.Point(714, 236);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(124, 42);
            this.DoneBTN.TabIndex = 19;
            this.DoneBTN.Text = "Done";
            this.DoneBTN.UseVisualStyleBackColor = false;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // SetDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 874);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CoursesScheduleGrid);
            this.Controls.Add(this.pageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetDateTime";
            this.Text = "SetDateTime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SetDateTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesScheduleGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        public System.Windows.Forms.DataGridView CoursesScheduleGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox departDropdown;
        private System.Windows.Forms.Label semsLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SlotDropDown;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.ComboBox CoursesDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.TextBox courseIDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox semsDropdown;
        private System.Windows.Forms.DateTimePicker calenderSchedule;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button DoneBTN;
    }
}