using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace QueensUniversityStudents
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        ConnectionString connObject = new ConnectionString();
        DatabaseFunctions dbFunctions = new DatabaseFunctions();

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            dgvStudentDetails.Rows.Clear();

            SqlConnection conn = new SqlConnection(connObject.MyConnString());

            conn.Open();
            SqlDataReader dr = dbFunctions.LoadStudent(conn).ExecuteReader();

            while (dr.Read())
            {
                string[] row = new string[] { dr[0].ToString().Trim(), dr[1].ToString(), string.Format("{0:dd MMM yyyy}", dr[2]), dr[3].ToString(), dr[4].ToString() };
                dgvStudentDetails.Rows.Add(row);
            }
            conn.Close();
        }

        private void butAddNew_Click(object sender, EventArgs e)
        {
            StudentRegistration stuRegistration = new StudentRegistration();
            stuRegistration.texStudentId.Text = GeneratedNewStudentID();
            stuRegistration.ShowDialog();

            if (stuRegistration.RegistrationDialogResult == "OK")
            {
                dgvStudentDetails.Rows.Add(stuRegistration.AddNewRow);
            }
        }

        private string GeneratedNewStudentID()
        {
            string newStudentID;

            newStudentID = (Convert.ToInt32(dgvStudentDetails.Rows[dgvStudentDetails.Rows.Count - 1].Cells[0].Value) + 1).ToString();

            return newStudentID;
        }
        
        private void butSave_Click(object sender, EventArgs e)
        {
            Int32 rowsCount = dbFunctions.GetRowsCount();

            SqlConnection conn = new SqlConnection(connObject.MyConnString());

            SqlCommand cmd = dbFunctions.InsertNewRegistrationCommand(conn);

            cmd.Parameters.Add(new SqlParameter("@StudentId", SqlDbType.Char));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@GradePointAvg", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@Active", SqlDbType.Bit));

            conn.Open();
            for (int i = rowsCount; i < dgvStudentDetails.Rows.Count; i++)
            {
                cmd.Parameters["@StudentId"].Value = dgvStudentDetails.Rows[i].Cells[0].Value.ToString();
                cmd.Parameters["@Name"].Value = dgvStudentDetails.Rows[i].Cells[1].Value.ToString();
                cmd.Parameters["@DOB"].Value = dgvStudentDetails.Rows[i].Cells[2].Value.ToString();
                cmd.Parameters["@GradePointAvg"].Value = dgvStudentDetails.Rows[i].Cells[3].Value.ToString();
                cmd.Parameters["@Active"].Value = dgvStudentDetails.Rows[i].Cells[4].Value.ToString();

                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch
                {
                    MessageBox.Show("An exception occurre");
                }

                finally
                {
                    if (i == dgvStudentDetails.Rows.Count - 1)
                    {
                        MessageBox.Show("Student’s details have saved successfully");
                    }
                }
            }
            conn.Close();
        }
    }
}
