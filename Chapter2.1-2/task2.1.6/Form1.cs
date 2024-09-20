using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2._1._6
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bw;

        public Form1()
        {
            InitializeComponent();
            this.bw = new BackgroundWorker();
            this.bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            this.bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            this.bw.WorkerReportsProgress = true;

            this.button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.bw.IsBusy)
            {
                this.bw.RunWorkerAsync();
                this.button1.Enabled = false;
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            this.label1.Text = "The answer is: " + e.Result.ToString();
            this.button1.Enabled = true;
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // this.label1.Text = e.ProgressPercentage.ToString() + "% complete";
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            for (int i = 0; i < 100; ++i)
            {
                // report your progres
                worker.ReportProgress(i);

                // pretend like this a really complex calculation going on eating up CPU time
                System.Threading.Thread.Sleep(100);
                //isPrime(i * 2137);
            }
            e.Result = "42";
        }

        bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t => 
            {
                for (int i = 0; i < 100; ++i)
                {
                    progressBar2.BeginInvoke(new Action(() => { progressBar2.Value = (i); }));
                    button2.BeginInvoke(new Action(() => { button2.Enabled = false; }));
                    Thread.Sleep(100);
                }
                button2.BeginInvoke(new Action(() => { button2.Enabled = true; }));
            }) { IsBackground = true };
            thread.Start();
            
        }
    }
}
    

