namespace QueensUniversityStudents
{
    partial class StudentRegistration
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
            this.butCancel = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texStudentId = new System.Windows.Forms.TextBox();
            this.texGradePointAvg = new System.Windows.Forms.TextBox();
            this.texName = new System.Windows.Forms.TextBox();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(82, 211);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(209, 211);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 5;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grade Point Avg";
            // 
            // texStudentId
            // 
            this.texStudentId.Location = new System.Drawing.Point(129, 22);
            this.texStudentId.Name = "texStudentId";
            this.texStudentId.ReadOnly = true;
            this.texStudentId.Size = new System.Drawing.Size(119, 20);
            this.texStudentId.TabIndex = 0;
            this.texStudentId.TabStop = false;
            // 
            // texGradePointAvg
            // 
            this.texGradePointAvg.Location = new System.Drawing.Point(129, 130);
            this.texGradePointAvg.Name = "texGradePointAvg";
            this.texGradePointAvg.Size = new System.Drawing.Size(80, 20);
            this.texGradePointAvg.TabIndex = 3;
            this.texGradePointAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.texGradePointAvg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texGradePointAvg_KeyPress);
            // 
            // texName
            // 
            this.texName.Location = new System.Drawing.Point(129, 58);
            this.texName.Name = "texName";
            this.texName.Size = new System.Drawing.Size(208, 20);
            this.texName.TabIndex = 1;
            this.texName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texName_KeyPress);
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Location = new System.Drawing.Point(129, 170);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(56, 17);
            this.chbActive.TabIndex = 4;
            this.chbActive.Text = "Active";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd MMM yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(129, 91);
            this.dtpDOB.MaxDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(119, 20);
            this.dtpDOB.TabIndex = 2;
            this.dtpDOB.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 254);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.texGradePointAvg);
            this.Controls.Add(this.texStudentId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.butCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentRegistration";
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox texStudentId;
        private System.Windows.Forms.TextBox texGradePointAvg;
        private System.Windows.Forms.TextBox texName;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}