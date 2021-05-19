
namespace SpreadsheetApp
{
    partial class SearchColumnForm
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
            this.SubmitSearchCol = new System.Windows.Forms.Button();
            this.searchCol = new System.Windows.Forms.TextBox();
            this.strToSearchCol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitSearchCol
            // 
            this.SubmitSearchCol.Location = new System.Drawing.Point(144, 180);
            this.SubmitSearchCol.Name = "SubmitSearchCol";
            this.SubmitSearchCol.Size = new System.Drawing.Size(94, 29);
            this.SubmitSearchCol.TabIndex = 0;
            this.SubmitSearchCol.Text = "Submit";
            this.SubmitSearchCol.UseVisualStyleBackColor = true;
            this.SubmitSearchCol.Click += new System.EventHandler(this.SubmitSearchCol_Click);
            // 
            // searchCol
            // 
            this.searchCol.Location = new System.Drawing.Point(67, 71);
            this.searchCol.Name = "searchCol";
            this.searchCol.Size = new System.Drawing.Size(259, 27);
            this.searchCol.TabIndex = 1;
            this.searchCol.Text = "Enter the Column Number to Search";
            // 
            // strToSearchCol
            // 
            this.strToSearchCol.Location = new System.Drawing.Point(67, 121);
            this.strToSearchCol.Name = "strToSearchCol";
            this.strToSearchCol.Size = new System.Drawing.Size(259, 27);
            this.strToSearchCol.TabIndex = 2;
            this.strToSearchCol.Text = "Enter String to Search";
            // 
            // SearchColumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 281);
            this.Controls.Add(this.strToSearchCol);
            this.Controls.Add(this.searchCol);
            this.Controls.Add(this.SubmitSearchCol);
            this.Name = "SearchColumnForm";
            this.Text = "SearchColumnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitSearchCol;
        private System.Windows.Forms.TextBox searchCol;
        private System.Windows.Forms.TextBox strToSearchCol;
    }
}