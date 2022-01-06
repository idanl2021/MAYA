
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.VisibilityImgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VisibilityImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // ID_textbox
            // 
            this.ID_textbox.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.ID_textbox, "ID_textbox");
            this.ID_textbox.Name = "ID_textbox";
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
            resources.ApplyResources(this.Password_textbox, "Password_textbox");
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Click += new System.EventHandler(this.Password_textbox_Click);
            this.Password_textbox.GotFocus += new System.EventHandler(this.Password_textBoxGotFocus);
            this.Password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_textbox_KeyDown);
            this.Password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_textbox_KeyPress);
            this.Password_textbox.Leave += new System.EventHandler(this.Password_textbox_Leave);
            // 
            // VisibilityImgBox
            // 
            this.VisibilityImgBox.Image = global::IdanLalezari326643269.Properties.Resources.outline_visibility_off_black_24dp;
            resources.ApplyResources(this.VisibilityImgBox, "VisibilityImgBox");
            this.VisibilityImgBox.Name = "VisibilityImgBox";
            this.VisibilityImgBox.TabStop = false;
            this.VisibilityImgBox.Click += new System.EventHandler(this.VisibilityImgBox_Click);
            this.VisibilityImgBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VisibilityImgBox_MouseMove);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VisibilityImgBox);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.metroButton1);
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisibilityImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.PictureBox VisibilityImgBox;
    }
}