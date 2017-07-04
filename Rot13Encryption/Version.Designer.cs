namespace Rot13Encryption
{
    partial class Version
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version));
            this.lblVerTxt = new System.Windows.Forms.Label();
            this.lblVerVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVerTxt
            // 
            this.lblVerTxt.AutoSize = true;
            this.lblVerTxt.Location = new System.Drawing.Point(12, 11);
            this.lblVerTxt.Name = "lblVerTxt";
            this.lblVerTxt.Size = new System.Drawing.Size(48, 13);
            this.lblVerTxt.TabIndex = 0;
            this.lblVerTxt.Text = "Version: ";
            // 
            // lblVerVal
            // 
            this.lblVerVal.AutoSize = true;
            this.lblVerVal.Location = new System.Drawing.Point(12, 24);
            this.lblVerVal.Name = "lblVerVal";
            this.lblVerVal.Size = new System.Drawing.Size(23, 13);
            this.lblVerVal.TabIndex = 1;
            this.lblVerVal.Text = "null";
            // 
            // Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 57);
            this.Controls.Add(this.lblVerVal);
            this.Controls.Add(this.lblVerTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Version";
            this.Text = "Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerTxt;
        private System.Windows.Forms.Label lblVerVal;
    }
}