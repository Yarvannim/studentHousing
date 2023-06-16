using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class NewAgreementWindow : Form
    {
        Student loggedInStudent;
        public NewAgreementWindow(Student student)
        {
            InitializeComponent();
            this.loggedInStudent = student;
        }

        private void btnAgreement_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAgreement.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to make this agreement", "Are you certain?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime date = dateTimePicker1.Value;
                    Agreements agreement = new Agreements(tbAgreement.Text, date, loggedInStudent.StudentID);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("It is impossible to create an agreement without text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
