
namespace IdanLalezari326643269.FORMS
{
    partial class TeacherMainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.NavBarPanel = new System.Windows.Forms.Panel();
            this.hour_LBL = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(4, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(967, 634);
            this.mainPanel.TabIndex = 5;
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.NavBarPanel.Controls.Add(this.hour_LBL);
            this.NavBarPanel.Controls.Add(this.greetingLabel);
            this.NavBarPanel.Controls.Add(this.CloseBTN);
            this.NavBarPanel.Location = new System.Drawing.Point(1, 1);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Size = new System.Drawing.Size(1176, 56);
            this.NavBarPanel.TabIndex = 4;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(977, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 642);
            this.panel1.TabIndex = 3;
            this.panel1.Tag = "";
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 699);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.NavBarPanel);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherMainForm";
            this.Text = "TeacherMainForm";
            this.NavBarPanel.ResumeLayout(false);
            this.NavBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel NavBarPanel;
        private System.Windows.Forms.Label hour_LBL;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Panel panel1;
    }
}