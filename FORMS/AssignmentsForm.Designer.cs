namespace IdanLalezari326643269.FORMS
{
    partial class AssignmentsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AssignmentID_Input_string_1 = new System.Windows.Forms.TextBox();
            this.Type_Input_string_2 = new System.Windows.Forms.ComboBox();
            this.Deadline_Input_address_3 = new System.Windows.Forms.DateTimePicker();
            this.LessonID_Input_string_4 = new System.Windows.Forms.TextBox();
            this.Weight_Input_string_5 = new System.Windows.Forms.TextBox();
            this.lessons_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lessons_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(831, 15);
            this.Title.Size = new System.Drawing.Size(69, 25);
            this.Title.Text = "מטלות";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "לפי סוג",
            "לפי תז שיעור",
            "לפי תאריך הגשה"});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(865, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "סוג";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "תאריך הגשה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(836, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "תז שיעור";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "משקל";
            // 
            // AssignmentID_Input_string_1
            // 
            this.AssignmentID_Input_string_1.Location = new System.Drawing.Point(696, 250);
            this.AssignmentID_Input_string_1.Name = "AssignmentID_Input_string_1";
            this.AssignmentID_Input_string_1.Size = new System.Drawing.Size(100, 20);
            this.AssignmentID_Input_string_1.TabIndex = 55;
            this.AssignmentID_Input_string_1.Visible = false;
            // 
            // Type_Input_string_2
            // 
            this.Type_Input_string_2.FormattingEnabled = true;
            this.Type_Input_string_2.Items.AddRange(new object[] {
            "מטלה",
            "מבחן"});
            this.Type_Input_string_2.Location = new System.Drawing.Point(693, 108);
            this.Type_Input_string_2.Name = "Type_Input_string_2";
            this.Type_Input_string_2.Size = new System.Drawing.Size(103, 21);
            this.Type_Input_string_2.TabIndex = 56;
            // 
            // Deadline_Input_address_3
            // 
            this.Deadline_Input_address_3.Location = new System.Drawing.Point(596, 139);
            this.Deadline_Input_address_3.Name = "Deadline_Input_address_3";
            this.Deadline_Input_address_3.Size = new System.Drawing.Size(200, 20);
            this.Deadline_Input_address_3.TabIndex = 57;
            // 
            // LessonID_Input_string_4
            // 
            this.LessonID_Input_string_4.Location = new System.Drawing.Point(696, 168);
            this.LessonID_Input_string_4.Name = "LessonID_Input_string_4";
            this.LessonID_Input_string_4.Size = new System.Drawing.Size(100, 20);
            this.LessonID_Input_string_4.TabIndex = 58;
            // 
            // Weight_Input_string_5
            // 
            this.Weight_Input_string_5.Location = new System.Drawing.Point(696, 205);
            this.Weight_Input_string_5.Name = "Weight_Input_string_5";
            this.Weight_Input_string_5.Size = new System.Drawing.Size(100, 20);
            this.Weight_Input_string_5.TabIndex = 59;
            // 
            // lessons_dgv
            // 
            this.lessons_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessons_dgv.Location = new System.Drawing.Point(53, 75);
            this.lessons_dgv.Name = "lessons_dgv";
            this.lessons_dgv.Size = new System.Drawing.Size(240, 276);
            this.lessons_dgv.TabIndex = 60;
            this.lessons_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lessons_dgv_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "הזנת ציונים";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lessons_dgv);
            this.Controls.Add(this.Weight_Input_string_5);
            this.Controls.Add(this.LessonID_Input_string_4);
            this.Controls.Add(this.Deadline_Input_address_3);
            this.Controls.Add(this.Type_Input_string_2);
            this.Controls.Add(this.AssignmentID_Input_string_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignmentsForm";
            this.Text = "AssignmentsForm";
            this.Load += new System.EventHandler(this.AssignmentsForm_Load);
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
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.AssignmentID_Input_string_1, 0);
            this.Controls.SetChildIndex(this.Type_Input_string_2, 0);
            this.Controls.SetChildIndex(this.Deadline_Input_address_3, 0);
            this.Controls.SetChildIndex(this.LessonID_Input_string_4, 0);
            this.Controls.SetChildIndex(this.Weight_Input_string_5, 0);
            this.Controls.SetChildIndex(this.lessons_dgv, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.lessons_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AssignmentID_Input_string_1;
        private System.Windows.Forms.ComboBox Type_Input_string_2;
        private System.Windows.Forms.DateTimePicker Deadline_Input_address_3;
        private System.Windows.Forms.TextBox LessonID_Input_string_4;
        private System.Windows.Forms.TextBox Weight_Input_string_5;
        private System.Windows.Forms.DataGridView lessons_dgv;
        private System.Windows.Forms.Button button1;
    }
}