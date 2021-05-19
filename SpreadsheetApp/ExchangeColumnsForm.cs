using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadsheetApp
{
    public partial class ExchangeColumnsForm : Form
    {
        public string FirstCol { get { return firstCol.Text; } }
        public string SecondCol { get { return secondCol.Text; } }
        public ExchangeColumnsForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
