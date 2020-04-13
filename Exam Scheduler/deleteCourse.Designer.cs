namespace Exam_Scheduler
{
    partial class deleteCourse
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.courseIDBox = new System.Windows.Forms.TextBox();
            this.DoneBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AllCourses = new System.Windows.Forms.DataGridView();
            this.pageTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77309F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 558F));
            this.tableLayoutPanel1.Controls.Add(this.departmentLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseIDBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DoneBTN, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 119);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1374, 337);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.ForeColor = System.Drawing.Color.Black;
            this.departmentLabel.Location = new System.Drawing.Point(411, 56);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(93, 24);
            this.departmentLabel.TabIndex = 4;
            this.departmentLabel.Text = "Course ID";
            // 
            // courseIDBox
            // 
            this.courseIDBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.courseIDBox.HideSelection = false;
            this.courseIDBox.Location = new System.Drawing.Point(512, 53);
            this.courseIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.courseIDBox.Name = "courseIDBox";
            this.courseIDBox.Size = new System.Drawing.Size(219, 30);
            this.courseIDBox.TabIndex = 5;
            // 
            // DoneBTN
            // 
            this.DoneBTN.AllowDrop = true;
            this.DoneBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoneBTN.BackColor = System.Drawing.Color.Firebrick;
            this.DoneBTN.FlatAppearance.BorderSize = 0;
            this.DoneBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DoneBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneBTN.ForeColor = System.Drawing.Color.White;
            this.DoneBTN.Location = new System.Drawing.Point(600, 261);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(124, 42);
            this.DoneBTN.TabIndex = 20;
            this.DoneBTN.Text = "Delete";
            this.DoneBTN.UseVisualStyleBackColor = false;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(819, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AllCourses
            // 
            this.AllCourses.AllowUserToAddRows = false;
            this.AllCourses.AllowUserToDeleteRows = false;
            this.AllCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllCourses.GridColor = System.Drawing.SystemColors.ControlLight;
            this.AllCourses.Location = new System.Drawing.Point(67, 526);
            this.AllCourses.Margin = new System.Windows.Forms.Padding(4);
            this.AllCourses.Name = "AllCourses";
            this.AllCourses.ReadOnly = true;
            this.AllCourses.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AllCourses.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.AllCourses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCourses.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.AllCourses.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            this.AllCourses.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AllCourses.Size = new System.Drawing.Size(1263, 334);
            this.AllCourses.TabIndex = 16;
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(618, 4);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(311, 59);
            this.pageTitle.TabIndex = 15;
            this.pageTitle.Text = "Delete Courses";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 873);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AllCourses);
            this.Controls.Add(this.pageTitle);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "deleteCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Course";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView AllCourses;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox courseIDBox;
        private System.Windows.Forms.Button DoneBTN;
        private System.Windows.Forms.Button button2;


    }
}