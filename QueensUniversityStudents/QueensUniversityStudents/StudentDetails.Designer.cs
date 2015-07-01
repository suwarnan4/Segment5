namespace QueensUniversityStudents
{
    partial class StudentDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudentDetails = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradePointAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.butAddNew = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentDetails
            // 
            this.dgvStudentDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvStudentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.stuName,
            this.DOB,
            this.GradePointAvg,
            this.Active});
            this.dgvStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentDetails.Name = "dgvStudentDetails";
            this.dgvStudentDetails.RowHeadersVisible = false;
            this.dgvStudentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentDetails.Size = new System.Drawing.Size(740, 421);
            this.dgvStudentDetails.TabIndex = 0;
            // 
            // StudentId
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentId.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentId.HeaderText = "Student ID";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // stuName
            // 
            this.stuName.HeaderText = "Name";
            this.stuName.Name = "stuName";
            this.stuName.Width = 300;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            // 
            // GradePointAvg
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GradePointAvg.DefaultCellStyle = dataGridViewCellStyle4;
            this.GradePointAvg.HeaderText = "GradePointAvg";
            this.GradePointAvg.Name = "GradePointAvg";
            this.GradePointAvg.Width = 110;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            // 
            // butAddNew
            // 
            this.butAddNew.Location = new System.Drawing.Point(502, 439);
            this.butAddNew.Name = "butAddNew";
            this.butAddNew.Size = new System.Drawing.Size(75, 23);
            this.butAddNew.TabIndex = 1;
            this.butAddNew.Text = "Add New";
            this.butAddNew.UseVisualStyleBackColor = true;
            this.butAddNew.Click += new System.EventHandler(this.butAddNew_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(620, 439);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 479);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butAddNew);
            this.Controls.Add(this.dgvStudentDetails);
            this.Name = "StudentDetails";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAddNew;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradePointAvg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        public System.Windows.Forms.DataGridView dgvStudentDetails;
    }
}