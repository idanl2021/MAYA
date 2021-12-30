
namespace IdanLalezari326643269.FORMS
{
    partial class LoginForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 176);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "LOGIN";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // ID_textbox
            // 
            this.ID_textbox.ForeColor = System.Drawing.Color.Gray;
            this.ID_textbox.Location = new System.Drawing.Point(24, 86);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(125, 20);
            this.ID_textbox.TabIndex = 3;
            this.ID_textbox.Text = "Enter ID...";
            this.ID_textbox.Click += new System.EventHandler(this.ID_textbox_Click);
            this.ID_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ID_textbox.GotFocus += new System.EventHandler(this.ID_textBoxGotFocus);
            this.ID_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.ID_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // Password_textbox
            // 
            this.Password_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Password_textbox.ForeColor = System.Drawing.Color.Gray;
            this.Password_textbox.Location = new System.Drawing.Point(24, 125);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(125, 20);
            this.Password_textbox.TabIndex = 4;
            this.Password_textbox.Text = "Enter Password...";
            this.Password_textbox.Click += new System.EventHandler(this.Password_textbox_Click);
            this.Password_textbox.GotFocus += new System.EventHandler(this.Password_textBoxGotFocus);
            this.Password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_textbox_KeyDown);
            this.Password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_textbox_KeyPress);
            this.Password_textbox.Leave += new System.EventHandler(this.Password_textbox_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 415);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.metroButton1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
    }
}