
namespace SpreadsheetApp
{
    partial class ExchangeColumnsForm
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
            this.submitExCols = new System.Windows.Forms.Button();
            this.firstCol = new System.Windows.Forms.TextBox();
            this.secondCol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitExCols
            // 
            this.submitExCols.Location = new System.Drawing.Point(137, 184);
            this.submitExCols.Name = "submitExCols";
            this.submitExCols.Size = new System.Drawing.Size(94, 29);
            this.submitExCols.TabIndex = 0;
            this.submitExCols.Text = "Submit";
            this.submitExCols.UseVisualStyleBackColor = true;
            this.submitExCols.Click += new System.EventHandler(this.submitExCols_Click);
            // 
            // firstCol
            // 
            this.firstCol.Location = new System.Drawing.Point(57, 50);
            this.firstCol.Name = "firstCol";
            this.firstCol.Size = new System.Drawing.Size(299, 27);
            this.firstCol.TabIndex = 1;
            this.firstCol.Text = "Enter the First Column to Exchange";
            // 
            // secondCol
            // 
            this.secondCol.Location = new System.Drawing.Point(57, 108);
            this.secondCol.Name = "secondCol";
            this.secondCol.Size = new System.Drawing.Size(299, 27);
            this.secondCol.TabIndex = 2;
            this.secondCol.Text = "Enter the Second Column to Exchange";
            // 
            // ExchangeColumnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 309);
            this.Controls.Add(this.secondCol);
            this.Controls.Add(this.firstCol);
            this.Controls.Add(this.submitExCols);
            this.Name = "ExchangeColumnsForm";
            this.Text = "ExchangeColumnsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitExCols;
        private System.Windows.Forms.TextBox firstCol;
        private System.Windows.Forms.TextBox secondCol;
    }
}