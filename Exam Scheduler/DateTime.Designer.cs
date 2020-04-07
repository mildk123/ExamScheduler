namespace Exam_Scheduler
{
    partial class DateTime
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
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.shiftsPerDayLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.numOfShiftBox = new System.Windows.Forms.NumericUpDown();
            this.DateTimeTable = new System.Windows.Forms.DataGridView();
            this.Date_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfShiftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(611, 9);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(249, 52);
            this.pageTitle.TabIndex = 11;
            this.pageTitle.Text = "Date / Time";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StartDateLabel.Location = new System.Drawing.Point(169, 7);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(102, 28);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Start Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.04555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.95445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 562F));
            this.tableLayoutPanel1.Controls.Add(this.shiftsPerDayLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.endDatePicker, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartDateLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.endDateLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.doneBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numOfShiftBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.StartDatePicker, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.08642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.91358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1388, 133);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // shiftsPerDayLabel
            // 
            this.shiftsPerDayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shiftsPerDayLabel.AutoSize = true;
            this.shiftsPerDayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsPerDayLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.shiftsPerDayLabel.Location = new System.Drawing.Point(134, 48);
            this.shiftsPerDayLabel.Name = "shiftsPerDayLabel";
            this.shiftsPerDayLabel.Size = new System.Drawing.Size(137, 28);
            this.shiftsPerDayLabel.TabIndex = 10;
            this.shiftsPerDayLabel.Text = "Shifts per day";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.endDatePicker.Location = new System.Drawing.Point(828, 7);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(360, 29);
            this.endDatePicker.TabIndex = 9;
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.endDateLabel.Location = new System.Drawing.Point(728, 7);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(94, 28);
            this.endDateLabel.TabIndex = 7;
            this.endDateLabel.Text = "End Date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartDatePicker.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.StartDatePicker.Location = new System.Drawing.Point(277, 7);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(367, 29);
            this.StartDatePicker.TabIndex = 8;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearBtn.BackColor = System.Drawing.Color.LightCoral;
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearBtn.Location = new System.Drawing.Point(609, 91);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(90, 32);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Reset";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.doneBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.doneBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.doneBtn.Location = new System.Drawing.Point(705, 91);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(90, 32);
            this.doneBtn.TabIndex = 5;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // numOfShiftBox
            // 
            this.numOfShiftBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numOfShiftBox.Location = new System.Drawing.Point(277, 47);
            this.numOfShiftBox.Name = "numOfShiftBox";
            this.numOfShiftBox.Size = new System.Drawing.Size(80, 29);
            this.numOfShiftBox.TabIndex = 11;
            // 
            // DateTimeTable
            // 
            this.DateTimeTable.AllowUserToOrderColumns = true;
            this.DateTimeTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateTimeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_1,
            this.Date_2,
            this.Date_3});
            this.DateTimeTable.Location = new System.Drawing.Point(113, 378);
            this.DateTimeTable.Name = "DateTimeTable";
            this.DateTimeTable.Size = new System.Drawing.Size(1169, 327);
            this.DateTimeTable.TabIndex = 14;
            // 
            // Date_1
            // 
            this.Date_1.HeaderText = "Date3";
            this.Date_1.Name = "Date_1";
            // 
            // Date_2
            // 
            this.Date_2.HeaderText = "Date2";
            this.Date_2.Name = "Date_2";
            // 
            // Date_3
            // 
            this.Date_3.HeaderText = "Date1";
            this.Date_3.Name = "Date_3";
            // 
            // DateTime
            // 
            this.AcceptButton = this.doneBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(1412, 738);
            this.Controls.Add(this.DateTimeTable);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DateTime";
            this.Text = "DateTime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DateTime_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfShiftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label shiftsPerDayLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.NumericUpDown numOfShiftBox;
        private System.Windows.Forms.DataGridView DateTimeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_3;

    }
}