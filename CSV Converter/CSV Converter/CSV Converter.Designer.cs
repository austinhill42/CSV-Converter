namespace CSV_Converter
{
    partial class Form1
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
            // 
            // L_InputFilename
            // 
            this.L_InputFilename.AutoSize = true;
            this.L_InputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_InputFilename.Location = new System.Drawing.Point(161, 69);
            this.L_InputFilename.Name = "L_InputFilename";
            this.L_InputFilename.Size = new System.Drawing.Size(0, 24);
            this.L_InputFilename.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_InputFilename);
            this.Controls.Add(this.BTN_InputFileSelect);
            this.Name = "Form1";
            this.Text = "CSV Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_InputFileSelect;
        private System.Windows.Forms.Label L_InputFilename;
    }
}

