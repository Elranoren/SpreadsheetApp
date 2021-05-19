
namespace SpreadsheetApp
{
    partial class ExchangeRowsForm
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
            this.firstRow = new System.Windows.Forms.TextBox();
            this.secondRow = new System.Windows.Forms.TextBox();
            this.submitExRows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstRow
            // 
            this.firstRow.Location = new System.Drawing.Point(59, 54);
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(292, 27);
            this.firstRow.TabIndex = 0;
            this.firstRow.Text = "Enter the First Row to Exchange";
            // 
            // secondRow
            // 
            this.secondRow.Location = new System.Drawing.Point(59, 115);
            this.secondRow.Name = "secondRow";
            this.secondRow.Size = new System.Drawing.Size(292, 27);
            this.secondRow.TabIndex = 1;
            this.secondRow.Text = "Enter the Second Row to Exchange";
            // 
            // submitExRows
            // 
            this.submitExRows.Location = new System.Drawing.Point(148, 200);
            this.submitExRows.Name = "submitExRows";
            this.submitExRows.Size = new System.Drawing.Size(94, 29);
            this.submitExRows.TabIndex = 2;
            this.submitExRows.Text = "Submit";
            this.submitExRows.UseVisualStyleBackColor = true;
            this.submitExRows.Click += new System.EventHandler(this.submitExRows_Click);
            // 
            // ExchangeRowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.submitExRows);
            this.Controls.Add(this.secondRow);
            this.Controls.Add(this.firstRow);
            this.Name = "ExchangeRowsForm";
            this.Text = "ExchangeRowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstRow;
        private System.Windows.Forms.TextBox secondRow;
        private System.Windows.Forms.Button submitExRows;
    }
}