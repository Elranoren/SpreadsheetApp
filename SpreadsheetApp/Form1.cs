using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private SharableSpreadsheet sp;
        private string ChosenSearch { get { return chooseSearch.Text; } }
        private string ChosenExchange { get { return chooseExchange.Text; } }
        public Form1()
        {
            sp = new SharableSpreadsheet(20, 20);
            InitializeComponent();
        }

        private bool loadToGrid()
        {
            spreadSheet.Rows.Clear();
            spreadSheet.Columns.Clear();
            spreadSheet.Refresh();
            int rows = 0, cols = 0;
            this.sp.getSize(ref rows, ref cols);
            ArrayList spread = this.sp.getSpreadSheet();
            for (int j = 0; j < cols; j++)
            {
                spreadSheet.Columns.Add("colID_" + j, j +1+ "");
            }
            for (int i = 0; i < rows; i++)
            {
                spreadSheet.Rows.Add();
                spreadSheet.Rows[i].HeaderCell.Value = i+1+"";
                for (int j = 0; j < cols; j++)
                {
                   spreadSheet[j, i].Value = ((Row)spread[i]).row[j];
                }
            }
            spreadSheet.Refresh();
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = 0, cols = 0;
            sp.getSize(ref rows, ref cols);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    sp.setCell(i, j, "{" + (i + 1) + "," + (j + 1) + "}");
                }
            }
            loadToGrid();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.sp.save("spreadsheet.dat"))
                MessageBox.Show("File was saved successfully!");
            else
                MessageBox.Show("save failed!");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (this.sp.load("spreadsheet.dat"))
            {
                loadToGrid();
                MessageBox.Show("File was loaded successfully!");
            }
            else
                MessageBox.Show("load failed!");
        }

        private void setCellButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetCellForm setCellForm = new SetCellForm();

                if (setCellForm.ShowDialog() != DialogResult.OK)
                {
                    int Row = Int32.Parse(setCellForm.rowValue);
                    int Col = Int32.Parse(setCellForm.columnValue);
                    string s = setCellForm.strValue;
                    if (sp.setCell(Row - 1, Col - 1, s))
                    {
                        loadToGrid();
                        MessageBox.Show("Set cell was successful!");
                    }
                    else
                    {
                        MessageBox.Show("Set Cell failed!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Set Cell failed!");
            }
        }

        private void getCellButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetCellForm getCellForm = new GetCellForm();
                if (getCellForm.ShowDialog() != DialogResult.OK)
                {
                    int Row = Int32.Parse(getCellForm.rowValue);
                    int Col = Int32.Parse(getCellForm.columnValue);
                    string s = sp.getCell(Row - 1, Col - 1);
                    if (s != null)
                    {
                        if (s != "")
                            MessageBox.Show("Get cell was successful! Your String is: " + s);
                        else
                            MessageBox.Show("Get cell was successful! Your String is empty");
                    }
                    else
                        MessageBox.Show("Get Cell failed!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Get Cell failed!");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form searchForm;
            int row = 0, col = 0;
            if (ChosenSearch.Equals("Search Spreadsheet"))
            {
                searchForm = new SearchSpreadsheetForm();
                if (searchForm.ShowDialog() != DialogResult.OK)
                {
                    string str = ((SearchSpreadsheetForm)searchForm).strValue;
                    if (sp.searchString(str, ref row, ref col))
                    {
                        MessageBox.Show("Search String was successful! The Searched String is in Row " + (row + 1) + " and column " + (col + 1));
                    }
                    else
                        MessageBox.Show("Your String is Not in this Spreadsheet!");
                }

            }
            else if (ChosenSearch.Equals("Search in Row"))
            {
                searchForm = new SearchRowForm();
                if (searchForm.ShowDialog() != DialogResult.OK)
                {
                    try
                    {
                        row = Int32.Parse(((SearchRowForm)searchForm).rowValue);
                        string str = ((SearchRowForm)searchForm).strValue;
                        if (sp.searchInRow(row - 1, str, ref col))
                        {
                            MessageBox.Show("Search String in a Row was successful! The Searched String is in Row " + row + " and column " + (col + 1));
                        }
                        else
                            MessageBox.Show("Your String is Not in this Row in the Spreadsheet!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Valid Row Number!");
                    }
                }
            }
            else if (ChosenSearch.Equals("Search in Column"))
            {
                searchForm = new SearchColumnForm();
                if (searchForm.ShowDialog() != DialogResult.OK)
                {
                    try
                    {
                        col = Int32.Parse(((SearchColumnForm)searchForm).columnValue);
                        string str = ((SearchColumnForm)searchForm).strValue;
                        if (sp.searchInCol(col - 1, str, ref row))
                        {
                            MessageBox.Show("Search String in a Column was successful! The Searched String is in Row " + (row + 1) + " and column " + col);
                        }
                        else
                            MessageBox.Show("Your String is Not in this Column in the Spreadsheet!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Valid Column Number!");
                    }
                }
            }
            else if (ChosenSearch.Equals("Search in Range"))
            {
                searchForm = new SearchRangeForm();
                if (searchForm.ShowDialog() != DialogResult.OK)
                {
                    try
                    {
                        int fromRow = Int32.Parse(((SearchRangeForm)searchForm).FromRow);
                        int toRow = Int32.Parse(((SearchRangeForm)searchForm).ToRow);
                        int fromCol = Int32.Parse(((SearchRangeForm)searchForm).FromCol);
                        int toCol = Int32.Parse(((SearchRangeForm)searchForm).ToCol);
                        string str = ((SearchRangeForm)searchForm).strRangeVal;
                        if (sp.searchInRange(fromCol - 1, toCol - 1, fromRow - 1, toRow - 1, str, ref row, ref col))
                        {
                            MessageBox.Show("Search String in a Range was successful! The Searched String is in Row " + (row + 1) + " and column " + (col + 1));
                        }
                        else
                            MessageBox.Show("Your String is Not in this Range in the Spreadsheet!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Valid Rows and Columns Numbers!");
                    }
                }
            }
            else
                MessageBox.Show("Please Choose one of the options!");
            chooseSearch.Text = "Choose Search";
        }

        private void exButton_Click(object sender, EventArgs e)
        {
            Form exchangeForm;
            int first, second;
            if (ChosenExchange.Equals("Exchange Rows"))
            {
                exchangeForm = new ExchangeRowsForm();
                if (exchangeForm.ShowDialog() != DialogResult.OK)
                {
                    try
                    {
                        first = Int32.Parse(((ExchangeRowsForm)exchangeForm).FirstRow);
                        second = Int32.Parse(((ExchangeRowsForm)exchangeForm).SecondRow);
                        if (sp.exchangeRows(first - 1, second - 1))
                        {
                            loadToGrid();
                            MessageBox.Show("Exchange Rows Was Successful! Rows " + first + " and " + second);
                        }
                        else
                            MessageBox.Show("Exchange Rows Failed!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Valid Rows Numbers!");
                    }
                }

            }
            else if (ChosenExchange.Equals("Exchange Columns"))
            {
                exchangeForm = new ExchangeColumnsForm();
                if (exchangeForm.ShowDialog() != DialogResult.OK)
                {
                    try
                    {
                        first = Int32.Parse(((ExchangeColumnsForm)exchangeForm).FirstCol);
                        second = Int32.Parse(((ExchangeColumnsForm)exchangeForm).SecondCol);
                        if (sp.exchangeCols(first - 1, second - 1))
                        {
                            loadToGrid();
                            MessageBox.Show("Exchange Rows Was Successful! Columns " + first + " and " + second);
                        }
                        else
                            MessageBox.Show("Exchange Columns Failed!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Valid Columns Numbers!");
                    }
                }
            }
            else
                MessageBox.Show("Please Choose one of the options!");
            chooseExchange.Text = "Choose Exchange";
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = Int32.Parse(rowPos.Text);
                if (sp.addRow(row - 1))
                {
                    loadToGrid();
                    MessageBox.Show("Add Row Was Successful! New Row was Entered after Row Number " + row);
                }
                else
                    MessageBox.Show("Add Row Failed!");
                rowPos.Text = "Insert after Row";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Valid Row Number!");
            }
        }

        private void addColButton_Click(object sender, EventArgs e)
        {
            try
            {
                int col = Int32.Parse(colPos.Text);
                if (sp.addCol(col - 1))
                {
                    loadToGrid();
                    MessageBox.Show("Add Column Was Successful! New Row was Entered after Column Number " + col);
                }
                else
                    MessageBox.Show("Add Column Failed!");
                colPos.Text = "Insert after Column";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Valid Column Number!");
            }
        }
    }
}
