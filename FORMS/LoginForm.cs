using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdanLalezari326643269.DATA;
using IdanLalezari326643269.UTILITIES;

using MetroFramework;

namespace IdanLalezari326643269.FORMS
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private bool isPasswordVisible = false;


        public LoginForm()
        {
            InitializeComponent();
            
        }

        

        private void ID_textbox_Click(object sender, EventArgs e)
        {
            //FormUtilities.Placeholder.RemoveText(ID_textbox, "Enter ID...");
        }

        private void ID_textbox_Leave(object sender, EventArgs e)
        {
            FormUtilities.Placeholder.AddText(ID_textbox, "Enter ID...");
        }

        private void Password_textbox_Click(object sender, EventArgs e)
        {
            //FormUtilities.Placeholder.RemoveText(Password_textbox, "Enter Password...");
        }

        private void Password_textbox_Leave(object sender, EventArgs e)
        {
            if (Password_textbox.Text == "")
            {
                Password_textbox.UseSystemPasswordChar = false; 
            }
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
            if (Password_textbox.Text == "Enter Password...")
            {
                Password_textbox.UseSystemPasswordChar = true;  
            }
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

        /// <summary>
        /// Press The Login Button.
        /// </summary>
        private void LogInButton()
        {
            Form frm = null;
            DataTable dt = DAL.OpenTable("SELECT * FORM Users WHERE ID = '" + ID_textbox.Text + "' AND Password = '" + Password_textbox.Text + "'");
            List<DataRow> list = dt.AsEnumerable().ToList();
            if (list.Count != 1) throw new Exception("Wrong size of rows");
            string group = list[0]["Group"].ToString();

            switch (group)
            {
                case "Principal":
                    frm = new ManagerMainForm();
                    break;
                default:
                    break;
            }
            if (frm != null)
            {
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide(); 
            }


            //if (ID_textbox.Text == "admin" && Password_textbox.Text == "admin")
            //{
            //    //MessageBox.Show("Hello World!");
            //    var frm = new ManagerMainForm();
            //    frm.Location = this.Location;
            //    frm.StartPosition = FormStartPosition.Manual;
            //    frm.FormClosing += delegate { this.Show(); };
            //    frm.Show();
            //    this.Hide();
            //}

        }

        private void Password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInButton();
            }
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

        private void VisibilityImgBox_Click(object sender, EventArgs e)
        {
            ChangePasswordVisibility();
        }

        private void ChangePasswordVisibility()
        {
            if(Password_textbox.Text == "Enter Password...")
            {
                return;
            }
            try
            {
                if (isPasswordVisible)
                {
                    Password_textbox.UseSystemPasswordChar = true;
                    VisibilityImgBox.Image = IdanLalezari326643269.Properties.Resources.outline_visibility_off_black_24dp;
                }
                else
                {
                    //string text = String.Copy(Password_textbox.Text);
                    Password_textbox.UseSystemPasswordChar = false;
                    //Password_textbox.Text = String.Copy(text);
                    VisibilityImgBox.Image = IdanLalezari326643269.Properties.Resources.outline_visibility_black_24dp;
                }
                isPasswordVisible = !isPasswordVisible;
            }
            catch (Exception)
            {
                LOGGER.Logger.PrintLog("error in ChangePasswordVisibility() func", ENUM.Enums.LogType.Error);
            }
        }

        private void VisibilityImgBox_MouseMove(object sender, MouseEventArgs e)
        {
            VisibilityImgBox.Cursor = Cursors.Hand;
        }
    }

}
