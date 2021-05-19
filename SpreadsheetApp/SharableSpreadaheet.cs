using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SpreadsheetApp
{
    class SharableSpreadaheet
    {
        private ArrayList spreadSheet;
        private int rows;
        private int columns;
        private Boolean hasNoLimit;
        private int limit;
        private int userCount;
        private Mutex saveLoadMutex;
        private Mutex changeSpreadSheetMutex;

        public SharableSpreadaheet(int nRows, int nCols)
        {
            // construct a nRows*nCols spreadsheet
            this.hasNoLimit = true;
            this.limit = 1;
            userCount = 0;
            this.rows = nRows;
            this.columns = nCols;
            this.saveLoadMutex = new Mutex();
            this.changeSpreadSheetMutex = new Mutex();
            this.spreadSheet = new ArrayList();
            for (int i = 0; i < nRows; i++)
            {
                this.spreadSheet.Add(new ArrayList());
                for (int j = 0; j < nCols; j++)
                {
                    ((ArrayList)spreadSheet[i]).Insert(j, new Cell());
                }
            }
        }
        public string[,] spreadSheetTo2DArray()
        {
            string[,] strSP = new string[rows+1, columns+1];
            for(int i = 0; i < rows+1; i++)
            {
                if(i!=0)
                    strSP[i, 0] = i + "";
                for (int j = 1; j < columns+1; j++)
                {
                    if (i == 0)
                    {
                        strSP[0, j] = j + "";
                    }
                    else
                        strSP[i, j] = ((Cell)((ArrayList)spreadSheet[i-1])[j-1]).cellValue;
                }
            }
            return strSP;
        }
        public ArrayList getSpreadSheet()
        {
            return spreadSheet;
        }
        public string getCell(int row, int col)
        {
            //Console.WriteLine("getcell");
            if (row>=this.rows || col >= this.columns || row<0 || col<0)
            {
                return null;
            }
            while (!((Cell)((ArrayList)spreadSheet[row])[col]).cellIsFree) ;
            return ((Cell)((ArrayList)spreadSheet[row])[col]).cellValue;
        }
        public bool setCell(int row, int col, string str)
        {
            //Console.WriteLine("setcell");
            if (row >= this.rows || col >= this.columns || row < 0 || col < 0)
            {
                return false;
            }
            changeSpreadSheetMutex.WaitOne();
            ((Cell)((ArrayList)spreadSheet[row])[col]).cellMutex.WaitOne();
            ((Cell)((ArrayList)spreadSheet[row])[col]).cellIsFree = false;
            // set the string at [row,col]
            ((Cell)((ArrayList)spreadSheet[row])[col]).cellValue = str;
            ((Cell)((ArrayList)spreadSheet[row])[col]).cellMutex.ReleaseMutex();
            ((Cell)((ArrayList)spreadSheet[row])[col]).cellIsFree = true;
            changeSpreadSheetMutex.ReleaseMutex();
            return true;
        }
        public bool searchString(string str, ref int row, ref int col)
        {
            //Console.WriteLine("searchString");
            while (!hasNoLimit && limit <= userCount);
            // search the cell with string str, and return true/false accordingly.
            // stores the location in row,col.
            // return the first cell that contains the string (search from first row to the last row)
            Interlocked.Increment(ref userCount); //Atomic increment
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    while (!((Cell)((ArrayList)spreadSheet[i])[j]).cellIsFree) ;
                    if (str.Equals(((Cell)((ArrayList)spreadSheet[i])[j]).cellValue))
                    {
                        row = i;
                        col = j;
                        Interlocked.Decrement(ref userCount); //Atomic decrement
                        return true;
                    }
                }
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
            changeSpreadSheetMutex.WaitOne();
            for(int i = 0; i < this.columns; i++)
            {
                ((Cell)((ArrayList)spreadSheet[row1])[i]).cellMutex.WaitOne();
                ((Cell)((ArrayList)spreadSheet[row1])[i]).cellIsFree = false;
                ((Cell)((ArrayList)spreadSheet[row2])[i]).cellMutex.WaitOne();
                ((Cell)((ArrayList)spreadSheet[row2])[i]).cellIsFree = false;
            }
            ArrayList temp = (ArrayList)spreadSheet[row1];
            spreadSheet[row1] = (ArrayList)spreadSheet[row2];
            spreadSheet[row2] = temp;
            for (int i = 0; i < this.columns; i++)
            {
                ((Cell)((ArrayList)spreadSheet[row1])[i]).cellMutex.ReleaseMutex();
                ((Cell)((ArrayList)spreadSheet[row1])[i]).cellIsFree = true;
                ((Cell)((ArrayList)spreadSheet[row2])[i]).cellMutex.ReleaseMutex();
                ((Cell)((ArrayList)spreadSheet[row2])[i]).cellIsFree = true;
            }
            changeSpreadSheetMutex.ReleaseMutex();
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
            changeSpreadSheetMutex.WaitOne();
            string tempStr;
            for (int i = 0; i < this.rows; i++)
            {
                ((Cell)((ArrayList)spreadSheet[i])[col1]).cellMutex.WaitOne();
                ((Cell)((ArrayList)spreadSheet[i])[col1]).cellIsFree = false;
                ((Cell)((ArrayList)spreadSheet[i])[col2]).cellMutex.WaitOne();
                ((Cell)((ArrayList)spreadSheet[i])[col2]).cellIsFree = false;
                tempStr = ((Cell)((ArrayList)spreadSheet[i])[col1]).cellValue;
                ((Cell)((ArrayList)spreadSheet[i])[col1]).cellValue = ((Cell)((ArrayList)spreadSheet[i])[col2]).cellValue;
                ((Cell)((ArrayList)spreadSheet[i])[col2]).cellValue = tempStr;
                ((Cell)((ArrayList)spreadSheet[i])[col1]).cellMutex.ReleaseMutex();
                ((Cell)((ArrayList)spreadSheet[i])[col1]).cellIsFree = true;
                ((Cell)((ArrayList)spreadSheet[i])[col2]).cellMutex.ReleaseMutex();
                ((Cell)((ArrayList)spreadSheet[i])[col2]).cellIsFree = true;
            }
            changeSpreadSheetMutex.ReleaseMutex();
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
            for (int i = 0; i < this.columns; i++)
            {
                while (!((Cell)((ArrayList)spreadSheet[row])[i]).cellIsFree) ;
                if (str.Equals(((Cell)((ArrayList)spreadSheet[row])[i]).cellValue))
                {
                    col = i;
                    Interlocked.Decrement(ref userCount);
                    return true;
                }
            }
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
                while (!((Cell)((ArrayList)spreadSheet[i])[col]).cellIsFree) ;
                if (str.Equals(((Cell)((ArrayList)spreadSheet[i])[col]).cellValue))
                {
                    row = i;
                    Interlocked.Decrement(ref userCount);
                    return true;
                }
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
            while (!hasNoLimit && limit <= userCount);
            // perform search within spesific range: [row1:row2,col1:col2] 
            //includes col1,col2,row1,row2
            Interlocked.Increment(ref userCount);
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    while (!((Cell)((ArrayList)spreadSheet[i])[j]).cellIsFree) ;
                    if (str.Equals(((Cell)((ArrayList)spreadSheet[i])[j]).cellValue))
                    {
                        row = i;
                        col = j;
                        Interlocked.Decrement(ref userCount);
                        return true;
                    }
                }
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
            changeSpreadSheetMutex.WaitOne();
            for(int i = row1+1; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellMutex.WaitOne();
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellIsFree = false;
                }
            }
            ArrayList newRow = new ArrayList();
            for (int j = 0; j < this.columns; j++)
            {
                newRow.Insert(j, new Cell());
            }
            this.spreadSheet.Insert(row1+1, newRow);
            Interlocked.Increment(ref this.rows);
            for (int i = row1+2; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellMutex.ReleaseMutex();
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellIsFree = true;
                }
            }
            changeSpreadSheetMutex.ReleaseMutex();
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
            changeSpreadSheetMutex.WaitOne();
            for (int i = 0; i < rows; i++)
            {
                for (int j = col1+1; j < columns; j++)
                {
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellMutex.WaitOne();
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellIsFree = false;
                }
            }
            for (int i = 0; i < this.rows; i++)
            {
                ((ArrayList)spreadSheet[i]).Insert(col1+1, new Cell());
            }
            Interlocked.Increment(ref this.columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = col1+2; j < columns; j++)
                {
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellMutex.ReleaseMutex();
                    ((Cell)((ArrayList)spreadSheet[i])[j]).cellIsFree = true;
                }
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
            Interlocked.Exchange(ref limit,nUsers);
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
            sw.Write(rows+"\n");
            sw.Write(columns + "\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sw.Write(((Cell)((ArrayList)spreadSheet[i])[j]).cellValue + "\n");
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
                spreadSheetNew.Add(new ArrayList());
                for (int j = 0; j < newCol; j++)
                {
                    newLine = sr.ReadLine();
                    ((ArrayList)spreadSheetNew[i]).Insert(j, new Cell());
                    if (!newLine.Equals(""))
                    {
                        ((Cell)((ArrayList)spreadSheet[i])[j]).cellValue = newLine;
                    }
                }
            }
            sr.Close();
            Interlocked.Exchange(ref spreadSheet, spreadSheetNew);
            Interlocked.Exchange(ref rows, newRow);
            Interlocked.Exchange(ref columns, newCol);
            this.saveLoadMutex.ReleaseMutex();
            return true;
        }
    }

    class Cell
    {
        public string cellValue;
        public Mutex cellMutex;
        public bool cellIsFree;

        public Cell()
        {
            this.cellValue = null;
            this.cellMutex = new Mutex();
            this.cellIsFree = true;
        }
    }
}