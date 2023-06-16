namespace StudentApp
{
    partial class LoginWindow
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
            label1 = new Label();
            label2 = new Label();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 14);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(47, 38);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(235, 23);
            tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(46, 91);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(236, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(12, 137);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(302, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 191);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginWindow";
            Text = "LoginWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnLogin;
    }
}