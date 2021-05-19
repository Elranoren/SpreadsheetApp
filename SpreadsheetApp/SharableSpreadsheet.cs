using System;
using System.Collections;
using System.IO;
using System.Threading;

namespace SpreadsheetApp
{
    class SharableSpreadsheet
    {
        private ArrayList spreadSheet;
        private int rows;
        private int columns;
        private Boolean hasNoLimit;
        private int limit;
        private int userCount;
        private Mutex saveLoadMutex;
        private Mutex changeSpreadSheetMutex;

        public SharableSpreadsheet(int nRows, int nCols)
        {
            // construct a nRows*nCols spreadsheet
            this.hasNoLimit = true;
            this.limit = 1;
            this.userCount = 0;
            this.rows = nRows;
            this.columns = nCols;
            this.saveLoadMutex = new Mutex();
            this.changeSpreadSheetMutex = new Mutex();
            this.spreadSheet = new ArrayList();
            for (int i = 0; i < nRows; i++)
            {
                this.spreadSheet.Add(new Row(nCols));
            }
        }

        public ArrayList getSpreadSheet() { return this.spreadSheet; }
        public string getCell(int row, int col)
        {
            //Console.WriteLine("getcell");
            if (row >= this.rows || col >= this.columns || row < 0 || col < 0)
            {
                return null;
            }
            Interlocked.Increment(ref ((Row)spreadSheet[row]).readersCount);
            //if (((Row)spreadSheet[row]).readersCount == 1)
            //    ((Row)spreadSheet[row]).rowMutex.WaitOne();
            while (!((Row)spreadSheet[row]).rowIsFree) ;
            string str = (string)((Row)spreadSheet[row]).row[col];
            Interlocked.Decrement(ref ((Row)spreadSheet[row]).readersCount);
            //if (((Row)spreadSheet[row]).readersCount == 0)
            //    ((Row)spreadSheet[row]).rowMutex.ReleaseMutex();
            return str;
        }
        public bool setCell(int row, int col, string str)
        {
            //Console.WriteLine("setcell");
            if (row >= this.rows || col >= this.columns || row < 0 || col < 0)
            {
                return false;
            }
            changeSpreadSheetMutex.WaitOne(); //check if correct
            ((Row)spreadSheet[row]).rowMutex.WaitOne();
            ((Row)spreadSheet[row]).rowIsFree = false;
            // set the string at [row,col]
            ((Row)spreadSheet[row]).row[col] = str;
            ((Row)spreadSheet[row]).rowMutex.ReleaseMutex();
            ((Row)spreadSheet[row]).rowIsFree = true;
            changeSpreadSheetMutex.ReleaseMutex(); //check if correct
            return true;
        }
        public bool searchString(string str, ref int row, ref int col)
        {
            //Console.WriteLine("searchString");
            while (!hasNoLimit && limit <= userCount) ;
            // search the cell with string str, and return true/false accordingly.
            // stores the location in row,col.
            // return the first cell that contains the string (search from first row to the last row)
            Interlocked.Increment(ref userCount); //Atomic increment
            for (int i = 0; i < this.rows; i++)
            {
                Interlocked.Increment(ref ((Row)spreadSheet[i]).readersCount);
                //if (((Row)spreadSheet[i]).readersCount == 1)
                //    ((Row)spreadSheet[i]).rowMutex.WaitOne();
                while (!((Row)spreadSheet[i]).rowIsFree) ;
                for (int j = 0; j < this.columns; j++)
                {
                    if (str.Equals(((Row)spreadSheet[i]).row[j]))
                    {
                        row = i;
                        col = j;
                        Interlocked.Decrement(ref userCount); //Atomic decrement
                        return true;
                    }
                }
                Interlocked.Decrement(ref ((Row)spreadSheet[i]).readersCount);
                //if (((Row)spreadSheet[i]).readersCount == 0)
                //    ((Row)spreadSheet[i]).rowMutex.ReleaseMutex();
            }
            Interlocked.Decrement(ref userCount); //Atomic decrement
            return false;
        }
        public bool exchangeRows(int row1, int row2)
        {
            //Console.WriteLine("exchangeRows");
            if (row1 >= this.rows || row2 >= this.rows || row1 < 0 || row2 < 0)
            {
                return false;
            }
            // exchange the content of row1 and row2
            changeSpreadSheetMutex.WaitOne(); //check
            ((Row)spreadSheet[row1]).rowMutex.WaitOne();
            ((Row)spreadSheet[row1]).rowIsFree = false;
            ((Row)spreadSheet[row2]).rowMutex.WaitOne();
            ((Row)spreadSheet[row2]).rowIsFree = false;
            Row temp = (Row)spreadSheet[row1];
            spreadSheet[row1] = (Row)spreadSheet[row2];
            spreadSheet[row2] = temp;
            ((Row)spreadSheet[row1]).rowMutex.ReleaseMutex();
            ((Row)spreadSheet[row1]).rowIsFree = true;
            ((Row)spreadSheet[row2]).rowMutex.ReleaseMutex();
            ((Row)spreadSheet[row2]).rowIsFree = true;
            changeSpreadSheetMutex.ReleaseMutex(); //check
            return true;
        }
        public bool exchangeCols(int col1, int col2)
        {
            //Console.WriteLine("ex Cols");
            if (col1 >= this.columns || col2 >= this.columns || col1 < 0 || col2 < 0)
            {
                return false;
            }
            // exchange the content of col1 and col2
            changeSpreadSheetMutex.WaitOne(); //check
            string tempStr;
            for (int i = 0; i < this.rows; i++)
            {
                ((Row)spreadSheet[i]).rowMutex.WaitOne();
                ((Row)spreadSheet[i]).rowIsFree = false;
                tempStr = (string)((Row)spreadSheet[i]).row[col1];
                ((Row)spreadSheet[i]).row[col1] = ((Row)spreadSheet[i]).row[col2];
                ((Row)spreadSheet[i]).row[col2] = tempStr;
                ((Row)spreadSheet[i]).rowMutex.ReleaseMutex();
                ((Row)spreadSheet[i]).rowIsFree = true;
            }
            changeSpreadSheetMutex.ReleaseMutex(); //check
            return true;
        }
        public bool searchInRow(int row, string str, ref int col)
        {
            //Console.WriteLine("searchInRows");
            if (row >= this.rows || row < 0)
            {
                return false;
            }
            while (!hasNoLimit && limit <= userCount) ;
            // perform search in specific row
            Interlocked.Increment(ref userCount);
            Interlocked.Increment(ref ((Row)spreadSheet[row]).readersCount);
            //if (((Row)spreadSheet[row]).readersCount == 1)
            //    ((Row)spreadSheet[row]).rowMutex.WaitOne();
            while (!((Row)spreadSheet[row]).rowIsFree) ;
            for (int i = 0; i < this.columns; i++)
            {
                if (str.Equals(((Row)spreadSheet[row]).row[i]))
                {
                    col = i;
                    Interlocked.Decrement(ref userCount);
                    return true;
                }
            }
            Interlocked.Decrement(ref ((Row)spreadSheet[row]).readersCount);
            //if (((Row)spreadSheet[row]).readersCount == 0)
            //    ((Row)spreadSheet[row]).rowMutex.ReleaseMutex();
            Interlocked.Decrement(ref userCount);
            return false;
        }
        public bool searchInCol(int col, string str, ref int row)
        {
            //Console.WriteLine("searchInCol");
            if (col >= this.columns || col < 0)
            {
                return false;
            }
            while (!hasNoLimit && limit <= userCount) ;
            // perform search in specific col
            Interlocked.Increment(ref userCount);
            for (int i = 0; i < this.rows; i++)
            {
                Interlocked.Increment(ref ((Row)spreadSheet[i]).readersCount);
                //if (((Row)spreadSheet[i]).readersCount == 1)
                //    ((Row)spreadSheet[i]).rowMutex.WaitOne();
                while (!((Row)spreadSheet[row]).rowIsFree) ;
                if (str.Equals(((Row)spreadSheet[i]).row[col]))
                {
                    row = i;
                    Interlocked.Decrement(ref userCount);
                    return true;
                }
                Interlocked.Decrement(ref ((Row)spreadSheet[i]).readersCount);
                //if (((Row)spreadSheet[i]).readersCount == 0)
                //    ((Row)spreadSheet[i]).rowMutex.ReleaseMutex();
            }
            Interlocked.Decrement(ref userCount);
            return false;
        }
        public bool searchInRange(int col1, int col2, int row1, int row2, string str, ref int row, ref int col)
        {
            //Console.WriteLine("searchInRange");
            if (row1 >= this.rows || col1 >= this.columns || row1 < 0 || col1 < 0 ||
                row2 >= this.rows || col2 >= this.columns || row2 < 0 || col2 < 0)
            {
                return false;
            }
            while (!hasNoLimit && limit <= userCount) ;
            // perform search within spesific range: [row1:row2,col1:col2] 
            //includes col1,col2,row1,row2
            Interlocked.Increment(ref userCount);
            for (int i = row1; i <= row2; i++)
            {
                Interlocked.Decrement(ref ((Row)spreadSheet[i]).readersCount);
                //if (((Row)spreadSheet[i]).readersCount == 1)
                //    ((Row)spreadSheet[i]).rowMutex.WaitOne();
                while (!((Row)spreadSheet[i]).rowIsFree) ;
                for (int j = col1; j <= col2; j++)
                {
                    if (str.Equals(((Row)spreadSheet[i]).row[j]))
                    {
                        row = i;
                        col = j;
                        Interlocked.Decrement(ref userCount);
                        return true;
                    }
                }
                Interlocked.Decrement(ref ((Row)spreadSheet[i]).readersCount);
                //if (((Row)spreadSheet[i]).readersCount == 0)
                //    ((Row)spreadSheet[i]).rowMutex.ReleaseMutex();
            }
            Interlocked.Decrement(ref userCount);
            return false;
        }
        public bool addRow(int row1)
        {
            //Console.WriteLine("addRow");
            if (row1 >= this.rows || row1 < 0)
            {
                return false;
            }
            //add a row after row1
            changeSpreadSheetMutex.WaitOne(); //check
            for (int i = row1 + 1; i < rows; i++)
            {
                ((Row)spreadSheet[i]).rowMutex.WaitOne();
                ((Row)spreadSheet[i]).rowIsFree = false;
            }
            Row newRow = new Row(this.columns);
            this.spreadSheet.Insert(row1 + 1, newRow);
            Interlocked.Increment(ref this.rows);
            for (int i = row1 + 2; i < rows; i++)
            {
                ((Row)spreadSheet[i]).rowMutex.ReleaseMutex();
                ((Row)spreadSheet[i]).rowIsFree = true;
            }
            changeSpreadSheetMutex.ReleaseMutex(); //check
            return true;
        }
        public bool addCol(int col1)
        {
            //Console.WriteLine("addCol");
            if (col1 >= this.columns || col1 < 0)
            {
                return false;
            }
            //add a column after col1
            changeSpreadSheetMutex.WaitOne(); //check
            for (int i = 0; i < rows; i++)
            {
                ((Row)spreadSheet[i]).rowMutex.WaitOne();
                ((Row)spreadSheet[i]).rowIsFree = false;
            }
            for (int i = 0; i < this.rows; i++)
            {
                ((Row)spreadSheet[i]).row.Insert(col1 + 1, null);
            }
            Interlocked.Increment(ref this.columns);
            for (int i = 0; i < rows; i++)
            {
                ((Row)spreadSheet[i]).rowMutex.ReleaseMutex();
                ((Row)spreadSheet[i]).rowIsFree = true;
            }
            changeSpreadSheetMutex.ReleaseMutex();
            return true;
        }
        public void getSize(ref int nRows, ref int nCols)
        {
            //Console.WriteLine("getSize");
            // return the size of the spreadsheet in nRows, nCols
            nRows = this.rows;
            nCols = this.columns;
        }
        public bool setConcurrentSearchLimit(int nUsers)
        {
            //Console.WriteLine("setCon");
            if (nUsers < userCount)
                return false;
            // this function aims to limit the number of users that can perform the search operations concurrently.
            // The default is no limit. When the function is called, the max number of concurrent search operations is set to nUsers. 
            // In this case additional search operations will wait for existing search to finish.
            this.hasNoLimit = false;
            Interlocked.Exchange(ref limit, nUsers);
            return true;
        }

