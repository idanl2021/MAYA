﻿
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
            this.comboBox1.Location = new System.Drawing.Point(898, 65);
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
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 596);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CLassName_Lable;
        private System.Windows.Forms.TextBox ClassName_Input_string_1;
    }
}