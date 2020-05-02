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

        private void Btt_Click(object sender, EventArgs e)
        {
            Trap trapeze = new Trap();
            int n = Convert.ToInt32(tbn.Text);
            double a = Convert.ToDouble(tba.Text);
            double b = Convert.ToDouble(tbb.Text);
            double integral = trapeze.Count(n,a,b);
            tbt.Text = Convert.ToString(integral);
        }

        private void Bts_Click(object sender, EventArgs e)
        {
            Simpson simp = new Simpson();
            int n = Convert.ToInt32(tbn.Text);
            double a = Convert.ToDouble(tba.Text);
            double b = Convert.ToDouble(tbb.Text);
            double integral = simp.Count(n, a, b);
            tbs.Text = Convert.ToString(integral);
        }

        private void Btf_Click(object sender, EventArgs e)
        {
            pbf.Image = Properties.Resources.Jabuz;
        }
    }
}
