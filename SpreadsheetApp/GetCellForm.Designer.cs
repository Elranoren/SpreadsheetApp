
namespace SpreadsheetApp
{
    partial class GetCellForm
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
            this.submitSet = new System.Windows.Forms.Button();
            this.row = new System.Windows.Forms.TextBox();
            this.col = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitSet
            // 
            this.submitSet.Location = new System.Drawing.Point(146, 173);
            this.submitSet.Name = "submitSet";
            this.submitSet.Size = new System.Drawing.Size(94, 29);
            this.submitSet.TabIndex = 0;
            this.submitSet.Text = "Submit";
            this.submitSet.UseVisualStyleBackColor = true;
            this.submitSet.Click += new System.EventHandler(this.submitSet_Click);
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(44, 49);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(292, 27);
            this.row.TabIndex = 1;
            this.row.Text = "Enter Row Number Here";
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(44, 110);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(292, 27);
            this.col.TabIndex = 2;
            this.col.Text = "Enter Column Number Here";
            // 
            // GetCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 281);
            this.Controls.Add(this.col);
            this.Controls.Add(this.row);
            this.Controls.Add(this.submitSet);
            this.Name = "GetCellForm";
            this.Text = "GetCellForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitSet;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.TextBox col;
    }
}