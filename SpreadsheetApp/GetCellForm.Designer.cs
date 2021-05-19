
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
            this.row = new System.Windows.Forms.TextBox();
            this.col = new System.Windows.Forms.TextBox();
            this.submitButton = new SpreadsheetApp.RoundedButton();
            this.SuspendLayout();
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
            // submitButton
            // 
            this.submitButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(113, 173);
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
            // GetCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 281);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.col);
            this.Controls.Add(this.row);
            this.Name = "GetCellForm";
            this.Text = "GetCellForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.TextBox col;
        private RoundedButton submitButton;
    }
}