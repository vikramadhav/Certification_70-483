using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncLambdas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The number of times we have run DoSomethingAsync.
        private int Trials = 0;

        // Create an event handler for the button.
        private void Form1_Load(object sender, EventArgs e)
        {
            runAsyncButton.Click += async (button, buttonArgs) =>
            {
                int trial = ++Trials;
                statusLabel.Text = "Running trial " + trial.ToString() + "...";
                await DoSomethingAsync();
                statusLabel.Text = "Done with trial " + trial.ToString();
            };
        }

        // Do something time consuming.
        async Task DoSomethingAsync()
        {
            // In this example, just waste some time.
            await Task.Delay(3000);
        }
    }
}
