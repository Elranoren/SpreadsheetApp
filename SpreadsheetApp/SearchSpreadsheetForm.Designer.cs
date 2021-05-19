
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
            this.strToSearch = new System.Windows.Forms.TextBox();
            this.submitButton = new SpreadsheetApp.RoundedButton();
            this.SuspendLayout();
            // 
            // strToSearch
            // 
            this.strToSearch.Location = new System.Drawing.Point(58, 65);
            this.strToSearch.Name = "strToSearch";
            this.strToSearch.Size = new System.Drawing.Size(251, 27);
            this.strToSearch.TabIndex = 1;
            this.strToSearch.Text = "Enter Text To Search";
            // 
            // submitButton
            // 
            this.submitButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(106, 164);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.submitButton.Size = new System.Drawing.Size(140, 35);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.TextColor = System.Drawing.Color.Black;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SearchSpreadsheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 278);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strToSearch);
            this.Name = "SearchSpreadsheetForm";
            this.Text = "SearchSpreadsheetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox strToSearch;
        private RoundedButton submitButton;
    }
}