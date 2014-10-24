using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace WriteToEventLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Write an event log entry.
        private void writeButton_Click(object sender, EventArgs e)
        {
            string source = sourceTextBox.Text;
            string log = logTextBox.Text;
            string message = eventTextBox.Text;
            int id = int.Parse(idTextBox.Text);

            // Create the source if necessary. (Requires admin privileges.)
            if (!EventLog.SourceExists(source))
                EventLog.CreateEventSource(source, log);

            // Write the log entry.
            EventLog.WriteEntry(source, message,
                EventLogEntryType.Information, id);

            MessageBox.Show("OK");
        }
    }
}
