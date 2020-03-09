namespace Exam_Scheduler
{
    partial class Courses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses));
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.departBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.courseIDBox = new System.Windows.Forms.TextBox();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.semsLabel = new System.Windows.Forms.Label();
            this.semsBox = new System.Windows.Forms.ComboBox();
            this.crHourBox = new System.Windows.Forms.ComboBox();
            this.crHourLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.pageTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackBtn = new System.Windows.Forms.ToolStripButton();
            this.CoursesGrid = new System.Windows.Forms.DataGridView();
            this.examSchedulerDataSet = new Exam_Scheduler.examSchedulerDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Exam_Scheduler.examSchedulerDataSetTableAdapters.CoursesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCrHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examSchedulerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.courseNameLabel.Location = new System.Drawing.Point(77, 11);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(114, 21);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course name";
            // 
            // courseNameBox
            // 
            this.courseNameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.courseNameBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.courseNameBox.Location = new System.Drawing.Point(197, 9);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(165, 25);
            this.courseNameBox.TabIndex = 1;
            // 
            // departBox
            // 
            this.departBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.departBox.Cursor = System.Windows.Forms.Cursors.No;
            this.departBox.Location = new System.Drawing.Point(197, 53);
            this.departBox.Name = "departBox";
            this.departBox.ReadOnly = true;
            this.departBox.Size = new System.Drawing.Size(165, 25);
            this.departBox.TabIndex = 10;
            this.departBox.Text = "Computer Science";
            // 
            // departmentLabel
            // 
            this.departmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.departmentLabel.Location = new System.Drawing.Point(88, 55);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(103, 21);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "Department";
            // 
            // courseIDBox
            // 
            this.courseIDBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.courseIDBox.Location = new System.Drawing.Point(197, 97);
            this.courseIDBox.Name = "courseIDBox";
            this.courseIDBox.Size = new System.Drawing.Size(165, 25);
            this.courseIDBox.TabIndex = 2;
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.courseIdLabel.Location = new System.Drawing.Point(108, 99);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(83, 21);
            this.courseIdLabel.TabIndex = 4;
            this.courseIdLabel.Text = "Course ID";
            // 
            // semsLabel
            // 
            this.semsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.semsLabel.AutoSize = true;
            this.semsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.semsLabel.Location = new System.Drawing.Point(111, 143);
            this.semsLabel.Name = "semsLabel";
            this.semsLabel.Size = new System.Drawing.Size(80, 21);
            this.semsLabel.TabIndex = 6;
            this.semsLabel.Text = "Semester";
            // 
            // semsBox
            // 
            this.semsBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.semsBox.BackColor = System.Drawing.SystemColors.Window;
            this.semsBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.semsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semsBox.FormattingEnabled = true;
            this.semsBox.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "3rd Semester",
            "4th Semester",
            "5th Semester",
            "6th Semester",
            "7th Semester",
            "8th Semester"});
            this.semsBox.Location = new System.Drawing.Point(197, 143);
            this.semsBox.Name = "semsBox";
            this.semsBox.Size = new System.Drawing.Size(165, 25);
            this.semsBox.TabIndex = 3;
            // 
            // crHourBox
            // 
            this.crHourBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.crHourBox.BackColor = System.Drawing.SystemColors.Window;
            this.crHourBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.crHourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crHourBox.FormattingEnabled = true;
            this.crHourBox.Items.AddRange(new object[] {
            "0.5 Hour",
            "1 Hour",
            "1.5 Hour",
            "2 Hours",
            "2.5 Hours",
            "3 Hours",
            "3.5 Hours"});
            this.crHourBox.Location = new System.Drawing.Point(574, 9);
            this.crHourBox.Name = "crHourBox";
            this.crHourBox.Size = new System.Drawing.Size(165, 25);
            this.crHourBox.TabIndex = 4;
            // 
            // crHourLabel
            // 
            this.crHourLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.crHourLabel.AutoSize = true;
            this.crHourLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crHourLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crHourLabel.Location = new System.Drawing.Point(464, 11);
            this.crHourLabel.Name = "crHourLabel";
            this.crHourLabel.Size = new System.Drawing.Size(104, 21);
            this.crHourLabel.TabIndex = 8;
            this.crHourLabel.Text = "Credit Hours";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.80307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.19693F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.tableLayoutPanel1.Controls.Add(this.crHourBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.semsBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.courseNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.semsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.courseNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.courseIDBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.departmentLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseIdLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.departBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.crHourLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.doneBtn, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.05195F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.94805F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 215);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearBtn.BackColor = System.Drawing.Color.LightCoral;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearBtn.Location = new System.Drawing.Point(478, 137);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(90, 34);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.doneBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.doneBtn.Location = new System.Drawing.Point(574, 137);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(90, 34);
            this.doneBtn.TabIndex = 5;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(364, 27);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(152, 42);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Courses";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackBtn});
            this.toolStrip1.Location = new System.Drawing.Point(23, 672);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(88, 39);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BackBtn
            // 
            this.BackBtn.Enabled = false;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BackBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(85, 36);
            this.BackBtn.Text = "Back";
            // 
            // CoursesGrid
            // 
            this.CoursesGrid.AllowUserToAddRows = false;
            this.CoursesGrid.AllowUserToDeleteRows = false;
            this.CoursesGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CoursesGrid.AutoGenerateColumns = false;
            this.CoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseDepartmentDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.courseCrHoursDataGridViewTextBoxColumn});
            this.CoursesGrid.DataSource = this.coursesBindingSource;
            this.CoursesGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.CoursesGrid.Location = new System.Drawing.Point(13, 380);
            this.CoursesGrid.Name = "CoursesGrid";
            this.CoursesGrid.ReadOnly = true;
            this.CoursesGrid.Size = new System.Drawing.Size(882, 331);
            this.CoursesGrid.TabIndex = 12;
            // 
            // examSchedulerDataSet
            // 
            this.examSchedulerDataSet.DataSetName = "examSchedulerDataSet";
            this.examSchedulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.examSchedulerDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // courseDepartmentDataGridViewTextBoxColumn
            // 
            this.courseDepartmentDataGridViewTextBoxColumn.DataPropertyName = "Course_Department";
            this.courseDepartmentDataGridViewTextBoxColumn.HeaderText = "Course_Department";
            this.courseDepartmentDataGridViewTextBoxColumn.Name = "courseDepartmentDataGridViewTextBoxColumn";
            this.courseDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseDepartmentDataGridViewTextBoxColumn.Width = 180;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterDataGridViewTextBoxColumn.Width = 120;
            // 
            // courseCrHoursDataGridViewTextBoxColumn
            // 
            this.courseCrHoursDataGridViewTextBoxColumn.DataPropertyName = "Course_CrHours";
            this.courseCrHoursDataGridViewTextBoxColumn.HeaderText = "Course_CrHours";
            this.courseCrHoursDataGridViewTextBoxColumn.Name = "courseCrHoursDataGridViewTextBoxColumn";
            this.courseCrHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseCrHoursDataGridViewTextBoxColumn.Width = 105;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(907, 738);
            this.Controls.Add(this.CoursesGrid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Courses";
            this.Text = "Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Courses_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examSchedulerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.TextBox departBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox courseIDBox;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.Label semsLabel;
        private System.Windows.Forms.ComboBox semsBox;
        private System.Windows.Forms.ComboBox crHourBox;
        private System.Windows.Forms.Label crHourLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button doneBtn;
        public System.Windows.Forms.DataGridView CoursesGrid;
        private examSchedulerDataSet examSchedulerDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private examSchedulerDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCrHoursDataGridViewTextBoxColumn;



    }
}