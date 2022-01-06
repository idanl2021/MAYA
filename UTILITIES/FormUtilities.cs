using IdanLalezari326643269.FORMS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdanLalezari326643269.UTILITIES
{
    class FormUtilities
    {
        /// <summary>
        /// Add T Form to the given panel
        /// </summary>
        /// <typeparam name="T">Form type</typeparam>
        /// <param name="panel"></param>
        public static void AddFormToPanel<T>(Panel panel) where T : Form
        {
            // remove forms from panel
            foreach (Control control in panel.Controls)
            {
                if(control is Form)
                {
                    //panel.Controls.Remove(control);
                    (control as Form).Hide();
                }
            }
            foreach (Control control in panel.Controls)
            {
                if (control is T)
                {
                    //panel.Controls.Remove(control);
                    (control as Form).Show();
                    return;
                }
            }


            //var frm = new StudentsForm() { TopLevel = false, TopMost = true };
            ////frm.FormBorderStyle = (FormBorderStyle)cboFormStyle.SelectedIndex;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //this.mainPanel.Controls.Add(frm);
            //frm.Show();
            T frm = Activator.CreateInstance<T>();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(frm);
            frm.Show();
        }

        public class Placeholder
        {
            public static void AddText(TextBox tb, string placeholder = "")
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            }

            public static void RemoveText(TextBox tb, string placeholder = "")
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            }

        }
    }
}
