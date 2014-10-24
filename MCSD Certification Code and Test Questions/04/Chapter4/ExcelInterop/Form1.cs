using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add a COM reference to:
//      Microsoft Excel 14.0 Object Library
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelInterop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Open the Excel application.
            Excel._Application excelApp = new Excel.Application();

            // Add a workbook.
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet sheet = workbook.Worksheets[1];

            // Display Excel.
            excelApp.Visible = true;

            // Display some column headers.
            sheet.Cells[1, 1].Value = "Value";
            sheet.Cells[1, 2].Value = "Value Squared";

            // Display the first 10 squares.
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i + 1, 1].Value = i;
                sheet.Cells[i + 1, 2].Value = (i * i).ToString();
            }

            // Autofit the columns.
            sheet.Columns[1].AutoFit();
            sheet.Columns[2].AutoFit();
        }
    }
}
