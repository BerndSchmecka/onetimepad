namespace OneTimePad
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.rtbCipher = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtbHexInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(378, 96);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // rtbCode
            // 
            this.rtbCode.Location = new System.Drawing.Point(396, 142);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(392, 96);
            this.rtbCode.TabIndex = 1;
            this.rtbCode.Text = "";
            // 
            // rtbCipher
            // 
            this.rtbCipher.Location = new System.Drawing.Point(12, 292);
            this.rtbCipher.Name = "rtbCipher";
            this.rtbCipher.Size = new System.Drawing.Size(776, 96);
            this.rtbCipher.TabIndex = 2;
            this.rtbCipher.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 142);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // rtbHexInput
            // 
            this.rtbHexInput.Enabled = false;
            this.rtbHexInput.Location = new System.Drawing.Point(396, 12);
            this.rtbHexInput.Name = "rtbHexInput";
            this.rtbHexInput.Size = new System.Drawing.Size(392, 96);
            this.rtbHexInput.TabIndex = 4;
            this.rtbHexInput.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbHexInput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rtbCipher);
            this.Controls.Add(this.rtbCode);
            this.Controls.Add(this.rtbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.RichTextBox rtbCipher;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rtbHexInput;
    }
}

