namespace DataMining
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.T_outputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // T_outputBox
            // 
            this.T_outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T_outputBox.Location = new System.Drawing.Point(0, -1);
            this.T_outputBox.Name = "T_outputBox";
            this.T_outputBox.ReadOnly = true;
            this.T_outputBox.Size = new System.Drawing.Size(881, 454);
            this.T_outputBox.TabIndex = 0;
            this.T_outputBox.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.T_outputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Data With Support";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RichTextBox getTextBox()
        {
            return T_outputBox;
        }

        private System.Windows.Forms.RichTextBox T_outputBox;
    }
}