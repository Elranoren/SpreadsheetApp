
namespace SpreadsheetApp
{
    partial class SearchSpreadsheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitSearchAll = new System.Windows.Forms.Button();
            this.strToSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitSearchAll
            // 
            this.submitSearchAll.Location = new System.Drawing.Point(122, 145);
            this.submitSearchAll.Name = "submitSearchAll";
            this.submitSearchAll.Size = new System.Drawing.Size(94, 29);
            this.submitSearchAll.TabIndex = 0;
            this.submitSearchAll.Text = "Submit";
            this.submitSearchAll.UseVisualStyleBackColor = true;
            this.submitSearchAll.Click += new System.EventHandler(this.submitSearchAll_Click);
            // 
            // strToSearch
            // 
            this.strToSearch.Location = new System.Drawing.Point(58, 65);
            this.strToSearch.Name = "strToSearch";
            this.strToSearch.Size = new System.Drawing.Size(251, 27);
            this.strToSearch.TabIndex = 1;
            this.strToSearch.Text = "Enter Text To Search";
            // 
            // SearchSpreadsheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 278);
            this.Controls.Add(this.strToSearch);
            this.Controls.Add(this.submitSearchAll);
            this.Name = "SearchSpreadsheetForm";
            this.Text = "SearchSpreadsheetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitSearchAll;
        private System.Windows.Forms.TextBox strToSearch;
    }
}