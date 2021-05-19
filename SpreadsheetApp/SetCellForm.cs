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
    public partial class SetCellForm : Form
    {
        

        public string rowValue { get { return row.Text; } }
        public string columnValue { get { return column.Text; } }
        public string strValue { get { return str.Text; } }
        public SetCellForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
