using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            Stopwatch sw = new Stopwatch();
            sw = Stopwatch.StartNew();
            double integral = trapeze.Count(n,a,b,(x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            sw.Stop();
            if (integral == 0.0)
            { 
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(trapeze.ErrorInfo, caption);
            }
            else
            {
                tbt.Text = Convert.ToString(integral);
                lbltposl.Text = Convert.ToString(sw.ElapsedMilliseconds + " мс");
            }
        }

        private void Bts_Click(object sender, EventArgs e)
        {
            Simpson simp = new Simpson();
            int n = Convert.ToInt32(tbn.Text);
            double a = Convert.ToDouble(tba.Text);
            double b = Convert.ToDouble(tbb.Text);
            Stopwatch sw = new Stopwatch();
            sw = Stopwatch.StartNew();
            double integral = simp.Count(n, a, b,(x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            sw.Stop();
            if (integral == 0.0)
            {
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(simp.ErrorInfo, caption);
            }
            else
            {
                tbs.Text = Convert.ToString(integral);
                lbltposl.Text = Convert.ToString(sw.ElapsedMilliseconds + " мс");
            }
        }

        private void Btf_Click(object sender, EventArgs e)
        {
            pbf.Image = Properties.Resources.Jabuz;
        }

        private void Bttp_Click(object sender, EventArgs e)
        {
            Trap trapeze = new Trap();
            int n = Convert.ToInt32(tbn.Text);
            int a = Convert.ToInt32(tba.Text);
            int b = Convert.ToInt32(tbb.Text);
            Stopwatch sw = new Stopwatch();
            sw = Stopwatch.StartNew();
            double integral = trapeze.PCount(n, a, b, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            sw.Stop();
          
            if (integral == 0.0)
            {
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(trapeze.ErrorInfo, caption);
            }
            else
            {
                tbt.Text = Convert.ToString(integral);
                lbltpar.Text = Convert.ToString(sw.ElapsedMilliseconds + " мс");
            }
        }

        private void Btsp_Click(object sender, EventArgs e)
        {
            Simpson simp = new Simpson();
            int n = Convert.ToInt32(tbn.Text);
            int a = Convert.ToInt32(tba.Text);
            int b = Convert.ToInt32(tbb.Text);
            Stopwatch sw = new Stopwatch();
            sw = Stopwatch.StartNew();
            double integral = simp.PCount(n, a, b, (x) =>
            {
                return (32 * x) - Math.Log(2 * x) - 41;
            });
            sw.Stop();
            if (integral == 0.0)
            {
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(simp.ErrorInfo, caption);
            }
            else
            {
                tbs.Text = Convert.ToString(integral);
                lbltpar.Text = Convert.ToString(sw.ElapsedMilliseconds + " мс");
            }
        }
    }
}
