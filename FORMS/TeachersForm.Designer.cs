
using System;

namespace IdanLalezari326643269
{
    partial class TeachersForm
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
            this.TeacherID_Input_string_1 = new System.Windows.Forms.TextBox();
            this.StudentID_Label = new System.Windows.Forms.Label();
            this.PhoneNumber_Input_string_7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthDate_Input_address_6 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.City_Input_string_5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Address_Input_string_4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName_Input_string_3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName_Input_string_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddRecord_BTN
            // 
            this.AddRecord_BTN.Click += new System.EventHandler(this.AddRecord_BTN_Click_1);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(63, 25);
            this.Title.Text = "מורים";
            // 
            // Save_BTN
            // 
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "לפי תעודת זהות",
            "לפי שם פרטי",
            "לפי שם משפחה",
            "לפי עיר",
            "לפי תאריך לידה"});
            // 
            // Search_BTN
            // 
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
            // 
            // TeacherID_Input_string_1
            // 
            this.TeacherID_Input_string_1.Location = new System.Drawing.Point(727, 105);
            this.TeacherID_Input_string_1.Name = "TeacherID_Input_string_1";
            this.TeacherID_Input_string_1.Size = new System.Drawing.Size(100, 20);
            this.TeacherID_Input_string_1.TabIndex = 82;
            // 
            // StudentID_Label
            // 
            this.StudentID_Label.AutoSize = true;
            this.StudentID_Label.Location = new System.Drawing.Point(833, 108);
            this.StudentID_Label.Name = "StudentID_Label";
            this.StudentID_Label.Size = new System.Drawing.Size(67, 13);
            this.StudentID_Label.TabIndex = 81;
            this.StudentID_Label.Text = "תעודת זהות";
            // 
            // PhoneNumber_Input_string_7
            // 
            this.PhoneNumber_Input_string_7.Location = new System.Drawing.Point(515, 211);
            this.PhoneNumber_Input_string_7.MaxLength = 10;
            this.PhoneNumber_Input_string_7.Name = "PhoneNumber_Input_string_7";
            this.PhoneNumber_Input_string_7.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumber_Input_string_7.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "מספר טלפון";
            // 
            // BirthDate_Input_address_6
            // 
            this.BirthDate_Input_address_6.Location = new System.Drawing.Point(415, 176);
            this.BirthDate_Input_address_6.Name = "BirthDate_Input_address_6";
            this.BirthDate_Input_address_6.Size = new System.Drawing.Size(200, 20);
            this.BirthDate_Input_address_6.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "תאריך לידה";
            // 
            // City_Input_string_5
            // 
            this.City_Input_string_5.Location = new System.Drawing.Point(515, 143);
            this.City_Input_string_5.Name = "City_Input_string_5";
            this.City_Input_string_5.Size = new System.Drawing.Size(100, 20);
            this.City_Input_string_5.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "עיר";
            // 
            // Address_Input_string_4
            // 
            this.Address_Input_string_4.Location = new System.Drawing.Point(515, 108);
            this.Address_Input_string_4.Name = "Address_Input_string_4";
            this.Address_Input_string_4.Size = new System.Drawing.Size(100, 20);
            this.Address_Input_string_4.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "כתובת";
            // 
            // LastName_Input_string_3
            // 
            this.LastName_Input_string_3.Location = new System.Drawing.Point(727, 174);
            this.LastName_Input_string_3.Name = "LastName_Input_string_3";
            this.LastName_Input_string_3.Size = new System.Drawing.Size(100, 20);
            this.LastName_Input_string_3.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "שם משפחה";
            // 
            // FirstName_Input_string_2
            // 
            this.FirstName_Input_string_2.Location = new System.Drawing.Point(727, 138);
            this.FirstName_Input_string_2.Name = "FirstName_Input_string_2";
            this.FirstName_Input_string_2.Size = new System.Drawing.Size(100, 20);
            this.FirstName_Input_string_2.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "שם פרטי";
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 585);
            this.Controls.Add(this.TeacherID_Input_string_1);
            this.Controls.Add(this.StudentID_Label);
            this.Controls.Add(this.PhoneNumber_Input_string_7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthDate_Input_address_6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.City_Input_string_5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address_Input_string_4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName_Input_string_3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName_Input_string_2);
            this.Controls.Add(this.label1);
            this.Name = "TeachersForm";
            this.Text = "TeachersForm";
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            this.Controls.SetChildIndex(this.Title, 0);
            this.Controls.SetChildIndex(this.Clear_BTN, 0);
            this.Controls.SetChildIndex(this.AddRecord_BTN, 0);
            this.Controls.SetChildIndex(this.First_BTN, 0);
            this.Controls.SetChildIndex(this.Back_BTN, 0);
            this.Controls.SetChildIndex(this.Next_BTN, 0);
            this.Controls.SetChildIndex(this.Last_BTN, 0);
            this.Controls.SetChildIndex(this.Update_BTN, 0);
            this.Controls.SetChildIndex(this.Cancel_BTN, 0);
            this.Controls.SetChildIndex(this.Save_BTN, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.Search_BTN, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.FirstName_Input_string_2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.LastName_Input_string_3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Address_Input_string_4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.City_Input_string_5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.BirthDate_Input_address_6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.PhoneNumber_Input_string_7, 0);
            this.Controls.SetChildIndex(this.StudentID_Label, 0);
            this.Controls.SetChildIndex(this.TeacherID_Input_string_1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox TeacherID_Input_string_1;
        private System.Windows.Forms.Label StudentID_Label;
        private System.Windows.Forms.TextBox PhoneNumber_Input_string_7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker BirthDate_Input_address_6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox City_Input_string_5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Address_Input_string_4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName_Input_string_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName_Input_string_2;
        private System.Windows.Forms.Label label1;
    }
}