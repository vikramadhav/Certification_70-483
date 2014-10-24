using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Demonstrate some features of the finally block.
        private void testFinallyButton_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();

            NoException();

            CaughtException();

            try
            {
                UnCaughtException();
            }
            catch
            {
            }

            try
            {
                CatchThrowsException();
            }
            catch
            {
            }

            TryReturns();

            CatchReturns();
        }

        // Try block has no exception.
        private void NoException()
        {
            try
            {
                resultListBox.Items.Add("NoException try");
            }
            catch
            {
                resultListBox.Items.Add("NoException catch");
            }
            finally
            {
                resultListBox.Items.Add("NoException finally");
            }
        }

        // Try block has an exception that is caught by a catch block.
        private void CaughtException()
        {
            try
            {
                resultListBox.Items.Add("CaughtException try");
                throw new ArgumentException("Invalid argument.");
            }
            catch
            {
                resultListBox.Items.Add("CaughtException catch");
            }
            finally
            {
                resultListBox.Items.Add("CaughtException finally");
            }
        }

        // Try block has an exception that is not caught by a catch block.
        private void UnCaughtException()
        {
            try
            {
                resultListBox.Items.Add("UnCaughtException try");
                throw new ArgumentException("Invalid argument.");
            }
            catch (FormatException)
            {
                resultListBox.Items.Add("UnCaughtException catch");
            }
            finally
            {
                resultListBox.Items.Add("UnCaughtException finally");
            }
        }

        // Try block has an exception that is caught by a catch block
        // and the catch block throws another exception.
        private void CatchThrowsException()
        {
            try
            {
                resultListBox.Items.Add("CatchThrowsException try");
                throw new ArgumentException("Invalid argument.");
            }
            catch (ArgumentException)
            {
                resultListBox.Items.Add("CatchThrowsException catch");
                throw new FormatException("Invalid format.");
            }
            finally
            {
                resultListBox.Items.Add("CatchThrowsException finally");
            }
        }

        // Try block uses a return statement.
        private void TryReturns()
        {
            try
            {
                resultListBox.Items.Add("TryReturns try");
                return;
            }
            catch
            {
                resultListBox.Items.Add("TryReturns catch");
            }
            finally
            {
                resultListBox.Items.Add("TryReturns finally");
            }
        }

        // Catch block uses a return statement.
        private void CatchReturns()
        {
            try
            {
                resultListBox.Items.Add("CatchReturns try");
                throw new ArgumentException("Invalid argument.");
            }
            catch
            {
                resultListBox.Items.Add("CatchReturns catch");
                return;
            }
            finally
            {
                resultListBox.Items.Add("CatchReturns finally");
            }
        }
    }
}
