using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentApp
{
    public partial class AdminWindow : Form
    {
        Random rnd = new Random();
        DateTime today = DateTime.Now;

        public AdminWindow()
        {
            InitializeComponent();
            FillStudentList();
            FillAgreementsList();
            FillComplaintsList();
            FillRulesList();
            FillTasksList();
            FillUsersList();
            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                MessageBox.Show("You can assign the weekly tasks today");
                btnAssignTaskRandom.Enabled = true;
            }
            else
            {
                btnAssignTaskRandom.Enabled = false;
            }
        }
        #region students
        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFirstName.Text) && !string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                Student student = new Student(tbFirstName.Text, tbLastName.Text, Convert.ToInt32(nmrStudentHouse.Value));
                FillStudentList();
            }
            else
            {
                MessageBox.Show("Please fill in all field before making a new student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillStudentList()
        {
            lbStudents.Items.Clear();
            cbStudent.Items.Clear();
            List<Student> studentList = Student.GetAllStudents();
            foreach (Student student in studentList)
            {
                lbStudents.Items.Add(student);
                cbStudent.Items.Add(student);
            }
        }
        private void FillUsersList()
        {
            lbUsers.Items.Clear();
            foreach (User user in Database.GetAllUsers())
            {
                lbUsers.Items.Add(user);
            }
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this student", "Be careful!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Student selectedStudent = (Student)lbStudents.SelectedItem;
                    Student.deleteStudent(selectedStudent.StudentID);
                    FillStudentList();
                }
            }
            else
            {
                MessageBox.Show("Please select a student in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region agreements
        private void FillAgreementsList()
        {
            lbAgreements.Items.Clear();
            List<Agreements> agreements = Agreements.GetAllAgreements();
            foreach (Agreements a in agreements)
            {
                lbAgreements.Items.Add(a);
            }
        }
        private void lbAgreements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Agreements agreement = (Agreements)lbAgreements.SelectedItem;
            tbAgreement.Text = agreement.Agreement;
        }
        #endregion
        #region complaints
        private void FillComplaintsList()
        {
            lbComplaints.Items.Clear();
            List<Complaints> complaints = Complaints.GetAllComplaints();
            lbComplaints.DataSource = complaints;
            lbComplaints.DisplayMember = "complaintTitle";
        }

        private void lbComplaints_DoubleClick(object sender, EventArgs e)
        {
            Complaints complaints = (Complaints)lbComplaints.SelectedItem;
            tbComplaints.Text = complaints.Complaint;
        }

        #endregion
        #region Rules
        private void FillRulesList()
        {
            lbRules.Items.Clear();
            List<Rules> rules = Rules.GetAllRules();
            foreach (Rules r in rules)
            {
                lbRules.Items.Add(r);
            }
        }

        private void btnNewRule_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbRule.Text))
            {
                Rules newrRule = new Rules(tbRule.Text);
                FillRulesList();
            }
            else
            {
                MessageBox.Show("Cannot make a rule without text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            if (lbRules.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this rule", "Be careful!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Rules selectedRule = (Rules)lbRules.SelectedItem;
                    selectedRule.RemoveRule(selectedRule.ID);
                    FillRulesList();
                }
            }
            else
            {
                MessageBox.Show("Please select a rule in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Tasks
        private void FillTasksList()
        {
            List<Student> studentTaskList = Student.GetAllStudents();
            List<Tasks> tasks = Tasks.GetAllTasks();
            lbStudentsTask.DataSource = studentTaskList;
            lbStudentsTask.DisplayMember = "FirstName";
            lbStudentsTask.ValueMember = "StudentID";
            lbTasks.DataSource = tasks;
            lbTasks.DisplayMember = "TaskText";
            lbTasks.ValueMember = "TaskId";
        }
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            string SelectedDate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            Tasks task = new Tasks(tbTask.Text, SelectedDate);
            FillTasksList();
        }
        private void btnAssigningTask_Click(object sender, EventArgs e)
        {
            if (lbStudentsTask.SelectedItem != null && lbStudentsTask.SelectedItem != null)
            {
                int selectedStudentID = (int)lbStudentsTask.SelectedValue;
                int selectedTaskID = (int)lbTasks.SelectedValue;
                Database.AssignTask(selectedStudentID, selectedTaskID);
                MessageBox.Show("A student has been assigned", "Assigned a student", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            int selectedTaskID = (int)lbTasks.SelectedValue;
            Database.DeleteTasks(selectedTaskID);
        }
        #endregion

        #region User
        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserType.SelectedItem.ToString() == "Student")
            {
                cbStudent.Enabled = true;
            }
            else
            {
                cbStudent.Enabled = false;
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (cbUserType.SelectedItem != null)
            {
                if (cbUserType.SelectedItem.ToString() == "Student")
                {
                    if (cbUserType.SelectedItem != null && !string.IsNullOrWhiteSpace(tbUsername.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text) && cbStudent.SelectedItem != null)
                    {
                        Student selectedStudent = cbStudent.SelectedItem as Student;
                        Database.InsertUser(cbUserType.SelectedItem.ToString(), tbUsername.Text, tbPassword.Text, selectedStudent.StudentID);
                        FillUsersList();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (cbUserType.SelectedItem != null && !string.IsNullOrWhiteSpace(tbUsername.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
                    {

                        Database.InsertUser(cbUserType.SelectedItem.ToString(), tbUsername.Text, tbPassword.Text);
                        FillUsersList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a usertype", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this user. This is not revertable", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    User selectedUser = lbUsers.SelectedItem as User;
                    selectedUser.DeleteUser(selectedUser.ID);
                    FillUsersList();
                }
            }
            else
            {
                MessageBox.Show("Select the user you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnAssignTaskRandom_Click(object sender, EventArgs e)
        {
            #region Dates
            List<Student> students = Student.GetAllStudents();
            DateTime DayNextWeek = today.AddDays(7);
            string reformattedDate = DayNextWeek.ToString("yyyy-MM-dd");
            DateTime nextSaturday = today.AddDays((int)DayOfWeek.Saturday - (int)today.DayOfWeek);
            DateTime nextThursday = today.AddDays((int)DayOfWeek.Thursday - (int)today.DayOfWeek);
            DateTime nextFriday = today.AddDays((int)DayOfWeek.Friday - (int)today.DayOfWeek);
            string CleanCommonDay = nextSaturday.ToString("yyyy-MM-dd");
            string WashDishesDay = nextThursday.ToString("yyyy-MM-dd");
            string TaketrashDay = nextFriday.ToString("yyyy-MM-dd");
            string CleanToiletDay = nextSaturday.ToString("yyyy-MM-dd");
            #endregion
            HashSet<int> selectedStudentIDs = new HashSet<int>();
            Database.InsertTask("Take out the trash", TaketrashDay);
            Database.InsertTask("Clean the toilet", CleanToiletDay);
            Database.InsertTask("Clean the common areas", CleanCommonDay);
            Database.InsertTask("Wash the dishes", WashDishesDay);

            List<int> dailyTaskIds = Database.GetDailyTasks(reformattedDate);
            for (int i = 0; i < 4; i++)
            {
                int randomIndex;
                int randomStudentID;

                // Keep generating a new random index until a unique student ID is selected
                do
                {
                    randomIndex = rnd.Next(0, students.Count);
                    randomStudentID = students[randomIndex].StudentID;
                } while (selectedStudentIDs.Contains(randomStudentID));
                Database.AssignTask(randomStudentID, dailyTaskIds[i]);
            }
            btnAssignTaskRandom.Enabled = false;
        }

        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTasksList();
        }
    }
}
