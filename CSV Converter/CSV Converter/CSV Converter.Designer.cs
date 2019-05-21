namespace CSV_Converter
{
    partial class CSVConverter
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
            this.BTN_InputFileSelect = new System.Windows.Forms.Button();
            this.L_InputFilename = new System.Windows.Forms.Label();
            this.L_OutputFileName = new System.Windows.Forms.Label();
            this.BTN_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_InputFileSelect
            // 
            this.BTN_InputFileSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_InputFileSelect.Location = new System.Drawing.Point(35, 56);
            this.BTN_InputFileSelect.Name = "BTN_InputFileSelect";
            this.BTN_InputFileSelect.Size = new System.Drawing.Size(120, 51);
            this.BTN_InputFileSelect.TabIndex = 0;
            this.BTN_InputFileSelect.Text = "Select File:";
            this.BTN_InputFileSelect.UseVisualStyleBackColor = true;
            this.BTN_InputFileSelect.Click += new System.EventHandler(this.BTN_InputFileSelect_Click);
            // 
            // L_InputFilename
            // 
            this.L_InputFilename.AutoSize = true;
            this.L_InputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InputFilename.Location = new System.Drawing.Point(161, 69);
            this.L_InputFilename.Name = "L_InputFilename";
            this.L_InputFilename.Size = new System.Drawing.Size(133, 24);
            this.L_InputFilename.TabIndex = 1;
            this.L_InputFilename.Text = "InputFileName";
            // 
            // L_OutputFileName
            // 
            this.L_OutputFileName.AutoSize = true;
            this.L_OutputFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_OutputFileName.Location = new System.Drawing.Point(161, 135);
            this.L_OutputFileName.Name = "L_OutputFileName";
            this.L_OutputFileName.Size = new System.Drawing.Size(148, 24);
            this.L_OutputFileName.TabIndex = 2;
            this.L_OutputFileName.Text = "OutputFileName";
            // 
            // BTN_Convert
            // 
            this.BTN_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Convert.Location = new System.Drawing.Point(652, 399);
            this.BTN_Convert.Name = "BTN_Convert";
            this.BTN_Convert.Size = new System.Drawing.Size(120, 51);
            this.BTN_Convert.TabIndex = 3;
            this.BTN_Convert.Text = "Convert";
            this.BTN_Convert.UseVisualStyleBackColor = true;
            this.BTN_Convert.Click += new System.EventHandler(this.BTN_Convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.BTN_Convert);
            this.Controls.Add(this.L_OutputFileName);
            this.Controls.Add(this.L_InputFilename);
            this.Controls.Add(this.BTN_InputFileSelect);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "CSV Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_InputFileSelect;
        private System.Windows.Forms.Label L_InputFilename;
        private System.Windows.Forms.Label L_OutputFileName;
        private System.Windows.Forms.Button BTN_Convert;
    }
}

