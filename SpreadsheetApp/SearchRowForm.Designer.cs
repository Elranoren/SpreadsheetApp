
namespace SpreadsheetApp
{
    partial class SearchRowForm
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
            this.submitSearchRow = new System.Windows.Forms.Button();
            this.searchRow = new System.Windows.Forms.TextBox();
            this.strToSearchRow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitSearchRow
            // 
            this.submitSearchRow.Location = new System.Drawing.Point(118, 178);
            this.submitSearchRow.Name = "submitSearchRow";
            this.submitSearchRow.Size = new System.Drawing.Size(94, 29);
            this.submitSearchRow.TabIndex = 0;
            this.submitSearchRow.Text = "Submit";
            this.submitSearchRow.UseVisualStyleBackColor = true;
            this.submitSearchRow.Click += new System.EventHandler(this.submitSearchRow_Click);
            // 
            // searchRow
            // 
            this.searchRow.Location = new System.Drawing.Point(48, 51);
            this.searchRow.Name = "searchRow";
            this.searchRow.Size = new System.Drawing.Size(286, 27);
            this.searchRow.TabIndex = 1;
            this.searchRow.Text = "Enter the Row Number to Search";
            // 
            // strToSearchRow
            // 
            this.strToSearchRow.Location = new System.Drawing.Point(48, 109);
            this.strToSearchRow.Name = "strToSearchRow";
            this.strToSearchRow.Size = new System.Drawing.Size(286, 27);
            this.strToSearchRow.TabIndex = 2;
            this.strToSearchRow.Text = "Enter String to Search";
            // 
            // SearchRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 256);
            this.Controls.Add(this.strToSearchRow);
            this.Controls.Add(this.searchRow);
            this.Controls.Add(this.submitSearchRow);
            this.Name = "SearchRowForm";
            this.Text = "SearchRowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitSearchRow;
        private System.Windows.Forms.TextBox searchRow;
        private System.Windows.Forms.TextBox strToSearchRow;
    }
}