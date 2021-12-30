using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IdanLalezari326643269.UTILITIES;

using MetroFramework;

namespace IdanLalezari326643269.FORMS
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void logInTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ID_textbox_Click(object sender, EventArgs e)
        {
            FormUtilities.Placeholder.RemoveText(ID_textbox, "Enter ID...");
        }

        private void ID_textbox_Leave(object sender, EventArgs e)
        {
            FormUtilities.Placeholder.AddText(ID_textbox, "Enter ID...");
        }

        private void Password_textbox_Click(object sender, EventArgs e)
        {
            FormUtilities.Placeholder.RemoveText(Password_textbox, "Enter Password...");
        }

        private void Password_textbox_Leave(object sender, EventArgs e)
        {
            FormUtilities.Placeholder.AddText(Password_textbox, "Enter Password...");
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            LogInButton();
        }

        private void ID_textBoxGotFocus(object sender, EventArgs e)
        {
            FormUtilities.Placeholder.RemoveText(ID_textbox, "Enter ID...");
        }

        private void Password_textBoxGotFocus(object sender, EventArgs e)
        {
            FormUtilities.Placeholder.RemoveText(Password_textbox, "Enter Password...");
        }

        private void Password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ID_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LogInButton();
            }
        }

        private void LogInButton()
        {
            if (ID_textbox.Text == "admin" && Password_textbox.Text == "admin")
            {
                MessageBox.Show("Hello World!");
                var frm = new StudentsForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            
        }

        private void Password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInButton();
            }
        }
    }
}
