
namespace Windows
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_inPath = new System.Windows.Forms.TextBox();
            this.txt_OutPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_inPath
            // 
            this.txt_inPath.Location = new System.Drawing.Point(219, 222);
            this.txt_inPath.Name = "txt_inPath";
            this.txt_inPath.Size = new System.Drawing.Size(271, 20);
            this.txt_inPath.TabIndex = 1;
            // 
            // txt_OutPath
            // 
            this.txt_OutPath.Location = new System.Drawing.Point(219, 268);
            this.txt_OutPath.Name = "txt_OutPath";
            this.txt_OutPath.Size = new System.Drawing.Size(271, 20);
            this.txt_OutPath.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_OutPath);
            this.Controls.Add(this.txt_inPath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_inPath;
        private System.Windows.Forms.TextBox txt_OutPath;
    }
}

