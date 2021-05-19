
namespace SpreadsheetApp
{
    partial class SearchRangeForm
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
            this.fromRow = new System.Windows.Forms.TextBox();
            this.toRow = new System.Windows.Forms.TextBox();
            this.fromCol = new System.Windows.Forms.TextBox();
            this.toCol = new System.Windows.Forms.TextBox();
            this.strRange = new System.Windows.Forms.TextBox();
            this.submitButton = new SpreadsheetApp.RoundedButton();
            this.SuspendLayout();
            // 
            // fromRow
            // 
            this.fromRow.Location = new System.Drawing.Point(30, 58);
            this.fromRow.Name = "fromRow";
            this.fromRow.Size = new System.Drawing.Size(153, 27);
            this.fromRow.TabIndex = 1;
            this.fromRow.Text = "Search From Row";
            // 
            // toRow
            // 
            this.toRow.Location = new System.Drawing.Point(210, 58);
            this.toRow.Name = "toRow";
            this.toRow.Size = new System.Drawing.Size(138, 27);
            this.toRow.TabIndex = 2;
            this.toRow.Text = "Search To Row";
            // 
            // fromCol
            // 
            this.fromCol.Location = new System.Drawing.Point(30, 114);
            this.fromCol.Name = "fromCol";
            this.fromCol.Size = new System.Drawing.Size(153, 27);
            this.fromCol.TabIndex = 3;
            this.fromCol.Text = "Search From Column";
            // 
            // toCol
            // 
            this.toCol.Location = new System.Drawing.Point(210, 114);
            this.toCol.Name = "toCol";
            this.toCol.Size = new System.Drawing.Size(138, 27);
            this.toCol.TabIndex = 4;
            this.toCol.Text = "Search To Column";
            // 
            // strRange
            // 
            this.strRange.Location = new System.Drawing.Point(118, 163);
            this.strRange.Name = "strRange";
            this.strRange.Size = new System.Drawing.Size(152, 27);
            this.strRange.TabIndex = 5;
            this.strRange.Text = "Enter String to Search";
            // 
            // submitButton
            // 
            this.submitButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(118, 216);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.submitButton.Size = new System.Drawing.Size(140, 35);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.TextColor = System.Drawing.Color.Black;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SearchRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 291);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strRange);
            this.Controls.Add(this.toCol);
            this.Controls.Add(this.fromCol);
            this.Controls.Add(this.toRow);
            this.Controls.Add(this.fromRow);
            this.Name = "SearchRangeForm";
            this.Text = "SearchRangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fromRow;
        private System.Windows.Forms.TextBox toRow;
        private System.Windows.Forms.TextBox fromCol;
        private System.Windows.Forms.TextBox toCol;
        private System.Windows.Forms.TextBox strRange;
        private RoundedButton submitButton;
    }
}