
namespace IdanLalezari326643269.CONTROLS
{
    partial class LogInTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.ForeColor = System.Drawing.Color.DarkRed;
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(126, 23);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "placeholder";
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            this.TextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LogInTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Name = "LogInTextBox";
            this.Size = new System.Drawing.Size(133, 25);
            this.Load += new System.EventHandler(this.LogInTextBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextBox;
    }
}
