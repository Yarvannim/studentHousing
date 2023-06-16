namespace StudentApp
{
    partial class NewAgreementWindow
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
            tbAgreement = new TextBox();
            btnAgreement = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // tbAgreement
            // 
            tbAgreement.Location = new Point(1, 4);
            tbAgreement.Multiline = true;
            tbAgreement.Name = "tbAgreement";
            tbAgreement.Size = new Size(451, 252);
            tbAgreement.TabIndex = 0;
            // 
            // btnAgreement
            // 
            btnAgreement.Location = new Point(266, 266);
            btnAgreement.Name = "btnAgreement";
            btnAgreement.Size = new Size(176, 23);
            btnAgreement.TabIndex = 1;
            btnAgreement.Text = "Submit agreement";
            btnAgreement.UseVisualStyleBackColor = true;
            btnAgreement.Click += btnAgreement_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // NewAgreementWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 295);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnAgreement);
            Controls.Add(tbAgreement);
            Name = "NewAgreementWindow";
            Text = "New agreement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAgreement;
        private Button btnAgreement;
        private DateTimePicker dateTimePicker1;
    }
}