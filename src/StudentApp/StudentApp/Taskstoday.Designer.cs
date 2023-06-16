namespace StudentApp
{
    partial class Taskstoday
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
            lbTasks = new ListBox();
            SuspendLayout();
            // 
            // lbTasks
            // 
            lbTasks.FormattingEnabled = true;
            lbTasks.ItemHeight = 15;
            lbTasks.Location = new Point(12, 12);
            lbTasks.Name = "lbTasks";
            lbTasks.Size = new Size(439, 274);
            lbTasks.TabIndex = 0;
            lbTasks.DoubleClick += lbTasks_DoubleClick;
            // 
            // Taskstoday
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 293);
            Controls.Add(lbTasks);
            Name = "Taskstoday";
            Text = "Tasks for today";
            Load += EventFrom_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbTasks;
    }
}