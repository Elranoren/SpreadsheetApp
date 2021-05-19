﻿using System;
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
    public partial class GetCellForm : Form
    {
        public string rowValue { get { return row.Text; } }
        public string columnValue { get { return col.Text; } }
        public GetCellForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
