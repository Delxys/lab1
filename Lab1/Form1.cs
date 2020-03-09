using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btt_Click(object sender, EventArgs e)
        {
            Trap trapeze = new Trap(1,100000);
            int n = Convert.ToInt32(tbn.Text);
            double integral = trapeze.Tr(n);
            tbt.Text = Convert.ToString(integral);
        }

        private void bts_Click(object sender, EventArgs e)
        {
            Simpson simp = new Simpson(1, 100000);
            int n = Convert.ToInt32(tbn.Text);
            double integral = simp.Si(n);
            tbs.Text = Convert.ToString(integral);
        }
    }
}
