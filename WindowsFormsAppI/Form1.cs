using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt1.Text);
            int y = int.Parse(txt2.Text);

            int z = x + y;

            lblresult.Text = z.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();

            lblresult.Text = "0";

            txt1.Focus();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
