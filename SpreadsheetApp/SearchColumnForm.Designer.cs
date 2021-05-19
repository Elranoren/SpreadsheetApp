
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
            this.searchCol = new System.Windows.Forms.TextBox();
            this.strToSearchCol = new System.Windows.Forms.TextBox();
            this.submitButton = new SpreadsheetApp.RoundedButton();
            this.SuspendLayout();
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
            // submitButton
            // 
            this.submitButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(122, 179);
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
            // SearchColumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 281);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strToSearchCol);
            this.Controls.Add(this.searchCol);
            this.Name = "SearchColumnForm";
            this.Text = "SearchColumnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchCol;
        private System.Windows.Forms.TextBox strToSearchCol;
        private RoundedButton submitButton;
    }
}