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
    public partial class ExchangeRowsForm : Form
    {
        public string FirstRow { get { return firstRow.Text; } }
        public string SecondRow { get { return secondRow.Text; } }
        public ExchangeRowsForm()
        {
            InitializeComponent();
        }

        private void submitExRows_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
