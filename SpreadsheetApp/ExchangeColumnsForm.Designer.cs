
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
            this.firstCol = new System.Windows.Forms.TextBox();
            this.secondCol = new System.Windows.Forms.TextBox();
            this.submitButton = new SpreadsheetApp.RoundedButton();
            this.SuspendLayout();
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
            // submitButton
            // 
            this.submitButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(110, 181);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitButton.OnHoverButtonColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.submitButton.Size = new System.Drawing.Size(140, 35);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.TextColor = System.Drawing.Color.Black;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ExchangeColumnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 309);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.secondCol);
            this.Controls.Add(this.firstCol);
            this.Name = "ExchangeColumnsForm";
            this.Text = "ExchangeColumnsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstCol;
        private System.Windows.Forms.TextBox secondCol;
        private RoundedButton submitButton;
    }
}