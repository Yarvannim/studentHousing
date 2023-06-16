namespace StudentApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gpCalendar = new GroupBox();
            gpAgreements = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            btnVoteNo = new Button();
            btnVoteYes = new Button();
            tbAgreementDetail = new TextBox();
            btnNewAgreement = new Button();
            lbAgreements = new ListBox();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            daycontainer = new FlowLayoutPanel();
            btnNext = new Button();
            btnPrevious = new Button();
            lbMonth = new Label();
            gpComplaints = new GroupBox();
            gpRules = new GroupBox();
            lbRules = new ListBox();
            label9 = new Label();
            tbComplaintTitle = new TextBox();
            cbAnonymous = new CheckBox();
            btnSubmitComplaint = new Button();
            tbComplaint = new TextBox();
            lblTitle = new Label();
            lbStudents = new ListBox();
            btnCalendar = new Button();
            btnAgreements = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            btnRule = new Button();
            btnComplaint = new Button();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            Clock = new System.Windows.Forms.Timer(components);
            gpCalendar.SuspendLayout();
            gpAgreements.SuspendLayout();
            gpComplaints.SuspendLayout();
            gpRules.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gpCalendar
            // 
            gpCalendar.Controls.Add(gpAgreements);
            gpCalendar.Controls.Add(label8);
            gpCalendar.Controls.Add(label7);
            gpCalendar.Controls.Add(label6);
            gpCalendar.Controls.Add(label5);
            gpCalendar.Controls.Add(label4);
            gpCalendar.Controls.Add(label3);
            gpCalendar.Controls.Add(label2);
            gpCalendar.Controls.Add(daycontainer);
            gpCalendar.Controls.Add(btnNext);
            gpCalendar.Controls.Add(btnPrevious);
            gpCalendar.Controls.Add(lbMonth);
            gpCalendar.Location = new Point(206, 127);
            gpCalendar.Name = "gpCalendar";
            gpCalendar.Size = new Size(802, 566);
            gpCalendar.TabIndex = 0;
            gpCalendar.TabStop = false;
            // 
            // gpAgreements
            // 
            gpAgreements.Controls.Add(label13);
            gpAgreements.Controls.Add(label12);
            gpAgreements.Controls.Add(btnVoteNo);
            gpAgreements.Controls.Add(btnVoteYes);
            gpAgreements.Controls.Add(tbAgreementDetail);
            gpAgreements.Controls.Add(btnNewAgreement);
            gpAgreements.Controls.Add(lbAgreements);
            gpAgreements.Controls.Add(label1);
            gpAgreements.Location = new Point(0, 0);
            gpAgreements.Name = "gpAgreements";
            gpAgreements.Size = new Size(802, 566);
            gpAgreements.TabIndex = 11;
            gpAgreements.TabStop = false;
            gpAgreements.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(417, 80);
            label13.Name = "label13";
            label13.Size = new Size(271, 23);
            label13.TabIndex = 19;
            label13.Text = "(double tap on an agreement)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(85, 69);
            label12.Name = "label12";
            label12.Size = new Size(171, 34);
            label12.TabIndex = 18;
            label12.Text = "Description";
            // 
            // btnVoteNo
            // 
            btnVoteNo.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoteNo.ForeColor = Color.Black;
            btnVoteNo.Location = new Point(181, 387);
            btnVoteNo.Name = "btnVoteNo";
            btnVoteNo.Size = new Size(142, 39);
            btnVoteNo.TabIndex = 17;
            btnVoteNo.Text = "Vote no";
            btnVoteNo.UseVisualStyleBackColor = true;
            btnVoteNo.Click += btnVoteNo_Click;
            // 
            // btnVoteYes
            // 
            btnVoteYes.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoteYes.ForeColor = Color.Black;
            btnVoteYes.Location = new Point(16, 387);
            btnVoteYes.Name = "btnVoteYes";
            btnVoteYes.Size = new Size(145, 39);
            btnVoteYes.TabIndex = 16;
            btnVoteYes.Text = "Vote yes";
            btnVoteYes.UseVisualStyleBackColor = true;
            btnVoteYes.Click += btnVoteYes_Click;
            // 
            // tbAgreementDetail
            // 
            tbAgreementDetail.BackColor = Color.White;
            tbAgreementDetail.BorderStyle = BorderStyle.FixedSingle;
            tbAgreementDetail.Enabled = false;
            tbAgreementDetail.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbAgreementDetail.Location = new Point(16, 110);
            tbAgreementDetail.Multiline = true;
            tbAgreementDetail.Name = "tbAgreementDetail";
            tbAgreementDetail.Size = new Size(307, 260);
            tbAgreementDetail.TabIndex = 15;
            // 
            // btnNewAgreement
            // 
            btnNewAgreement.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewAgreement.ForeColor = Color.Black;
            btnNewAgreement.Location = new Point(16, 435);
            btnNewAgreement.Name = "btnNewAgreement";
            btnNewAgreement.Size = new Size(307, 55);
            btnNewAgreement.TabIndex = 14;
            btnNewAgreement.Text = "Create new agreement";
            btnNewAgreement.UseVisualStyleBackColor = true;
            btnNewAgreement.Click += btnNewAgreement_Click;
            // 
            // lbAgreements
            // 
            lbAgreements.BorderStyle = BorderStyle.FixedSingle;
            lbAgreements.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAgreements.FormattingEnabled = true;
            lbAgreements.ItemHeight = 18;
            lbAgreements.Location = new Point(344, 110);
            lbAgreements.Name = "lbAgreements";
            lbAgreements.Size = new Size(435, 380);
            lbAgreements.TabIndex = 13;
            lbAgreements.DoubleClick += lbAgreements_DoubleClick;
            // 
            // label1
            // 
            label1.Font = new Font("Century", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(466, 29);
            label1.Name = "label1";
            label1.Size = new Size(178, 49);
            label1.TabIndex = 12;
            label1.Text = "Agreements";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(650, 113);
            label8.Name = "label8";
            label8.Size = new Size(85, 43);
            label8.TabIndex = 10;
            label8.Text = " Sunday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(547, 113);
            label7.Name = "label7";
            label7.Size = new Size(97, 43);
            label7.TabIndex = 9;
            label7.Text = " Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(452, 113);
            label6.Name = "label6";
            label6.Size = new Size(76, 43);
            label6.TabIndex = 8;
            label6.Text = " Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(344, 113);
            label5.Name = "label5";
            label5.Size = new Size(102, 43);
            label5.TabIndex = 7;
            label5.Text = " Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(234, 113);
            label4.Name = "label4";
            label4.Size = new Size(113, 43);
            label4.TabIndex = 6;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(150, 113);
            label3.Name = "label3";
            label3.Size = new Size(87, 43);
            label3.TabIndex = 5;
            label3.Text = "Tuesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(48, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 43);
            label2.TabIndex = 4;
            label2.Text = "Monday";
            // 
            // daycontainer
            // 
            daycontainer.BackColor = Color.Transparent;
            daycontainer.Location = new Point(41, 170);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(749, 374);
            daycontainer.TabIndex = 3;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Violet;
            btnNext.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(627, 45);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(120, 32);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Violet;
            btnPrevious.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.Black;
            btnPrevious.Location = new Point(48, 45);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(120, 33);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lbMonth
            // 
            lbMonth.Font = new Font("Century", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbMonth.Location = new Point(196, 30);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(405, 49);
            lbMonth.TabIndex = 0;
            lbMonth.Text = "MONTH YEAR";
            lbMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gpComplaints
            // 
            gpComplaints.Controls.Add(gpRules);
            gpComplaints.Controls.Add(btnSubmitComplaint);
            gpComplaints.Controls.Add(label9);
            gpComplaints.Controls.Add(tbComplaintTitle);
            gpComplaints.Controls.Add(cbAnonymous);
            gpComplaints.Controls.Add(tbComplaint);
            gpComplaints.Location = new Point(206, 127);
            gpComplaints.Name = "gpComplaints";
            gpComplaints.Size = new Size(802, 566);
            gpComplaints.TabIndex = 13;
            gpComplaints.TabStop = false;
            gpComplaints.Visible = false;
            // 
            // gpRules
            // 
            gpRules.Controls.Add(lbRules);
            gpRules.Location = new Point(0, 0);
            gpRules.Name = "gpRules";
            gpRules.Size = new Size(802, 566);
            gpRules.TabIndex = 18;
            gpRules.TabStop = false;
            gpRules.Visible = false;
            // 
            // lbRules
            // 
            lbRules.BackColor = Color.HotPink;
            lbRules.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbRules.ForeColor = Color.White;
            lbRules.FormattingEnabled = true;
            lbRules.HorizontalScrollbar = true;
            lbRules.ItemHeight = 23;
            lbRules.Location = new Point(99, 45);
            lbRules.Name = "lbRules";
            lbRules.Size = new Size(609, 487);
            lbRules.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(45, 39);
            label9.Name = "label9";
            label9.Size = new Size(228, 34);
            label9.TabIndex = 17;
            label9.Text = "Complaint title:";
            // 
            // tbComplaintTitle
            // 
            tbComplaintTitle.BorderStyle = BorderStyle.FixedSingle;
            tbComplaintTitle.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbComplaintTitle.Location = new Point(278, 38);
            tbComplaintTitle.Name = "tbComplaintTitle";
            tbComplaintTitle.Size = new Size(473, 36);
            tbComplaintTitle.TabIndex = 16;
            // 
            // cbAnonymous
            // 
            cbAnonymous.AutoSize = true;
            cbAnonymous.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbAnonymous.Location = new Point(300, 455);
            cbAnonymous.Name = "cbAnonymous";
            cbAnonymous.Size = new Size(251, 29);
            cbAnonymous.TabIndex = 15;
            cbAnonymous.Text = "Anonymous complaint";
            cbAnonymous.UseVisualStyleBackColor = true;
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.Font = new Font("Century", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmitComplaint.ForeColor = Color.Black;
            btnSubmitComplaint.Location = new Point(41, 490);
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.Size = new Size(729, 54);
            btnSubmitComplaint.TabIndex = 14;
            btnSubmitComplaint.Text = "Submit complaint";
            btnSubmitComplaint.UseVisualStyleBackColor = true;
            btnSubmitComplaint.Click += btnSubmitComplaint_Click;
            // 
            // tbComplaint
            // 
            tbComplaint.BorderStyle = BorderStyle.FixedSingle;
            tbComplaint.Font = new Font("Century", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbComplaint.Location = new Point(41, 98);
            tbComplaint.Multiline = true;
            tbComplaint.Name = "tbComplaint";
            tbComplaint.Size = new Size(729, 351);
            tbComplaint.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Century", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(207, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(405, 49);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Calendar";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbStudents
            // 
            lbStudents.BackColor = Color.FromArgb(192, 192, 255);
            lbStudents.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudents.FormattingEnabled = true;
            lbStudents.ItemHeight = 36;
            lbStudents.Location = new Point(6, 401);
            lbStudents.Name = "lbStudents";
            lbStudents.Size = new Size(188, 292);
            lbStudents.TabIndex = 4;
            // 
            // btnCalendar
            // 
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendar.Location = new Point(6, 99);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(188, 60);
            btnCalendar.TabIndex = 0;
            btnCalendar.Text = "          Calendar";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnAgreements
            // 
            btnAgreements.FlatStyle = FlatStyle.Flat;
            btnAgreements.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgreements.ForeColor = Color.White;
            btnAgreements.Image = (Image)resources.GetObject("btnAgreements.Image");
            btnAgreements.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgreements.Location = new Point(6, 165);
            btnAgreements.Name = "btnAgreements";
            btnAgreements.Size = new Size(188, 60);
            btnAgreements.TabIndex = 1;
            btnAgreements.Text = "          Agreements";
            btnAgreements.TextAlign = ContentAlignment.MiddleLeft;
            btnAgreements.UseVisualStyleBackColor = true;
            btnAgreements.Click += btnAgreements_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Controls.Add(btnAgreements);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnRule);
            panel2.Controls.Add(btnComplaint);
            panel2.Controls.Add(lbStudents);
            panel2.Controls.Add(btnCalendar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 705);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 93);
            panel1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(84, 49);
            label11.Name = "label11";
            label11.Size = new Size(82, 28);
            label11.TabIndex = 1;
            label11.Text = "House";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 21);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 0;
            label10.Text = "Student ";
            // 
            // btnRule
            // 
            btnRule.FlatStyle = FlatStyle.Flat;
            btnRule.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRule.Image = Properties.Resources.document;
            btnRule.ImageAlign = ContentAlignment.MiddleLeft;
            btnRule.Location = new Point(6, 297);
            btnRule.Name = "btnRule";
            btnRule.Size = new Size(188, 60);
            btnRule.TabIndex = 7;
            btnRule.Text = "         Rules";
            btnRule.TextAlign = ContentAlignment.MiddleLeft;
            btnRule.UseVisualStyleBackColor = true;
            btnRule.Click += btnRule_Click;
            // 
            // btnComplaint
            // 
            btnComplaint.FlatStyle = FlatStyle.Flat;
            btnComplaint.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplaint.Image = Properties.Resources.complain1;
            btnComplaint.ImageAlign = ContentAlignment.MiddleLeft;
            btnComplaint.Location = new Point(6, 231);
            btnComplaint.Name = "btnComplaint";
            btnComplaint.Size = new Size(188, 60);
            btnComplaint.TabIndex = 6;
            btnComplaint.Text = "    Complaints";
            btnComplaint.UseVisualStyleBackColor = true;
            btnComplaint.Click += btnComplaint_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Controls.Add(lblTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(820, 93);
            panel3.TabIndex = 13;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Clock
            // 
            Clock.Interval = 1000;
            Clock.Tick += Clock_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(1020, 705);
            Controls.Add(gpComplaints);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(gpCalendar);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student House : Student's page";
            Load += Form1_Load;
            Click += Form1_Click;
            gpCalendar.ResumeLayout(false);
            gpCalendar.PerformLayout();
            gpAgreements.ResumeLayout(false);
            gpAgreements.PerformLayout();
            gpComplaints.ResumeLayout(false);
            gpComplaints.PerformLayout();
            gpRules.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpCalendar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel daycontainer;
        private Button btnNext;
        private Button btnPrevious;
        private Label lbMonth;
        private GroupBox gpAgreements;
        private Button btnAgreements;
        private Button btnCalendar;
        private Label label1;
        private GroupBox gpComplaints;
        private Label lblTitle;
        private CheckBox cbAnonymous;
        private Button btnSubmitComplaint;
        private TextBox tbComplaint;
        private ListBox lbStudents;
        private ListBox lbAgreements;
        private Button btnNewAgreement;
        private TextBox tbAgreementDetail;
        private Button btnVoteNo;
        private Button btnVoteYes;
        private Panel panel2;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private Panel panel3;
        private Button btnComplaint;
        private Button btnRule;
        private Button btnTask;
        private Label label9;
        private TextBox tbComplaintTitle;
        private GroupBox gpRules;
        private ListBox lbRules;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Clock;
        private Label label13;
        private Label label12;
    }
}