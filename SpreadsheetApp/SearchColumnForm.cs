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
    public partial class SearchColumnForm : Form
    {
        public string columnValue { get { return searchCol.Text; } }
        public string strValue { get { return strToSearchCol.Text; } }
        public SearchColumnForm()
        {
            InitializeComponent();
        }

        private void SubmitSearchCol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
