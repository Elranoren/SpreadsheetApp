
using System;

namespace SpreadsheetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spreadSheet = new System.Windows.Forms.DataGridView();
            this.chooseSearch = new System.Windows.Forms.ComboBox();
            this.chooseExchange = new System.Windows.Forms.ComboBox();
            this.rowPos = new System.Windows.Forms.TextBox();
            this.colPos = new System.Windows.Forms.TextBox();
            this.saveButton = new SpreadsheetApp.RoundedButton();
            this.loadButton = new SpreadsheetApp.RoundedButton();
            this.setCellButton = new SpreadsheetApp.RoundedButton();
            this.getCellButton = new SpreadsheetApp.RoundedButton();
            this.searchButton = new SpreadsheetApp.RoundedButton();
            this.exButton = new SpreadsheetApp.RoundedButton();
            this.addRowButton = new SpreadsheetApp.RoundedButton();
            this.addColButton = new SpreadsheetApp.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spreadSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadSheet
            // 
            this.spreadSheet.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.spreadSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spreadSheet.GridColor = System.Drawing.Color.BlanchedAlmond;
            this.spreadSheet.Location = new System.Drawing.Point(30, 22);
            this.spreadSheet.Name = "spreadSheet";
            this.spreadSheet.RowHeadersWidth = 51;
            this.spreadSheet.RowTemplate.Height = 29;
            this.spreadSheet.Size = new System.Drawing.Size(579, 438);
            this.spreadSheet.TabIndex = 0;
            // 
            // chooseSearch
            // 
            this.chooseSearch.FormattingEnabled = true;
            this.chooseSearch.Items.AddRange(new object[] {
            "Search Spreadsheet",
            "Search in Row",
            "Search in Column",
            "Search in Range"});
            this.chooseSearch.Location = new System.Drawing.Point(664, 145);
            this.chooseSearch.Name = "chooseSearch";
            this.chooseSearch.Size = new System.Drawing.Size(142, 28);
            this.chooseSearch.TabIndex = 11;
            this.chooseSearch.Text = "Choose Search";
            // 
            // chooseExchange
            // 
            this.chooseExchange.FormattingEnabled = true;
            this.chooseExchange.Items.AddRange(new object[] {
            "Exchange Rows",
            "Exchange Columns"});
            this.chooseExchange.Location = new System.Drawing.Point(832, 145);
            this.chooseExchange.Name = "chooseExchange";
            this.chooseExchange.Size = new System.Drawing.Size(140, 28);
            this.chooseExchange.TabIndex = 12;
            this.chooseExchange.Text = "Choose Exchange";
            // 
            // rowPos
            // 
            this.rowPos.Location = new System.Drawing.Point(832, 249);
            this.rowPos.Name = "rowPos";
            this.rowPos.Size = new System.Drawing.Size(140, 27);
            this.rowPos.TabIndex = 15;
            this.rowPos.Text = "Insert after Row";
            // 
            // colPos
            // 
            this.colPos.Location = new System.Drawing.Point(832, 303);
            this.colPos.Name = "colPos";
            this.colPos.Size = new System.Drawing.Size(140, 27);
            this.colPos.TabIndex = 16;
            this.colPos.Text = "Insert after Column";
            // 
            // saveButton
            // 
            this.saveButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(666, 46);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.saveButton.Size = new System.Drawing.Size(140, 35);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "SAVE";
            this.saveButton.TextColor = System.Drawing.Color.Black;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadButton.Location = new System.Drawing.Point(832, 46);
            this.loadButton.Name = "loadButton";
            this.loadButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loadButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.loadButton.Size = new System.Drawing.Size(140, 35);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "LOAD";
            this.loadButton.TextColor = System.Drawing.Color.Black;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // setCellButton
            // 
            this.setCellButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.setCellButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.setCellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setCellButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setCellButton.Location = new System.Drawing.Point(666, 94);
            this.setCellButton.Name = "setCellButton";
            this.setCellButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setCellButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setCellButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.setCellButton.Size = new System.Drawing.Size(140, 35);
            this.setCellButton.TabIndex = 19;
            this.setCellButton.Text = "SET CELL";
            this.setCellButton.TextColor = System.Drawing.Color.Black;
            this.setCellButton.UseVisualStyleBackColor = true;
            this.setCellButton.Click += new System.EventHandler(this.setCellButton_Click);
            // 
            // getCellButton
            // 
            this.getCellButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.getCellButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.getCellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCellButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getCellButton.Location = new System.Drawing.Point(832, 94);
            this.getCellButton.Name = "getCellButton";
            this.getCellButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getCellButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.getCellButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.getCellButton.Size = new System.Drawing.Size(140, 35);
            this.getCellButton.TabIndex = 20;
            this.getCellButton.Text = "GET CELL";
            this.getCellButton.TextColor = System.Drawing.Color.Black;
            this.getCellButton.UseVisualStyleBackColor = true;
            this.getCellButton.Click += new System.EventHandler(this.getCellButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(666, 191);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.searchButton.Size = new System.Drawing.Size(140, 35);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "SEARCH";
            this.searchButton.TextColor = System.Drawing.Color.Black;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exButton
            // 
            this.exButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.exButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.exButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exButton.Location = new System.Drawing.Point(832, 191);
            this.exButton.Name = "exButton";
            this.exButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.exButton.Size = new System.Drawing.Size(140, 35);
            this.exButton.TabIndex = 22;
            this.exButton.Text = "EXCHANGE";
            this.exButton.TextColor = System.Drawing.Color.Black;
            this.exButton.UseVisualStyleBackColor = true;
            this.exButton.Click += new System.EventHandler(this.exButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.addRowButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.addRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRowButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addRowButton.Location = new System.Drawing.Point(666, 243);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addRowButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addRowButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.addRowButton.Size = new System.Drawing.Size(140, 35);
            this.addRowButton.TabIndex = 23;
            this.addRowButton.Text = "ADD ROW";
            this.addRowButton.TextColor = System.Drawing.Color.Black;
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // addColButton
            // 
            this.addColButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.addColButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.addColButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addColButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addColButton.Location = new System.Drawing.Point(666, 298);
            this.addColButton.Name = "addColButton";
            this.addColButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addColButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addColButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.addColButton.Size = new System.Drawing.Size(140, 35);
            this.addColButton.TabIndex = 24;
            this.addColButton.Text = "ADD COLUMN";
            this.addColButton.TextColor = System.Drawing.Color.Black;
            this.addColButton.UseVisualStyleBackColor = true;
            this.addColButton.Click += new System.EventHandler(this.addColButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(635, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "GUI Application!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(635, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Welcome to Maor\'s and Elran\'s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addColButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.exButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.getCellButton);
            this.Controls.Add(this.setCellButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.colPos);
            this.Controls.Add(this.rowPos);
            this.Controls.Add(this.chooseExchange);
            this.Controls.Add(this.chooseSearch);
            this.Controls.Add(this.spreadSheet);
            this.Name = "Form1";
            this.Text = "SpreadSheetApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spreadSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView spreadSheet;
        private System.Windows.Forms.ComboBox chooseSearch;
        private System.Windows.Forms.ComboBox chooseExchange;
        private System.Windows.Forms.TextBox rowPos;
        private System.Windows.Forms.TextBox colPos;
        private RoundedButton saveButton;
        private RoundedButton loadButton;
        private RoundedButton setCellButton;
        private RoundedButton getCellButton;
        private RoundedButton searchButton;
        private RoundedButton exButton;
        private RoundedButton addRowButton;
        private RoundedButton addColButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

