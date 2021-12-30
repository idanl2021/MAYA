using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdanLalezari326643269.CONTROLS
{
    public partial class LogInTextBox : UserControl
    {
        public string placeholder = "";
        private string text;
        public string Text
        {
            get => text;
            set
            {
                TextBox.Text = value;
                text = value;
            }

        }
        public LogInTextBox()
        {
            InitializeComponent();
            TextBox.GotFocus += RemoveText;
            TextBox.LostFocus += AddText;
        }

        private void LogInTextBox_Load(object sender, EventArgs e)
        {
            TextBox.GotFocus += RemoveText;
            TextBox.LostFocus += AddText;
            TextBox.Text = placeholder;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == placeholder)
            {
                TextBox.Text = "";
            }
            this.ActiveControl = TextBox;
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (TextBox.Text == placeholder)
            {
                TextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox.Text))
            {
                TextBox.Text = placeholder;
                TextBox.ForeColor = Color.Gray;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox.Text))
            {
                TextBox.Text = placeholder;
                TextBox.ForeColor = Color.Red;
            }
        }
    }
}
