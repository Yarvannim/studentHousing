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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Tuple<bool, string, int?> login = Database.Login(tbUserName.Text, tbPassword.Text);
            if (login.Item1)
            {
                if (login.Item2 == "Student" && login.Item3 != null)
                {
                    Student student = Database.GetStudentById(Convert.ToInt32(login.Item3));
                    if (student != null)
                    {
                        this.Hide();
                        Form1 newform = new Form1(student);
                        newform.ShowDialog();
                        ShowAgain();
                    }
                }
                else if (login.Item2 == "Admin")
                {
                    this.Hide();
                    AdminWindow admin = new AdminWindow();
                    admin.ShowDialog();
                    ShowAgain();
                }
                else if (login.Item2 == "Dashboard")
                {
                    this.Hide();
                    Form1 form = new Form1(null);
                    form.ShowDialog();
                    ShowAgain();
                }
            }
            else
            {
                MessageBox.Show("No such credentials found in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowAgain()
        {
            this.Show();
            tbUserName.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
    }
}
