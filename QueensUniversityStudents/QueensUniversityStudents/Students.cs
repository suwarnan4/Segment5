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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails stuDetails = new StudentDetails();
            stuDetails.MdiParent = this;
            stuDetails.Show();
        }
    }
}
