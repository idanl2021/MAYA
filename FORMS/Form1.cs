using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdanLalezari326643269.FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.idanLalezari326643269DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'idanLalezari326643269DataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.idanLalezari326643269DataSet.Students);

        }

        private void studentsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
