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
