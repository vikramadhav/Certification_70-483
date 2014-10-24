using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumerableTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Build and display a tree.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Build the tree.
            TreeNode president = new TreeNode("President");
            TreeNode sales = president.AddChild("VP Sales");
            sales.AddChild("Domestic Sales");
            sales.AddChild("International Sales");
            sales.AddChild("Sales Partners");
            TreeNode production = president.AddChild("VP Production");
            production.AddChild("CA Plant");
            production.AddChild("HI Plant");
            production.AddChild("NY Plant");
            production.AddChild("Overseas Production");
            TreeNode marketing = president.AddChild("VP Marketing");
            marketing.AddChild("Television");
            marketing.AddChild("Print Media");
            marketing.AddChild("Electronic Marketing");

            // Display the tree.
            string text = "";
            IEnumerator<TreeNode> enumerator = president.GetEnumerator();
            while (enumerator.MoveNext())
                text += new string(' ', 4 * enumerator.Current.Depth) +
                    enumerator.Current.Text +
                    Environment.NewLine;
            text = text.Substring(0, text.Length - Environment.NewLine.Length);
            treeTextBox.Text = text;
            treeTextBox.Select(0, 0);
        }
    }
}
