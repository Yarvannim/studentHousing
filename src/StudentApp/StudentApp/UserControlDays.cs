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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        Student? loggedinStudent;
        public UserControlDays(Student? loggedinStudent)
        {
            InitializeComponent();
            this.loggedinStudent = loggedinStudent;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            string thisday = lbdays.Text.PadLeft(2, '0') + "-" + Calendar.static_month.ToString("D2") + "-" + Calendar.static_year;
            List<string> tasks = Database.GetAllDatesAssigned();
            if (tasks.Contains(thisday))
            {
                label1.Text = "...";
            }
            else
            {
                label1.Text = "";
            }
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            Taskstoday eventFrom = new Taskstoday(this.loggedinStudent);
            eventFrom.ShowDialog();
        }
    }
}
