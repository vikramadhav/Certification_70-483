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

namespace WinFormApp {

    public partial class Form1 : Form {

        private BackgroundWorker _worker;

        public Form1() {

            InitializeComponent();

            _worker = new BackgroundWorker();
            _worker.DoWork += _worker_DoWork;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
        }

        void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (this.InvokeRequired) {
                this.Invoke(
                    new Action<string>(UpdateLabel),
                    e.Result.ToString());
            }
            else {
                UpdateLabel(e.Result.ToString());
            }
        }

        private void UpdateLabel(string text) {
            lblResult.Text = text;
        }

        void _worker_DoWork(object sender, DoWorkEventArgs e) {

            e.Result = Utils.CommonFunctions.DoIntensiveCalculations();
        }

        private void btnRun_Click(object sender, EventArgs e) {
            if (!_worker.IsBusy) {
                _worker.RunWorkerAsync();
                // new Thread(() => _worker.RunWorkerAsync()) { Name = "RunWorkThread" }.Start();
            }
        }

    }
}


