namespace StudentYearlyCostCalculatorApp
{
    partial class yarlyCostCalculator
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
            this.costCalculatorGroupBox = new System.Windows.Forms.GroupBox();
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.classListComboBox = new System.Windows.Forms.ComboBox();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.totalCalculationButton = new System.Windows.Forms.Button();
            this.costCalculatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // costCalculatorGroupBox
            // 
            this.costCalculatorGroupBox.Controls.Add(this.totalCalculationButton);
            this.costCalculatorGroupBox.Controls.Add(this.discountCheckBox);
            this.costCalculatorGroupBox.Controls.Add(this.classListComboBox);
            this.costCalculatorGroupBox.Controls.Add(this.selectClassLabel);
            this.costCalculatorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costCalculatorGroupBox.Location = new System.Drawing.Point(13, 12);
            this.costCalculatorGroupBox.Name = "costCalculatorGroupBox";
            this.costCalculatorGroupBox.Size = new System.Drawing.Size(384, 177);
            this.costCalculatorGroupBox.TabIndex = 0;
            this.costCalculatorGroupBox.TabStop = false;
            this.costCalculatorGroupBox.Text = "Calculator for yearly cost of a student";
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.AutoSize = true;
            this.selectClassLabel.Location = new System.Drawing.Point(7, 41);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(86, 15);
            this.selectClassLabel.TabIndex = 0;
            this.selectClassLabel.Text = "Select Class";
            // 
            // classListComboBox
            // 
            this.classListComboBox.FormattingEnabled = true;
            this.classListComboBox.Location = new System.Drawing.Point(100, 41);
            this.classListComboBox.Name = "classListComboBox";
            this.classListComboBox.Size = new System.Drawing.Size(265, 23);
            this.classListComboBox.TabIndex = 1;
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(100, 81);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(198, 19);
            this.discountCheckBox.TabIndex = 2;
            this.discountCheckBox.Text = "Get 5% for early admission";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalCalculationButton
            // 
            this.totalCalculationButton.Location = new System.Drawing.Point(100, 120);
            this.totalCalculationButton.Name = "totalCalculationButton";
            this.totalCalculationButton.Size = new System.Drawing.Size(265, 28);
            this.totalCalculationButton.TabIndex = 3;
            this.totalCalculationButton.Text = "Calculate total amount for one year";
            this.totalCalculationButton.UseVisualStyleBackColor = true;
            this.totalCalculationButton.Click += new System.EventHandler(this.totalCalculationButton_Click);
            // 
            // yarlyCostCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 201);
            this.Controls.Add(this.costCalculatorGroupBox);
            this.Name = "yarlyCostCalculator";
            this.Text = "Yearly Cost Calculator";
            this.costCalculatorGroupBox.ResumeLayout(false);
            this.costCalculatorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox costCalculatorGroupBox;
        private System.Windows.Forms.Button totalCalculationButton;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.ComboBox classListComboBox;
        private System.Windows.Forms.Label selectClassLabel;
    }
}

