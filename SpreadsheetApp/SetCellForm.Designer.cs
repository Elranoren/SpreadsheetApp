
namespace SpreadsheetApp
{
    partial class SetCellForm
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
            this.row = new System.Windows.Forms.TextBox();
            this.column = new System.Windows.Forms.TextBox();
            this.str = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitSetGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(55, 69);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(426, 27);
            this.row.TabIndex = 0;
            this.row.Text = "Enter Row Number Here";
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(55, 126);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(426, 27);
            this.column.TabIndex = 1;
            this.column.Text = "Enter Column Number Here";
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(55, 187);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(426, 27);
            this.str.TabIndex = 2;
            this.str.Text = "Enter a String to Put in this Cell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter the Realevant Data";
            // 
            // SubmitSetGet
            // 
            this.SubmitSetGet.Location = new System.Drawing.Point(199, 256);
            this.SubmitSetGet.Name = "SubmitSetGet";
            this.SubmitSetGet.Size = new System.Drawing.Size(94, 29);
            this.SubmitSetGet.TabIndex = 4;
            this.SubmitSetGet.Text = "Submit";
            this.SubmitSetGet.UseVisualStyleBackColor = true;
            this.SubmitSetGet.Click += new System.EventHandler(this.SubmitSetGet_Click);
            // 
            // SetCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 316);
            this.Controls.Add(this.SubmitSetGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.str);
            this.Controls.Add(this.column);
            this.Controls.Add(this.row);
            this.Name = "SetCellForm";
            this.Text = "SetCellForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.TextBox column;
        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitSetGet;
    }
}