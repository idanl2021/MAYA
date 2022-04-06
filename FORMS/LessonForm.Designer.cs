namespace IdanLalezari326643269.FORMS
{
    partial class LessonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LessonID_Input_string_1 = new System.Windows.Forms.TextBox();
            this.LessonName_Input_string_2 = new System.Windows.Forms.TextBox();
            this.TeacherID_Input_string_3 = new System.Windows.Forms.TextBox();
            this.teachers_dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRecord_BTN
            // 
            this.AddRecord_BTN.Click += new System.EventHandler(this.AddRecord_BTN_Click_1);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(816, 14);
            this.Title.Size = new System.Drawing.Size(84, 25);
            this.Title.Text = "שיעורים";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "תז שיעור";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(842, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "שם שיעור";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "תז מורה";
            // 
            // LessonID_Input_string_1
            // 
            this.LessonID_Input_string_1.Location = new System.Drawing.Point(736, 111);
            this.LessonID_Input_string_1.Name = "LessonID_Input_string_1";
            this.LessonID_Input_string_1.Size = new System.Drawing.Size(100, 20);
            this.LessonID_Input_string_1.TabIndex = 54;
            this.LessonID_Input_string_1.Visible = false;
            // 
            // LessonName_Input_string_2
            // 
            this.LessonName_Input_string_2.Location = new System.Drawing.Point(683, 137);
            this.LessonName_Input_string_2.Name = "LessonName_Input_string_2";
            this.LessonName_Input_string_2.Size = new System.Drawing.Size(153, 20);
            this.LessonName_Input_string_2.TabIndex = 55;
            // 
            // TeacherID_Input_string_3
            // 
            this.TeacherID_Input_string_3.Location = new System.Drawing.Point(736, 167);
            this.TeacherID_Input_string_3.Name = "TeacherID_Input_string_3";
            this.TeacherID_Input_string_3.Size = new System.Drawing.Size(100, 20);
            this.TeacherID_Input_string_3.TabIndex = 56;
            // 
            // teachers_dataGridView
            // 
            this.teachers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers_dataGridView.Enabled = false;
            this.teachers_dataGridView.Location = new System.Drawing.Point(53, 111);
            this.teachers_dataGridView.Name = "teachers_dataGridView";
            this.teachers_dataGridView.Size = new System.Drawing.Size(326, 240);
            this.teachers_dataGridView.TabIndex = 57;
            this.teachers_dataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.teachers_dataGridView_RowHeaderMouseDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 58;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(59, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // classes
            // 
            this.classes.FormattingEnabled = true;
            this.classes.Location = new System.Drawing.Point(779, 222);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(121, 21);
            this.classes.TabIndex = 61;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "שייך כיתה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.teachers_dataGridView);
            this.Controls.Add(this.TeacherID_Input_string_3);
            this.Controls.Add(this.LessonName_Input_string_2);
            this.Controls.Add(this.LessonID_Input_string_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LessonForm";
            this.Text = "LessonForm";
            this.Load += new System.EventHandler(this.LessonFrom_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
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
            this.Controls.SetChildIndex(this.LessonID_Input_string_1, 0);
            this.Controls.SetChildIndex(this.LessonName_Input_string_2, 0);
            this.Controls.SetChildIndex(this.TeacherID_Input_string_3, 0);
            this.Controls.SetChildIndex(this.teachers_dataGridView, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.classes, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.teachers_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LessonID_Input_string_1;
        private System.Windows.Forms.TextBox LessonName_Input_string_2;
        private System.Windows.Forms.TextBox TeacherID_Input_string_3;
        private System.Windows.Forms.DataGridView teachers_dataGridView;
        private System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox classes;
        private System.Windows.Forms.Button button2;
    }
}