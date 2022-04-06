
namespace IdanLalezari326643269.FORMS
{
    partial class ClassesForm
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
            this.CLassName_Lable = new System.Windows.Forms.Label();
            this.ClassName_Input_string_1 = new System.Windows.Forms.TextBox();
            this.ClassStudents_dataGridView = new System.Windows.Forms.DataGridView();
            this.toStudentsWithShared_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClassStudents_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(837, 9);
            this.Title.Size = new System.Drawing.Size(63, 25);
            this.Title.Text = "כיתות";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(971, 67);
            this.comboBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(713, 66);
            // 
            // Search_BTN
            // 
            this.Search_BTN.Location = new System.Drawing.Point(653, 64);
            // 
            // CLassName_Lable
            // 
            this.CLassName_Lable.AutoSize = true;
            this.CLassName_Lable.Location = new System.Drawing.Point(848, 114);
            this.CLassName_Lable.Name = "CLassName_Lable";
            this.CLassName_Lable.Size = new System.Drawing.Size(52, 13);
            this.CLassName_Lable.TabIndex = 51;
            this.CLassName_Lable.Text = "שם כיתה";
            // 
            // ClassName_Input_string_1
            // 
            this.ClassName_Input_string_1.Location = new System.Drawing.Point(742, 107);
            this.ClassName_Input_string_1.Name = "ClassName_Input_string_1";
            this.ClassName_Input_string_1.Size = new System.Drawing.Size(100, 20);
            this.ClassName_Input_string_1.TabIndex = 52;
            this.ClassName_Input_string_1.TextChanged += new System.EventHandler(this.ClassName_Input_string_1_TextChanged);
            // 
            // ClassStudents_dataGridView
            // 
            this.ClassStudents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassStudents_dataGridView.Location = new System.Drawing.Point(53, 64);
            this.ClassStudents_dataGridView.Name = "ClassStudents_dataGridView";
            this.ClassStudents_dataGridView.Size = new System.Drawing.Size(244, 287);
            this.ClassStudents_dataGridView.TabIndex = 53;
            this.ClassStudents_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassStudents_dataGridView_CellContentClick);
            this.ClassStudents_dataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClassStudents_dataGridView_RowHeaderMouseDoubleClick);
            // 
            // toStudentsWithShared_BTN
            // 
            this.toStudentsWithShared_BTN.Location = new System.Drawing.Point(304, 64);
            this.toStudentsWithShared_BTN.Name = "toStudentsWithShared_BTN";
            this.toStudentsWithShared_BTN.Size = new System.Drawing.Size(75, 23);
            this.toStudentsWithShared_BTN.TabIndex = 54;
            this.toStudentsWithShared_BTN.Text = "לתלמידים";
            this.toStudentsWithShared_BTN.UseVisualStyleBackColor = true;
            this.toStudentsWithShared_BTN.Click += new System.EventHandler(this.toStudentsWithShared_BTN_Click);
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 596);
            this.Controls.Add(this.toStudentsWithShared_BTN);
            this.Controls.Add(this.ClassStudents_dataGridView);
            this.Controls.Add(this.ClassName_Input_string_1);
            this.Controls.Add(this.CLassName_Lable);
            this.Name = "ClassesForm";
            this.Text = "ClassesForm";
            this.Load += new System.EventHandler(this.ClassesForm_Load);
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
            this.Controls.SetChildIndex(this.CLassName_Lable, 0);
            this.Controls.SetChildIndex(this.ClassName_Input_string_1, 0);
            this.Controls.SetChildIndex(this.ClassStudents_dataGridView, 0);
            this.Controls.SetChildIndex(this.toStudentsWithShared_BTN, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ClassStudents_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CLassName_Lable;
        private System.Windows.Forms.TextBox ClassName_Input_string_1;
        private System.Windows.Forms.DataGridView ClassStudents_dataGridView;
        private System.Windows.Forms.Button toStudentsWithShared_BTN;
    }
}