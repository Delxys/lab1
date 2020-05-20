using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btCancel.Enabled = false;
        }
        //double integral = 0.0;
        private void Btt_Click(object sender, EventArgs e)
        {
            Btt.Enabled = false;
            btCancel.Enabled = true;
            ResTrap();
        }
        private void Bts_Click(object sender, EventArgs e)
        {
            Bts.Enabled = false;
            btCancel.Enabled = true;
            ResSimpson();
        }
        private void Bttp_Click(object sender, EventArgs e)
        {
            Bttp.Enabled = false;
            btCancel.Enabled = true;
            ResTrapPar();
        }
        private void Btsp_Click(object sender, EventArgs e)
        {
            Btsp.Enabled = false;
            btCancel.Enabled = true;
            ResSimpPar();
        }
        CancellationTokenSource cts;
        private async void ResTrap()
        {
            Trap trapeze = new Trap();
            int n = Convert.ToInt32(tbn.Text);
            double a = Convert.ToDouble(tba.Text);
            double b = Convert.ToDouble(tbb.Text);
            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };
            pgb.Value = 0;

            bool answerReady = true;
            double integral = 0;
            
            try
            {
                stopWatch.Start();
                integral = await trapeze.Count(n, a, b, cts.Token, progress,(x) =>
                {
                   return (32 * x) - Math.Log(2 * x) - 41;
                });
                stopWatch.Stop();
            }
            catch (ArgumentException)
            {
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(caption);
                tbt.Text = "Ошибка";
                answerReady = false;
            }
            catch (OperationCanceledException)
            {
                tbt.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbt.Text = "Ошибка";
                answerReady = false;
            }
            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                tbt.Text = Convert.ToString(integral);
                tbtposl.Text = Convert.ToString(elapsedTime + " мс");
            }
            Btt.Enabled = true;
            btCancel.Enabled = false;
        }

        private async void ResSimpson()
        {
            Simpson simp = new Simpson();
            int n = Convert.ToInt32(tbn.Text);
            double a = Convert.ToDouble(tba.Text);
            double b = Convert.ToDouble(tbb.Text);
            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };
            pgb.Value = 0;

            bool answerReady = true;
            double integral = 0;
            try
            {
                stopWatch.Start();
                integral = await simp.Count(n, a, b, cts.Token, progress, (x) =>
                {
                    return (32 * x) - Math.Log(2 * x) - 41;
                });
                stopWatch.Stop();
            }
            catch (ArgumentException)
            {
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(caption);
                tbs.Text = "Ошибка";
                answerReady = false;
            }
            catch (OperationCanceledException)
            {
                tbs.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbs.Text = "Ошибка";
                answerReady = false;
            }
            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                tbs.Text = Convert.ToString(integral);
                tbtposl.Text = Convert.ToString(elapsedTime + " мс");
            }
            Bts.Enabled = true;
            btCancel.Enabled = false;
        }

        private void Btf_Click(object sender, EventArgs e)
        {
            pbf.Image = Properties.Resources.Jabuz;
        }

        private async void ResTrapPar()
        {
            Trap trapeze = new Trap();
            int n = Convert.ToInt32(tbn.Text);
            int a = Convert.ToInt32(tba.Text);
            int b = Convert.ToInt32(tbb.Text);
            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };
            pgb.Value = 0;

            bool answerReady = true;
            double integral = 0;
            try
            {
                stopWatch.Start();
                integral =await trapeze.PCount(n, a, b, cts.Token, progress, (x) =>
                {
                    return (32 * x) - Math.Log(2 * x) - 41;
                });
                stopWatch.Stop();
            }
            catch (ArgumentException)
            {
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(caption);
                tbt.Text = "Ошибка";
                answerReady = false;
            }
            catch (OperationCanceledException)
            {
                tbt.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbt.Text = "Отмена";
                answerReady = false;
            }
            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                tbt.Text = Convert.ToString(integral);
                tbtpar.Text = Convert.ToString(elapsedTime + " мс");
            }
            Bttp.Enabled = true;
            btCancel.Enabled = false;
        }

        private async void ResSimpPar()
        {
            Simpson simp = new Simpson();
            int n = Convert.ToInt32(tbn.Text);
            int a = Convert.ToInt32(tba.Text);
            int b = Convert.ToInt32(tbb.Text);
            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };
            pgb.Value = 0;

            bool answerReady = true;
            double integral = 0;
            try
            {
                stopWatch.Start();
                integral =await simp.PCount(n, a, b, cts.Token, progress, (x) =>
                {
                    return (32 * x) - Math.Log(2 * x) - 41;
                });
                stopWatch.Stop();
            }
            catch (ArgumentException)
            {
                string caption = "Ошибка вводимых данных";
                MessageBox.Show(caption);
                tbs.Text = "Ошибка";
                answerReady = false;
            }
            catch (OperationCanceledException)
            {
                tbs.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbs.Text = "Отмена";
                answerReady = false;
            }
            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                tbs.Text = Convert.ToString(integral);
                tbtpar.Text = Convert.ToString(elapsedTime + " мс");
            }
            Btsp.Enabled = true;
            btCancel.Enabled = false;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
    }
}
