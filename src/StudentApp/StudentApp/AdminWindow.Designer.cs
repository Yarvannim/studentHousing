namespace StudentApp
{
    partial class AdminWindow
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
            tabcontrol = new TabControl();
            tabStudents = new TabPage();
            btnDeleteStudent = new Button();
            gpNewStudent = new GroupBox();
            btnNewStudent = new Button();
            nmrStudentHouse = new NumericUpDown();
            label5 = new Label();
            tbLastName = new TextBox();
            label2 = new Label();
            tbFirstName = new TextBox();
            label1 = new Label();
            lbStudents = new ListBox();
            tabComplaints = new TabPage();
            tbComplaints = new TextBox();
            lbComplaints = new ListBox();
            tabAgreements = new TabPage();
            tbAgreement = new TextBox();
            lbAgreements = new ListBox();
            tabRules = new TabPage();
            btnDeleteRule = new Button();
            lbRules = new ListBox();
            groupBox1 = new GroupBox();
            btnNewRule = new Button();
            tbRule = new TextBox();
            label6 = new Label();
            tabTasks = new TabPage();
            btnDeleteTask = new Button();
            btnAssignTaskRandom = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnAssigningTask = new Button();
            btnCreateTask = new Button();
            label3 = new Label();
            tbTask = new TextBox();
            lbStudentsTask = new ListBox();
            lbTasks = new ListBox();
            tabUsers = new TabPage();
            btnDeleteUser = new Button();
            lbUsers = new ListBox();
            groupBox2 = new GroupBox();
            btnCreateUser = new Button();
            label9 = new Label();
            cbStudent = new ComboBox();
            tbPassword = new TextBox();
            label8 = new Label();
            tbUsername = new TextBox();
            label7 = new Label();
            label4 = new Label();
            cbUserType = new ComboBox();
            tabcontrol.SuspendLayout();
            tabStudents.SuspendLayout();
            gpNewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrStudentHouse).BeginInit();
            tabComplaints.SuspendLayout();
            tabAgreements.SuspendLayout();
            tabRules.SuspendLayout();
            groupBox1.SuspendLayout();
            tabTasks.SuspendLayout();
            tabUsers.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tabStudents);
            tabcontrol.Controls.Add(tabComplaints);
            tabcontrol.Controls.Add(tabAgreements);
            tabcontrol.Controls.Add(tabRules);
            tabcontrol.Controls.Add(tabTasks);
            tabcontrol.Controls.Add(tabUsers);
            tabcontrol.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabcontrol.Location = new Point(4, 10);
            tabcontrol.Margin = new Padding(3, 2, 3, 2);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(647, 320);
            tabcontrol.TabIndex = 0;
            tabcontrol.SelectedIndexChanged += tabcontrol_SelectedIndexChanged;
            // 
            // tabStudents
            // 
            tabStudents.Controls.Add(btnDeleteStudent);
            tabStudents.Controls.Add(gpNewStudent);
            tabStudents.Controls.Add(lbStudents);
            tabStudents.Location = new Point(4, 26);
            tabStudents.Margin = new Padding(3, 2, 3, 2);
            tabStudents.Name = "tabStudents";
            tabStudents.Padding = new Padding(3, 2, 3, 2);
            tabStudents.Size = new Size(639, 290);
            tabStudents.TabIndex = 0;
            tabStudents.Text = "Students";
            tabStudents.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteStudent.Location = new Point(12, 257);
            btnDeleteStudent.Margin = new Padding(3, 2, 3, 2);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(347, 29);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "Delete selected student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // gpNewStudent
            // 
            gpNewStudent.Controls.Add(btnNewStudent);
            gpNewStudent.Controls.Add(nmrStudentHouse);
            gpNewStudent.Controls.Add(label5);
            gpNewStudent.Controls.Add(tbLastName);
            gpNewStudent.Controls.Add(label2);
            gpNewStudent.Controls.Add(tbFirstName);
            gpNewStudent.Controls.Add(label1);
            gpNewStudent.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gpNewStudent.Location = new Point(12, 8);
            gpNewStudent.Margin = new Padding(3, 2, 3, 2);
            gpNewStudent.Name = "gpNewStudent";
            gpNewStudent.Padding = new Padding(3, 2, 3, 2);
            gpNewStudent.Size = new Size(354, 244);
            gpNewStudent.TabIndex = 1;
            gpNewStudent.TabStop = false;
            gpNewStudent.Text = "Create new student";
            // 
            // btnNewStudent
            // 
            btnNewStudent.Location = new Point(82, 195);
            btnNewStudent.Margin = new Padding(3, 2, 3, 2);
            btnNewStudent.Name = "btnNewStudent";
            btnNewStudent.Size = new Size(187, 32);
            btnNewStudent.TabIndex = 10;
            btnNewStudent.Text = "Create new student";
            btnNewStudent.UseVisualStyleBackColor = true;
            btnNewStudent.Click += btnNewStudent_Click;
            // 
            // nmrStudentHouse
            // 
            nmrStudentHouse.Location = new Point(118, 149);
            nmrStudentHouse.Margin = new Padding(3, 2, 3, 2);
            nmrStudentHouse.Name = "nmrStudentHouse";
            nmrStudentHouse.Size = new Size(116, 27);
            nmrStudentHouse.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(134, 134);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 8;
            label5.Text = "Studenthouse";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(118, 95);
            tbLastName.Margin = new Padding(3, 2, 3, 2);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(118, 27);
            tbLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 2;
            label2.Text = "Last name:";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(116, 46);
            tbFirstName.Margin = new Padding(3, 2, 3, 2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(118, 27);
            tbFirstName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 32);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // lbStudents
            // 
            lbStudents.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudents.FormattingEnabled = true;
            lbStudents.ItemHeight = 17;
            lbStudents.Location = new Point(382, 16);
            lbStudents.Margin = new Padding(3, 2, 3, 2);
            lbStudents.Name = "lbStudents";
            lbStudents.Size = new Size(244, 259);
            lbStudents.TabIndex = 0;
            // 
            // tabComplaints
            // 
            tabComplaints.Controls.Add(tbComplaints);
            tabComplaints.Controls.Add(lbComplaints);
            tabComplaints.Location = new Point(4, 26);
            tabComplaints.Margin = new Padding(3, 2, 3, 2);
            tabComplaints.Name = "tabComplaints";
            tabComplaints.Padding = new Padding(3, 2, 3, 2);
            tabComplaints.Size = new Size(639, 290);
            tabComplaints.TabIndex = 1;
            tabComplaints.Text = "Complaints";
            tabComplaints.UseVisualStyleBackColor = true;
            // 
            // tbComplaints
            // 
            tbComplaints.Enabled = false;
            tbComplaints.Location = new Point(326, 14);
            tbComplaints.Margin = new Padding(3, 2, 3, 2);
            tbComplaints.Multiline = true;
            tbComplaints.Name = "tbComplaints";
            tbComplaints.Size = new Size(298, 272);
            tbComplaints.TabIndex = 2;
            // 
            // lbComplaints
            // 
            lbComplaints.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbComplaints.FormattingEnabled = true;
            lbComplaints.ItemHeight = 17;
            lbComplaints.Location = new Point(15, 14);
            lbComplaints.Margin = new Padding(3, 2, 3, 2);
            lbComplaints.Name = "lbComplaints";
            lbComplaints.Size = new Size(298, 259);
            lbComplaints.TabIndex = 1;
            lbComplaints.DoubleClick += lbComplaints_DoubleClick;
            // 
            // tabAgreements
            // 
            tabAgreements.Controls.Add(tbAgreement);
            tabAgreements.Controls.Add(lbAgreements);
            tabAgreements.Location = new Point(4, 26);
            tabAgreements.Margin = new Padding(3, 2, 3, 2);
            tabAgreements.Name = "tabAgreements";
            tabAgreements.Size = new Size(639, 290);
            tabAgreements.TabIndex = 2;
            tabAgreements.Text = "Agreements";
            tabAgreements.UseVisualStyleBackColor = true;
            // 
            // tbAgreement
            // 
            tbAgreement.Enabled = false;
            tbAgreement.Location = new Point(327, 14);
            tbAgreement.Margin = new Padding(3, 2, 3, 2);
            tbAgreement.Multiline = true;
            tbAgreement.Name = "tbAgreement";
            tbAgreement.Size = new Size(298, 272);
            tbAgreement.TabIndex = 1;
            // 
            // lbAgreements
            // 
            lbAgreements.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbAgreements.FormattingEnabled = true;
            lbAgreements.HorizontalScrollbar = true;
            lbAgreements.ItemHeight = 17;
            lbAgreements.Location = new Point(15, 14);
            lbAgreements.Margin = new Padding(3, 2, 3, 2);
            lbAgreements.Name = "lbAgreements";
            lbAgreements.Size = new Size(298, 259);
            lbAgreements.TabIndex = 0;
            lbAgreements.MouseDoubleClick += lbAgreements_MouseDoubleClick;
            // 
            // tabRules
            // 
            tabRules.Controls.Add(btnDeleteRule);
            tabRules.Controls.Add(lbRules);
            tabRules.Controls.Add(groupBox1);
            tabRules.Location = new Point(4, 26);
            tabRules.Margin = new Padding(3, 2, 3, 2);
            tabRules.Name = "tabRules";
            tabRules.Size = new Size(639, 290);
            tabRules.TabIndex = 3;
            tabRules.Text = "Rules";
            tabRules.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRule
            // 
            btnDeleteRule.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteRule.Location = new Point(11, 257);
            btnDeleteRule.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRule.Name = "btnDeleteRule";
            btnDeleteRule.Size = new Size(347, 29);
            btnDeleteRule.TabIndex = 4;
            btnDeleteRule.Text = "Delete selected rule";
            btnDeleteRule.UseVisualStyleBackColor = true;
            btnDeleteRule.Click += btnDeleteRule_Click;
            // 
            // lbRules
            // 
            lbRules.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbRules.FormattingEnabled = true;
            lbRules.HorizontalScrollbar = true;
            lbRules.IntegralHeight = false;
            lbRules.ItemHeight = 17;
            lbRules.Location = new Point(383, 16);
            lbRules.Margin = new Padding(3, 2, 3, 2);
            lbRules.Name = "lbRules";
            lbRules.Size = new Size(252, 272);
            lbRules.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNewRule);
            groupBox1.Controls.Add(tbRule);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 10);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(347, 243);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create new rule";
            // 
            // btnNewRule
            // 
            btnNewRule.Location = new Point(76, 209);
            btnNewRule.Margin = new Padding(3, 2, 3, 2);
            btnNewRule.Name = "btnNewRule";
            btnNewRule.Size = new Size(193, 25);
            btnNewRule.TabIndex = 10;
            btnNewRule.Text = "Create the rule";
            btnNewRule.UseVisualStyleBackColor = true;
            btnNewRule.Click += btnNewRule_Click;
            // 
            // tbRule
            // 
            tbRule.Location = new Point(40, 36);
            tbRule.Margin = new Padding(3, 2, 3, 2);
            tbRule.Multiline = true;
            tbRule.Name = "tbRule";
            tbRule.Size = new Size(266, 170);
            tbRule.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 36);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 0;
            label6.Text = "Rule:";
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(btnDeleteTask);
            tabTasks.Controls.Add(btnAssignTaskRandom);
            tabTasks.Controls.Add(dateTimePicker1);
            tabTasks.Controls.Add(btnAssigningTask);
            tabTasks.Controls.Add(btnCreateTask);
            tabTasks.Controls.Add(label3);
            tabTasks.Controls.Add(tbTask);
            tabTasks.Controls.Add(lbStudentsTask);
            tabTasks.Controls.Add(lbTasks);
            tabTasks.Location = new Point(4, 26);
            tabTasks.Margin = new Padding(3, 2, 3, 2);
            tabTasks.Name = "tabTasks";
            tabTasks.Size = new Size(639, 290);
            tabTasks.TabIndex = 4;
            tabTasks.Text = "Tasks";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteTask.Location = new Point(182, 184);
            btnDeleteTask.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(136, 26);
            btnDeleteTask.TabIndex = 11;
            btnDeleteTask.Text = "Delete a task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnAssignTaskRandom
            // 
            btnAssignTaskRandom.Location = new Point(50, 259);
            btnAssignTaskRandom.Margin = new Padding(3, 2, 3, 2);
            btnAssignTaskRandom.Name = "btnAssignTaskRandom";
            btnAssignTaskRandom.Size = new Size(219, 22);
            btnAssignTaskRandom.TabIndex = 10;
            btnAssignTaskRandom.Text = "Randomly assign the task";
            btnAssignTaskRandom.UseVisualStyleBackColor = true;
            btnAssignTaskRandom.Click += btnAssignTaskRandom_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 158);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 22);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2023, 6, 8, 11, 35, 2, 0);
            // 
            // btnAssigningTask
            // 
            btnAssigningTask.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssigningTask.Location = new Point(93, 226);
            btnAssigningTask.Margin = new Padding(3, 2, 3, 2);
            btnAssigningTask.Name = "btnAssigningTask";
            btnAssigningTask.Size = new Size(139, 32);
            btnAssigningTask.TabIndex = 8;
            btnAssigningTask.Text = "Assign the task";
            btnAssigningTask.UseVisualStyleBackColor = true;
            btnAssigningTask.Click += btnAssigningTask_Click;
            // 
            // btnCreateTask
            // 
            btnCreateTask.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateTask.Location = new Point(13, 184);
            btnCreateTask.Margin = new Padding(3, 2, 3, 2);
            btnCreateTask.Name = "btnCreateTask";
            btnCreateTask.Size = new Size(139, 26);
            btnCreateTask.TabIndex = 4;
            btnCreateTask.Text = "Create a task";
            btnCreateTask.UseVisualStyleBackColor = true;
            btnCreateTask.Click += btnCreateTask_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 12);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 3;
            label3.Text = "Create a task";
            // 
            // tbTask
            // 
            tbTask.Location = new Point(13, 30);
            tbTask.Margin = new Padding(3, 2, 3, 2);
            tbTask.Multiline = true;
            tbTask.Name = "tbTask";
            tbTask.Size = new Size(305, 111);
            tbTask.TabIndex = 2;
            // 
            // lbStudentsTask
            // 
            lbStudentsTask.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudentsTask.FormattingEnabled = true;
            lbStudentsTask.ItemHeight = 17;
            lbStudentsTask.Location = new Point(337, 158);
            lbStudentsTask.Margin = new Padding(3, 2, 3, 2);
            lbStudentsTask.Name = "lbStudentsTask";
            lbStudentsTask.Size = new Size(286, 123);
            lbStudentsTask.TabIndex = 1;
            // 
            // lbTasks
            // 
            lbTasks.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTasks.FormattingEnabled = true;
            lbTasks.ItemHeight = 17;
            lbTasks.Location = new Point(337, 25);
            lbTasks.Margin = new Padding(3, 2, 3, 2);
            lbTasks.Name = "lbTasks";
            lbTasks.Size = new Size(286, 106);
            lbTasks.TabIndex = 0;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(btnDeleteUser);
            tabUsers.Controls.Add(lbUsers);
            tabUsers.Controls.Add(groupBox2);
            tabUsers.Location = new Point(4, 26);
            tabUsers.Margin = new Padding(3, 2, 3, 2);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3, 2, 3, 2);
            tabUsers.Size = new Size(639, 290);
            tabUsers.TabIndex = 5;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteUser.Location = new Point(340, 244);
            btnDeleteUser.Margin = new Padding(3, 2, 3, 2);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(294, 32);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete selected user";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // lbUsers
            // 
            lbUsers.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 17;
            lbUsers.Location = new Point(340, 17);
            lbUsers.Margin = new Padding(3, 2, 3, 2);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(294, 208);
            lbUsers.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCreateUser);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbStudent);
            groupBox2.Controls.Add(tbPassword);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbUsername);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbUserType);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(10, 10);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(319, 278);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create new user";
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(6, 234);
            btnCreateUser.Margin = new Padding(3, 2, 3, 2);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(306, 32);
            btnCreateUser.TabIndex = 8;
            btnCreateUser.Text = "Create the user";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(46, 172);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 7;
            label9.Text = "Student:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.Enabled = false;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(46, 187);
            cbStudent.Margin = new Padding(3, 2, 3, 2);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(239, 29);
            cbStudent.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(46, 142);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(239, 27);
            tbPassword.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(46, 128);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 4;
            label8.Text = "Password:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(46, 98);
            tbUsername.Margin = new Padding(3, 2, 3, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(239, 27);
            tbUsername.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 83);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 2;
            label7.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 38);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 1;
            label4.Text = "Type of user:";
            // 
            // cbUserType
            // 
            cbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserType.FormattingEnabled = true;
            cbUserType.Items.AddRange(new object[] { "Student", "Admin" });
            cbUserType.Location = new Point(46, 52);
            cbUserType.Margin = new Padding(3, 2, 3, 2);
            cbUserType.Name = "cbUserType";
            cbUserType.Size = new Size(239, 29);
            cbUserType.TabIndex = 0;
            cbUserType.SelectedIndexChanged += cbUserType_SelectedIndexChanged;
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 338);
            Controls.Add(tabcontrol);
            Name = "AdminWindow";
            Text = "AdminWindow";
            tabcontrol.ResumeLayout(false);
            tabStudents.ResumeLayout(false);
            gpNewStudent.ResumeLayout(false);
            gpNewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrStudentHouse).EndInit();
            tabComplaints.ResumeLayout(false);
            tabComplaints.PerformLayout();
            tabAgreements.ResumeLayout(false);
            tabAgreements.PerformLayout();
            tabRules.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabTasks.ResumeLayout(false);
            tabTasks.PerformLayout();
            tabUsers.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol;
        private TabPage tabStudents;
        private TabPage tabComplaints;
        private TabPage tabAgreements;
        private TabPage tabRules;
        private GroupBox gpNewStudent;
        private Button btnNewStudent;
        private NumericUpDown nmrStudentHouse;
        private Label label5;
        private TextBox tbLastName;
        private Label label2;
        private TextBox tbFirstName;
        private Label label1;
        private ListBox lbStudents;
        private Button btnDeleteStudent;
        private ListBox lbAgreements;
        private TextBox tbAgreement;
        private ListBox lbComplaints;
        private TextBox tbComplaints;
        private ListBox lbRules;
        private GroupBox groupBox1;
        private Button btnNewRule;
        private TextBox tbRule;
        private Label label6;
        private Button btnDeleteRule;
        private TabPage tabTasks;
        private ListBox lbStudentsTask;
        private ListBox lbTasks;
        private Button btnCreateTask;
        private Label label3;
        private TextBox tbTask;
        private Button btnAssigningTask;
        private TabPage tabUsers;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox cbUserType;
        private TextBox tbPassword;
        private Label label8;
        private TextBox tbUsername;
        private Label label7;
        private Button btnCreateUser;
        private Label label9;
        private ComboBox cbStudent;
        private ListBox lbUsers;
        private Button btnDeleteUser;
        private DateTimePicker dateTimePicker1;
        private Button btnAssignTaskRandom;
        private Button btnDeleteTask;
    }
}