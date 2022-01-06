namespace IdanLalezari326643269.CONTROLS
{
    partial class NavButton
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
            this.NavLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NavLabel
            // 
            this.NavLabel.AutoSize = true;
            this.NavLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NavLabel.Location = new System.Drawing.Point(96, 13);
            this.NavLabel.Name = "NavLabel";
            this.NavLabel.Size = new System.Drawing.Size(42, 20);
            this.NavLabel.TabIndex = 0;
            this.NavLabel.Text = "label";
            this.NavLabel.Click += new System.EventHandler(this.NavLabel_Click);
            this.NavLabel.MouseEnter += new System.EventHandler(this.NavLabel_MouseEnter);
            this.NavLabel.MouseLeave += new System.EventHandler(this.NavLabel_MouseLeave);
            this.NavLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavLabel_MouseMove);
            // 
            // NavButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.NavLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NavButton";
            this.Size = new System.Drawing.Size(174, 44);
            this.Load += new System.EventHandler(this.NavButton_Load);
            this.Click += new System.EventHandler(this.NavButton_Click);
            this.MouseEnter += new System.EventHandler(this.NavButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NavButton_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NavLabel;
    }
}
