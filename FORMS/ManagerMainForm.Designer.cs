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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toLessons = new System.Windows.Forms.Button();
            this.toStudents_BTN = new System.Windows.Forms.Button();
            this.toTeachers_BTN = new System.Windows.Forms.Button();
            this.toClasses_BTN = new System.Windows.Forms.Button();
            this.NavBarPanel = new System.Windows.Forms.Panel();
            this.hour_LBL = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer_HourLBL = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.NavBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.toLessons);
            this.panel1.Controls.Add(this.toStudents_BTN);
            this.panel1.Controls.Add(this.toTeachers_BTN);
            this.panel1.Controls.Add(this.toClasses_BTN);
            this.panel1.Location = new System.Drawing.Point(975, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 642);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toLessons
            // 
            this.toLessons.BackColor = System.Drawing.Color.Transparent;
            this.toLessons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toLessons.FlatAppearance.BorderSize = 0;
            this.toLessons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.toLessons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.toLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toLessons.Font = new System.Drawing.Font("Guttman Kav-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toLessons.Location = new System.Drawing.Point(0, 154);
            this.toLessons.Name = "toLessons";
            this.toLessons.Size = new System.Drawing.Size(203, 44);
            this.toLessons.TabIndex = 5;
            this.toLessons.Text = "שיעורים";
            this.toLessons.UseVisualStyleBackColor = false;
            this.toLessons.Click += new System.EventHandler(this.toLessons_Click);
            // 
            // toStudents_BTN
            // 
            this.toStudents_BTN.BackColor = System.Drawing.Color.Transparent;
            this.toStudents_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toStudents_BTN.FlatAppearance.BorderSize = 0;
            this.toStudents_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.toStudents_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.toStudents_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toStudents_BTN.Font = new System.Drawing.Font("Guttman Kav-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toStudents_BTN.Location = new System.Drawing.Point(0, 4);
            this.toStudents_BTN.Name = "toStudents_BTN";
            this.toStudents_BTN.Size = new System.Drawing.Size(203, 44);
            this.toStudents_BTN.TabIndex = 4;
            this.toStudents_BTN.Text = "תלמידים";
            this.toStudents_BTN.UseVisualStyleBackColor = false;
            this.toStudents_BTN.Click += new System.EventHandler(this.toStudents_BTN_Click);
            // 
            // toTeachers_BTN
            // 
            this.toTeachers_BTN.BackColor = System.Drawing.Color.Transparent;
            this.toTeachers_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toTeachers_BTN.FlatAppearance.BorderSize = 0;
            this.toTeachers_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.toTeachers_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.toTeachers_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toTeachers_BTN.Font = new System.Drawing.Font("Guttman Kav-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toTeachers_BTN.Location = new System.Drawing.Point(0, 54);
            this.toTeachers_BTN.Name = "toTeachers_BTN";
            this.toTeachers_BTN.Size = new System.Drawing.Size(203, 44);
            this.toTeachers_BTN.TabIndex = 4;
            this.toTeachers_BTN.Text = "מורים";
            this.toTeachers_BTN.UseVisualStyleBackColor = false;
            this.toTeachers_BTN.Click += new System.EventHandler(this.toTeachers_BTN_Click);
            // 
            // toClasses_BTN
            // 
            this.toClasses_BTN.BackColor = System.Drawing.Color.Transparent;
            this.toClasses_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toClasses_BTN.FlatAppearance.BorderSize = 0;
            this.toClasses_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.toClasses_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.toClasses_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toClasses_BTN.Font = new System.Drawing.Font("Guttman Kav-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toClasses_BTN.Location = new System.Drawing.Point(0, 104);
            this.toClasses_BTN.Name = "toClasses_BTN";
            this.toClasses_BTN.Size = new System.Drawing.Size(203, 44);
            this.toClasses_BTN.TabIndex = 4;
            this.toClasses_BTN.Text = "כיתות";
            this.toClasses_BTN.UseVisualStyleBackColor = false;
            this.toClasses_BTN.Click += new System.EventHandler(this.toClasses_BTN_Click);
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.NavBarPanel.Controls.Add(this.hour_LBL);
            this.NavBarPanel.Controls.Add(this.greetingLabel);
            this.NavBarPanel.Controls.Add(this.CloseBTN);
            this.NavBarPanel.Location = new System.Drawing.Point(-1, 1);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Size = new System.Drawing.Size(1176, 56);
            this.NavBarPanel.TabIndex = 1;
            // 
            // hour_LBL
            // 
            this.hour_LBL.AutoSize = true;
            this.hour_LBL.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_LBL.ForeColor = System.Drawing.Color.White;
            this.hour_LBL.Location = new System.Drawing.Point(54, 8);
            this.hour_LBL.Name = "hour_LBL";
            this.hour_LBL.Size = new System.Drawing.Size(85, 32);
            this.hour_LBL.TabIndex = 2;
            this.hour_LBL.Text = "00:00";
            this.hour_LBL.Click += new System.EventHandler(this.hour_LBL_Click);
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.ForeColor = System.Drawing.Color.White;
            this.greetingLabel.Location = new System.Drawing.Point(987, 8);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(177, 32);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "ברוכים השבים";
            this.greetingLabel.Click += new System.EventHandler(this.greetingLabel_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.IndianRed;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(3, 3);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(23, 26);
            this.CloseBTN.TabIndex = 0;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            this.CloseBTN.MouseEnter += new System.EventHandler(this.CloseBTN_MouseEnter);
            this.CloseBTN.MouseLeave += new System.EventHandler(this.CloseBTN_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(2, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(967, 634);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // timer_HourLBL
            // 
            this.timer_HourLBL.Enabled = true;
            this.timer_HourLBL.Interval = 1000;
            this.timer_HourLBL.Tick += new System.EventHandler(this.timer_HourLBL_Tick);
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
            this.NavBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel NavBarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button toStudents_BTN;
        private System.Windows.Forms.Button toTeachers_BTN;
        private System.Windows.Forms.Button toClasses_BTN;
        private System.Windows.Forms.Label hour_LBL;
        private System.Windows.Forms.Timer timer_HourLBL;
        private System.Windows.Forms.Button toLessons;
    }
}