        public bool save(string fileName)
        {
            //Console.WriteLine("save");
            if (fileName == null || fileName == "")
            {
                return false;
            }
            // save the spreadsheet to a file fileName.
            // you can decide the format you save the data. There are several options.
            this.saveLoadMutex.WaitOne();
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(rows + "\n");
            sw.Write(columns + "\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sw.Write(((Row)spreadSheet[i]).row[j] + "\n");
                }
            }
            sw.Flush();
            sw.Close();
            this.saveLoadMutex.ReleaseMutex();
            return true;
        }
        public bool load(string fileName)
        {
            if (fileName == null || fileName == "" || !File.Exists(fileName))
            {
                return false;
            }
            // load the spreadsheet from fileName
            // replace the data and size of the current spreadsheet with the loaded data
            this.saveLoadMutex.WaitOne();
            StreamReader sr = new StreamReader(fileName);
            int newRow = Int32.Parse(sr.ReadLine());
            int newCol = Int32.Parse(sr.ReadLine());
            ArrayList spreadSheetNew = new ArrayList();
            string newLine;
            for (int i = 0; i < newRow; i++)
            {
                spreadSheetNew.Add(new Row(newCol));
                for (int j = 0; j < newCol; j++)
                {
                    newLine = sr.ReadLine();
                    //((Row)spreadSheet[i]).row.Insert(j, "");
                    if (!newLine.Equals(""))
                    {
                        ((Row)spreadSheetNew[i]).row[j] = newLine;
                    }
                }
            }
            sr.Close();
            Interlocked.Exchange(ref spreadSheet, spreadSheetNew);
            Interlocked.Exchange(ref rows, newRow);
            Interlocked.Exchange(ref columns, newCol);
            this.saveLoadMutex.ReleaseMutex(); //check
            return true;
        }
    }

    class Row
    {
        public Mutex rowMutex;
        public bool rowIsFree;
        public ArrayList row;
        public int readersCount;

        public Row(int colSize)
        {
            this.row = new ArrayList();
            for (int i = 0; i < colSize; i++)
                this.row.Insert(i, "");
            this.rowMutex = new Mutex();
            this.rowIsFree = true;
            this.readersCount = 0;
        }
    }
}