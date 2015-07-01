using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueensUniversityStudents
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            RegistrationDialogResult = "Cancel";
            this.Hide();
        }

        private void texGradePointAvg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == true || e.KeyChar == (char)(Keys.Back) || e.KeyChar == (char)('.'))
            {
                //Do nothing
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && texGradePointAvg.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void texName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true || e.KeyChar == (char)(Keys.Back))
            {
                //Do nothing
            }
            else
            {
                e.Handled = true;
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (texName.Text == "" || texGradePointAvg.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                texName.Focus();

                return;
            }

            string[] row = new string[] { texStudentId.Text, texName.Text, string.Format("{0:dd MMM yyyy}", dtpDOB.Value), texGradePointAvg.Text, (chbActive.Checked) ? "True" : "False" };
            AddNewRow = row;

            RegistrationDialogResult = "OK";

            this.Hide();
        }

        private string[] newRow;
        public string[] AddNewRow
        {
            get { return newRow; }
            set { newRow = value; }
        }

        private string result;
        public string RegistrationDialogResult
        {
            get { return result; }
            set { result = value; }
        }
    }
}
