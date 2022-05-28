namespace IdanLalezari326643269.FORMS
{
    partial class MainFrom_ManagerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfStudents_LBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfStudentsByGender_LBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOfTeachers_LBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numOfClasses_LBL = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.GenderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "בבית הספר יש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // numOfStudents_LBL
            // 
            this.numOfStudents_LBL.AutoSize = true;
            this.numOfStudents_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numOfStudents_LBL.Location = new System.Drawing.Point(850, 79);
            this.numOfStudents_LBL.Name = "numOfStudents_LBL";
            this.numOfStudents_LBL.Size = new System.Drawing.Size(15, 18);
            this.numOfStudents_LBL.TabIndex = 2;
            this.numOfStudents_LBL.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(788, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "תלמידים";
            // 
            // numOfStudentsByGender_LBL
            // 
            this.numOfStudentsByGender_LBL.AutoSize = true;
            this.numOfStudentsByGender_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numOfStudentsByGender_LBL.Location = new System.Drawing.Point(591, 79);
            this.numOfStudentsByGender_LBL.Name = "numOfStudentsByGender_LBL";
            this.numOfStudentsByGender_LBL.Size = new System.Drawing.Size(59, 18);
            this.numOfStudentsByGender_LBL.TabIndex = 4;
            this.numOfStudentsByGender_LBL.Text = "תלמידים";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(802, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "מורים";
            // 
            // numOfTeachers_LBL
            // 
            this.numOfTeachers_LBL.AutoSize = true;
            this.numOfTeachers_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numOfTeachers_LBL.Location = new System.Drawing.Point(850, 128);
            this.numOfTeachers_LBL.Name = "numOfTeachers_LBL";
            this.numOfTeachers_LBL.Size = new System.Drawing.Size(15, 18);
            this.numOfTeachers_LBL.TabIndex = 5;
            this.numOfTeachers_LBL.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(798, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "כיתות";
            // 
            // numOfClasses_LBL
            // 
            this.numOfClasses_LBL.AutoSize = true;
            this.numOfClasses_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numOfClasses_LBL.Location = new System.Drawing.Point(850, 175);
            this.numOfClasses_LBL.Name = "numOfClasses_LBL";
            this.numOfClasses_LBL.Size = new System.Drawing.Size(15, 18);
            this.numOfClasses_LBL.TabIndex = 7;
            this.numOfClasses_LBL.Text = "x";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(30, 29);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 13);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "DATE";
            // 
            // GenderChart
            // 
            this.GenderChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.GenderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GenderChart.Legends.Add(legend1);
            this.GenderChart.Location = new System.Drawing.Point(33, 79);
            this.GenderChart.Name = "GenderChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s_gender";
            this.GenderChart.Series.Add(series1);
            this.GenderChart.Size = new System.Drawing.Size(325, 309);
            this.GenderChart.TabIndex = 10;
            this.GenderChart.Text = "chart1";
            // 
            // MainFrom_ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 595);
            this.Controls.Add(this.GenderChart);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numOfClasses_LBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOfTeachers_LBL);
            this.Controls.Add(this.numOfStudentsByGender_LBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numOfStudents_LBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainFrom_ManagerForm";
            this.Text = "MainFrom_ManagerForm";
            this.Load += new System.EventHandler(this.MainFrom_ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numOfStudents_LBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numOfStudentsByGender_LBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numOfTeachers_LBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numOfClasses_LBL;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenderChart;
    }
}