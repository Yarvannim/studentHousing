using System.Globalization;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        int month, year;
        public Student loggedInStudent { get; }
        bool dashboard = false;
        private DateTime lastClickTime = DateTime.Now;
        private Label clock;
        private Calendar calendar;
        private bool CalendarState = true;
        private bool AgreementState = false;
        private bool ComplaintState = false;
        private bool RuleState = false;
        public Form1(Student? student)
        {
            InitializeComponent();
            FillStudentsList();
            if (student != null)
            {
                loggedInStudent = student as Student;
                calendar = new Calendar(student);
            }
            else
            {
                calendar = new Calendar(null);
                EnableDashboardMode();
                // Timer that starts the always on display
                timer1.Start();
                dashboard = true;
            }
        }
        #region Calendar
        // When the forms loads it loads in the calendar
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            calendar.displayDays(daycontainer, lbMonth, month, year);
        }
        // Loads the previous month in the calendar
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            if (month != 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }

            calendar.displayDays(daycontainer, lbMonth, month, year);
        }
        // Loads the next month in the calendar
        private void btnNext_Click(object sender, EventArgs e)
        {

            daycontainer.Controls.Clear();

            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }


            calendar.displayDays(daycontainer, lbMonth, month, year);
        }
        // Side menu button for calendar that shows the calendar
        #region Sidemenu buttons
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Calendar";
            gpAgreements.Visible = false;
            gpRules.Visible = false;
            gpCalendar.Visible = true;
            StateChanger("Calendar");
            tbComplaint.Clear();
            tbComplaintTitle.Clear();
        }
        // Side menu buttons for agreements
        private void btnAgreements_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Agreements";
            gpComplaints.Visible = false;
            gpRules.Visible = false;
            gpAgreements.Visible = true;
            StateChanger("Agreements");
            FillAgreementsList();
            tbComplaint.Clear();
            tbComplaintTitle.Clear();
        }
        // Side menu button for complaints
        private void btnComplaint_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Complaints";
            gpAgreements.Visible = true;
            gpComplaints.Visible = true;
            gpRules.Visible = false;
            StateChanger("Complaints");
        }
        // Side menu button for rules
        private void btnRule_Click(object sender, EventArgs e)
        {
            FillRulesList();
            lblTitle.Text = "Rules";
            gpAgreements.Visible = true;
            gpComplaints.Visible = true;
            gpRules.Visible = true;
            StateChanger("Rule");
            tbComplaint.Clear();
            tbComplaintTitle.Clear();
        }
        // Function that saves which screen was actually open so when always on display gets cancelled we know what to show
        private void StateChanger(string state)
        {
            switch (state)
            {
                case "Calendar":
                    CalendarState = true;
                    AgreementState = false;
                    ComplaintState = false;
                    RuleState = false;
                    break;
                case "Agreements":
                    CalendarState = false;
                    AgreementState = true;
                    ComplaintState = false;
                    RuleState = false;
                    break;
                case "Complaints":
                    CalendarState = false;
                    AgreementState = false;
                    ComplaintState = true;
                    RuleState = false;
                    break;
                case "Rule":
                    CalendarState = false;
                    AgreementState = false;
                    ComplaintState = false;
                    RuleState = true;
                    break;
            }
        }
        #endregion
        // function for submitting a complaint, explains itself
        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            Complaints complaint;
            if (!string.IsNullOrWhiteSpace(tbComplaint.Text) && !string.IsNullOrWhiteSpace(tbComplaintTitle.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to file this complaint? This will be taken very seriously by the staff", "Are you certain", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cbAnonymous.Checked)
                    {
                        complaint = new Complaints(tbComplaint.Text, tbComplaintTitle.Text);
                    }
                    else
                    {
                        complaint = new Complaints(tbComplaint.Text, loggedInStudent, tbComplaintTitle.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("It is impossible to submit an empty complaint", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // function to fill the students list
        private void FillStudentsList()
        {
            List<Student> students = Database.GetAllStudents();
            lbStudents.DataSource = students;
            lbStudents.DisplayMember = "first_name";
        }
        #endregion
        // function to fill the agreements list
        private void FillAgreementsList()
        {
            lbAgreements.Items.Clear();
            List<Agreements> agreements = Agreements.GetAllAgreements();
            foreach (Agreements a in agreements)
            {
                lbAgreements.Items.Add(a);
            }
        }

        // function to fill the rules list
        private void FillRulesList()
        {
            lbRules.Items.Clear();
            List<Rules> rules = Rules.GetAllRules();
            foreach (Rules a in rules)
            {
                lbRules.Items.Add(a);
            }
        }

        // function that opens a new agreement window
        private void btnNewAgreement_Click(object sender, EventArgs e)
        {
            NewAgreementWindow newAgreementWindow = new NewAgreementWindow(loggedInStudent);
            newAgreementWindow.ShowDialog();
        }

        // if the mode is not on dashmode and you double click on an agreement you can vote
        private void lbAgreements_DoubleClick(object sender, EventArgs e)
        {
            if (lbAgreements.SelectedItem != null)
            {
                Agreements selectedAgreement = (Agreements)lbAgreements.SelectedItem;
                if (!dashboard)
                {
                    if (selectedAgreement.CreatorID == loggedInStudent.StudentID)
                    {
                        btnVoteNo.Enabled = false;
                        btnVoteYes.Enabled = false;
                    }
                    else
                    {
                        btnVoteNo.Enabled = true;
                        btnVoteYes.Enabled = true;
                    }
                }

                tbAgreementDetail.Text = selectedAgreement.Agreement;
            }
        }
        // function for the vote yes button to vote for an agreement
        private void btnVoteYes_Click(object sender, EventArgs e)
        {
            if (lbAgreements.SelectedItem != null)
            {
                Agreements selectedAgreement = (Agreements)lbAgreements.SelectedItem;
                selectedAgreement.voteYes(loggedInStudent.StudentID);
                FillAgreementsList();
            }
        }
        // function for the vote no button to vote for an agreement
        private void btnVoteNo_Click(object sender, EventArgs e)
        {
            if (lbAgreements.SelectedItem != null)
            {
                Agreements selectedAgreement = (Agreements)lbAgreements.SelectedItem;
                selectedAgreement.voteNo(loggedInStudent.StudentID);
                FillAgreementsList();
            }
        }
        // function that disables all buttons that should not be usable in the dashboard mode
        private void EnableDashboardMode()
        {
            btnComplaint.Enabled = false;
            btnNewAgreement.Enabled = false;
            btnSubmitComplaint.Enabled = false;
            btnVoteNo.Enabled = false;
            btnVoteYes.Enabled = false;
        }

        // function that resets the always on timer and turns off the always on screen still kinda buggy but works (sort of)
        private void Form1_Click(object sender, EventArgs e)
        {
            resetAlwaysOnTimer();
            alwaysOnDisplay(false);
        }

        // function that looks if the timespan since last click has been 2 minutes and if true turns on the always on display
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - lastClickTime;
            if (timeSpan.TotalMinutes >= 2)
            {
                alwaysOnDisplay(true);
            }
        }
        // the always on display
        private void alwaysOnDisplay(bool toggle)
        {
            if (toggle)
            {
                // if the clock doesnt exist yet it creates a new one
                if (clock == null)
                {
                    clock = new Label();
                    clock.Font = new Font("Century Gothic", 50);
                    clock.Text = DateTime.Now.ToString("HH:mm:ss");
                    clock.Width = 400;
                    clock.Height = 200;
                    clock.Location = new Point((ClientSize.Width - clock.Width) / 2 + 50, (ClientSize.Height - clock.Height) / 2 + 50);
                    clock.Name = "Clock";
                    Controls.Add(clock);
                    Clock.Start();
                }
                // if toggle is true then it turns the background black and makes every control invisible except for the clock
                this.BackColor = Color.Black;
                foreach (Control control in Controls)
                {
                    control.Visible = (control == clock) ? true : false;
                }
            }
            else
            {
                // turn off the always on display and toggle screens based on the state
                this.BackColor = Color.HotPink;
                foreach (Control control in Controls)
                {
                    control.Visible = (control == clock) ? false : true;
                }
                switch (true)
                {
                    case bool when CalendarState:
                        btnCalendar.PerformClick();
                        break;
                    case bool when AgreementState:
                        btnAgreements.PerformClick();
                        break;
                    case bool when ComplaintState:
                        btnComplaint.PerformClick();
                        break;
                    case bool when RuleState:
                        btnRule.PerformClick();
                        break;
                }
            }
        }
        // update the clock text
        private void Clock_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        // set the last click time to right now
        private void resetAlwaysOnTimer()
        {
            lastClickTime = DateTime.Now;
        }
    }
}