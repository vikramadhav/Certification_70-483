using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
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

namespace WPFAsyncApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private async void btnRun_Click(object sender, EventArgs e) {
            await GetDataAsync();
        }

        private async Task GetDataAsync() {
            var task1 = Utils.CommonFunctions.ReadDataFromIOAsync();
            var task2 = Utils.CommonFunctions.ReadDataFromIOAsync();

            // await Task.WhenAll(task1, task2);

            lblResult.Content = await task1;
            lblResult2.Content = await task2;
        }

    }
}
