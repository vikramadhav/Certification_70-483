using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private BackgroundWorker _worker;

        public MainWindow() {
            InitializeComponent();
            _worker = new BackgroundWorker();
            _worker.DoWork += _worker_DoWork;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
        }

        void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {

            // lblResult.Content = e.Result;
            // Instead of updating the UI directly we call Dispatcher.Invoke
            this.Dispatcher.Invoke(() => lblResult.Content = e.Result);
        }

        void _worker_DoWork(object sender, DoWorkEventArgs e) {

            e.Result = Utils.CommonFunctions.DoIntensiveCalculations();
        }

        private void btnRun_Click(object sender, EventArgs e) {
            if (!_worker.IsBusy) {
                _worker.RunWorkerAsync();
                // Comment the previous line and uncomment the line below to kick of the worker from onather thread.
                // new Thread(() => _worker.RunWorkerAsync()) { Name = "RunWorkThread" }.Start();
            }
        }
    }
}
