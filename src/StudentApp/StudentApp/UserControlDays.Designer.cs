namespace StudentApp
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbdays = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbdays.ForeColor = Color.Black;
            lbdays.Location = new Point(4, 5);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(21, 13);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(95, 54);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label label1;
    }
}
