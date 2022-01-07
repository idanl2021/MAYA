namespace IdanLalezari326643269.FORMS
{
    partial class ManagerMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavBarPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.ToClasses_NavButton = new IdanLalezari326643269.CONTROLS.NavButton();
            this.ToTeachers_NavButton = new IdanLalezari326643269.CONTROLS.NavButton();
            this.ToStudents_NavButton = new IdanLalezari326643269.CONTROLS.NavButton();
            this.panel1.SuspendLayout();
            this.NavBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.ToClasses_NavButton);
            this.panel1.Controls.Add(this.ToTeachers_NavButton);
            this.panel1.Controls.Add(this.ToStudents_NavButton);
            this.panel1.Location = new System.Drawing.Point(975, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 642);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.NavBarPanel.Controls.Add(this.CloseBTN);
            this.NavBarPanel.Location = new System.Drawing.Point(-1, 1);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Size = new System.Drawing.Size(1176, 56);
            this.NavBarPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(2, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(967, 634);
            this.mainPanel.TabIndex = 2;
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(3, 3);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(45, 42);
            this.CloseBTN.TabIndex = 0;
            this.CloseBTN.Text = "close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // ToClasses_NavButton
            // 
            this.ToClasses_NavButton.BackColor = System.Drawing.Color.Transparent;
            this.ToClasses_NavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToClasses_NavButton.Location = new System.Drawing.Point(0, 100);
            this.ToClasses_NavButton.Name = "ToClasses_NavButton";
            this.ToClasses_NavButton.Size = new System.Drawing.Size(197, 44);
            this.ToClasses_NavButton.TabIndex = 3;
            this.ToClasses_NavButton.Load += new System.EventHandler(this.ToClasses_NavButton_Load);
            this.ToClasses_NavButton.Click += new System.EventHandler(this.ToClasses_NavButton_Click);
            // 
            // ToTeachers_NavButton
            // 
            this.ToTeachers_NavButton.BackColor = System.Drawing.Color.Transparent;
            this.ToTeachers_NavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToTeachers_NavButton.Location = new System.Drawing.Point(0, 50);
            this.ToTeachers_NavButton.Name = "ToTeachers_NavButton";
            this.ToTeachers_NavButton.Size = new System.Drawing.Size(200, 44);
            this.ToTeachers_NavButton.TabIndex = 2;
            this.ToTeachers_NavButton.Load += new System.EventHandler(this.ToTeachers_NavButton_Load);
            this.ToTeachers_NavButton.Click += new System.EventHandler(this.ToTeachers_NavButton_Click);
            // 
            // ToStudents_NavButton
            // 
            this.ToStudents_NavButton.BackColor = System.Drawing.Color.Transparent;
            this.ToStudents_NavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToStudents_NavButton.Location = new System.Drawing.Point(0, 0);
            this.ToStudents_NavButton.Name = "ToStudents_NavButton";
            this.ToStudents_NavButton.Size = new System.Drawing.Size(200, 44);
            this.ToStudents_NavButton.TabIndex = 0;
            this.ToStudents_NavButton.Load += new System.EventHandler(this.ToStudents_NavButton_Load);
            this.ToStudents_NavButton.Click += new System.EventHandler(this.ToStudents_NavButton_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 697);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.NavBarPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerMainForm";
            this.Text = "ManagerMainForm";
            this.Load += new System.EventHandler(this.ManagerMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.NavBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel NavBarPanel;
        private CONTROLS.NavButton ToStudents_NavButton;
        private CONTROLS.NavButton ToTeachers_NavButton;
        private System.Windows.Forms.Panel mainPanel;
        private CONTROLS.NavButton ToClasses_NavButton;
        private System.Windows.Forms.Button CloseBTN;
    }
}