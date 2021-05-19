
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
            this.searchRow = new System.Windows.Forms.TextBox();
            this.strToSearchRow = new System.Windows.Forms.TextBox();
            this.submitButton = new SpreadsheetApp.RoundedButton();
            this.SuspendLayout();
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
            // submitButton
            // 
            this.submitButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(100, 167);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.submitButton.Size = new System.Drawing.Size(140, 35);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.TextColor = System.Drawing.Color.Black;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SearchRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 256);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strToSearchRow);
            this.Controls.Add(this.searchRow);
            this.Name = "SearchRowForm";
            this.Text = "SearchRowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchRow;
        private System.Windows.Forms.TextBox strToSearchRow;
        private RoundedButton submitButton;
    }
}