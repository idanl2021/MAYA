using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdanLalezari326643269.CONTROLS
{
    public partial class NavButton : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Test text displayed in the textbox"), Category("Data"),Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public string Text
        {
            get => NavLabel.Text;
            set => NavLabel.Text = value;
        }

        public NavButton()
        {
            InitializeComponent();
        }

        private void NavButton_Load(object sender, EventArgs e)
        {
            NavLabel.Text = Text;
        }

        private void NavLabel_Click(object sender, EventArgs e)
        {

        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked!");
        }

        

        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void NavLabel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void NavLabel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void NavLabel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
