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
    public partial class SearchRowForm : Form
    {
        public string rowValue { get { return searchRow.Text; } }
        public string strValue { get { return strToSearchRow.Text; } }
        public SearchRowForm()
        {
            InitializeComponent();
        }

        private void submitSearchRow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
