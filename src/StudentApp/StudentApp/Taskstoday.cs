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
    public partial class Taskstoday : Form
    {
        Student? student;
        public Taskstoday(Student? student)
        {
            InitializeComponent();
            this.student = student;
            if (this.student == null)
            {
                lbTasks.Enabled = false;
            }
        }

        private void EventFrom_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void lbTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lbTasks.SelectedItem != null)
            {
                Tasks selectedTask = lbTasks.SelectedItem as Tasks;
                if (selectedTask.StudentId == this.student.StudentID) 
                {
                    Database.UpdateTaskStatus(selectedTask.TaskId, student.StudentID);
                    loadData();
                }
                else
                {
                    MessageBox.Show("This is not your task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void loadData()
        {
            string thisday = Calendar.static_year + "-" + Calendar.static_month + "-" + UserControlDays.static_day;
            List<Tasks> tasks = Database.GetStudentsTaskAssigned(thisday);
            lbTasks.DataSource = tasks;
            lbTasks.DisplayMember = "TaskDetail";
        }
    }
}
