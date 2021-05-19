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
    public partial class SearchRangeForm : Form
    {
        public string FromRow { get { return fromRow.Text; } }
        public string ToRow { get { return toRow.Text; } }
        public string FromCol { get { return fromCol.Text; } }
        public string ToCol { get { return toCol.Text; } }
        public string strRangeVal { get { return strRange.Text; } }
        public SearchRangeForm()
        {
            InitializeComponent();
        }

        private void submitRange_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchRangeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
