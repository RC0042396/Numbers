using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            RichTextBox.AppendText(d1.ToString() + "\n");
            RichTextBox.AppendText(d1.ToString("N") + "\n");
            RichTextBox.AppendText(d1.ToString("N3") + "\n");
            RichTextBox.AppendText(d1.ToString("N0") + "\n");
            RichTextBox.AppendText(d1.ToString("0") + "\n");
            RichTextBox.AppendText(d1.ToString("0.0") + "\n");
            RichTextBox.AppendText(d1.ToString("0.0E0") + "\n");
            RichTextBox.AppendText(d1.ToString("0.00E00") + "\n");

            double pi = 3.141592653589793;
            double c = 299792458;

            RichTextBox.AppendText(pi.ToString("N3") + "\n");
            RichTextBox.AppendText(pi.ToString("N5") + "\n");
            RichTextBox.AppendText(pi.ToString("N15") + "\n");

            RichTextBox.AppendText(c.ToString() + "\n");
            RichTextBox.AppendText(c.ToString("N0") + "\n");
            RichTextBox.AppendText(c.ToString("0.000000000000000E0") + "\n");
            RichTextBox.AppendText(c.ToString("0.000E0") + "\n");




        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
