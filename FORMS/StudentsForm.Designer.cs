
namespace IdanLalezari326643269.FORMS
{
    partial class StudentsForm: DataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName_Input_string_2 = new System.Windows.Forms.TextBox();
            this.LastName_Input_string_3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassName_Input_string_4 = new System.Windows.Forms.ComboBox();
            this.Address_Input_string_5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.City_Input_string_6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDate_Input_address_7 = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumber_Input_string_8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentID_Label = new System.Windows.Forms.Label();
            this.StudentID_Input_string_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddRecord_BTN
            // 
            this.AddRecord_BTN.Click += new System.EventHandler(this.AddRecord_BTN_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(834, 9);
            this.Title.Size = new System.Drawing.Size(87, 25);
            this.Title.Text = "תלמידים";
            // 
            // First_BTN
            // 
            this.First_BTN.Click += new System.EventHandler(this.First_BTN_Click_1);
            // 
            // Update_BTN
            // 
            this.Update_BTN.Click += new System.EventHandler(this.Update_BTN_Click);
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
            "לפי כיתה",
            "לפי עיר מגורים",
            "לפי תאריך לידה"});
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            // 
            // Search_BTN
            // 
            this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "שם פרטי";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName_Input_string_2
            // 
            this.FirstName_Input_string_2.Location = new System.Drawing.Point(757, 145);
            this.FirstName_Input_string_2.Name = "FirstName_Input_string_2";
            this.FirstName_Input_string_2.Size = new System.Drawing.Size(100, 20);
            this.FirstName_Input_string_2.TabIndex = 52;
            // 
            // LastName_Input_string_3
            // 
            this.LastName_Input_string_3.Location = new System.Drawing.Point(757, 181);
            this.LastName_Input_string_3.Name = "LastName_Input_string_3";
            this.LastName_Input_string_3.Size = new System.Drawing.Size(100, 20);
            this.LastName_Input_string_3.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "שם משפחה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "כיתה";
            // 
            // ClassName_Input_string_4
            // 
            this.ClassName_Input_string_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassName_Input_string_4.FormattingEnabled = true;
            this.ClassName_Input_string_4.Location = new System.Drawing.Point(757, 221);
            this.ClassName_Input_string_4.Name = "ClassName_Input_string_4";
            this.ClassName_Input_string_4.Size = new System.Drawing.Size(100, 21);
            this.ClassName_Input_string_4.TabIndex = 56;
            // 
            // Address_Input_string_5
            // 
            this.Address_Input_string_5.Location = new System.Drawing.Point(545, 115);
            this.Address_Input_string_5.Name = "Address_Input_string_5";
            this.Address_Input_string_5.Size = new System.Drawing.Size(100, 20);
            this.Address_Input_string_5.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "כתובת";
            // 
            // City_Input_string_6
            // 
            this.City_Input_string_6.Location = new System.Drawing.Point(545, 150);
            this.City_Input_string_6.Name = "City_Input_string_6";
            this.City_Input_string_6.Size = new System.Drawing.Size(100, 20);
            this.City_Input_string_6.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "עיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "תאריך לידה";
            // 
            // BirthDate_Input_address_7
            // 
            this.BirthDate_Input_address_7.Location = new System.Drawing.Point(445, 183);
            this.BirthDate_Input_address_7.Name = "BirthDate_Input_address_7";
            this.BirthDate_Input_address_7.Size = new System.Drawing.Size(200, 20);
            this.BirthDate_Input_address_7.TabIndex = 62;
            // 
            // PhoneNumber_Input_string_8
            // 
            this.PhoneNumber_Input_string_8.Location = new System.Drawing.Point(545, 218);
            this.PhoneNumber_Input_string_8.MaxLength = 10;
            this.PhoneNumber_Input_string_8.Name = "PhoneNumber_Input_string_8";
            this.PhoneNumber_Input_string_8.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumber_Input_string_8.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "מספר טלפון";
            // 
            // StudentID_Label
            // 
            this.StudentID_Label.AutoSize = true;
            this.StudentID_Label.Location = new System.Drawing.Point(863, 115);
            this.StudentID_Label.Name = "StudentID_Label";
            this.StudentID_Label.Size = new System.Drawing.Size(67, 13);
            this.StudentID_Label.TabIndex = 65;
            this.StudentID_Label.Text = "תעודת זהות";
            // 
            // StudentID_Input_string_1
            // 
            this.StudentID_Input_string_1.Location = new System.Drawing.Point(757, 112);
            this.StudentID_Input_string_1.Name = "StudentID_Input_string_1";
            this.StudentID_Input_string_1.Size = new System.Drawing.Size(100, 20);
            this.StudentID_Input_string_1.TabIndex = 66;
            this.StudentID_Input_string_1.Leave += new System.EventHandler(this.LeaveKeyTextBox);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 591);
            this.Controls.Add(this.StudentID_Input_string_1);
            this.Controls.Add(this.StudentID_Label);
            this.Controls.Add(this.PhoneNumber_Input_string_8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthDate_Input_address_7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.City_Input_string_6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address_Input_string_5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClassName_Input_string_4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName_Input_string_3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName_Input_string_2);
            this.Controls.Add(this.label1);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
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
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ClassName_Input_string_4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Address_Input_string_5, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.City_Input_string_6, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.BirthDate_Input_address_7, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.PhoneNumber_Input_string_8, 0);
            this.Controls.SetChildIndex(this.StudentID_Label, 0);
            this.Controls.SetChildIndex(this.StudentID_Input_string_1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentID_Input_string_1;
        private System.Windows.Forms.TextBox FirstName_Input_string_2;
        private System.Windows.Forms.TextBox LastName_Input_string_3;
        private System.Windows.Forms.ComboBox ClassName_Input_string_4;
        private System.Windows.Forms.TextBox Address_Input_string_5;
        private System.Windows.Forms.TextBox City_Input_string_6;
        private System.Windows.Forms.DateTimePicker BirthDate_Input_address_7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneNumber_Input_string_8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label StudentID_Label;
        
    }
}