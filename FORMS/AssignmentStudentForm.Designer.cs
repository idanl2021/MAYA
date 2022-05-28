namespace IdanLalezari326643269.FORMS
{
    partial class AssignmentStudentForm
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
            this.Title = new System.Windows.Forms.Label();
            this.students_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.grade_label = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.Location = new System.Drawing.Point(568, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(123, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "מטלות לתלמידים";
            // 
            // students_dgv
            // 
            this.students_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_dgv.Location = new System.Drawing.Point(312, 79);
            this.students_dgv.Name = "students_dgv";
            this.students_dgv.Size = new System.Drawing.Size(379, 359);
            this.students_dgv.TabIndex = 3;
            this.students_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.students_dgv_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "בחר.י תלמיד";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "הכנס.י ציון";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 79);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(294, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Location = new System.Drawing.Point(142, 144);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(13, 13);
            this.grade_label.TabIndex = 7;
            this.grade_label.Text = "0";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(115, 264);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 50);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // AssignmentStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.grade_label);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.students_dgv);
            this.Controls.Add(this.Title);
            this.Name = "AssignmentStudentForm";
            this.Text = "AssignmentStudentForm";
            this.Load += new System.EventHandler(this.AssignmentStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView students_dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.Button save_btn;
    }
}