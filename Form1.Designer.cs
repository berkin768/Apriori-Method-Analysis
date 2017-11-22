namespace DataMining
{
    partial class B_load
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.T_partNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.T_minSupport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Parts";
            // 
            // T_partNumber
            // 
            this.T_partNumber.Location = new System.Drawing.Point(63, 94);
            this.T_partNumber.Name = "T_partNumber";
            this.T_partNumber.Size = new System.Drawing.Size(100, 22);
            this.T_partNumber.TabIndex = 1;
            this.T_partNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_partNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_partNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Load Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "PARAMETERS";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(326, 123);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // T_minSupport
            // 
            this.T_minSupport.Location = new System.Drawing.Point(63, 151);
            this.T_minSupport.Name = "T_minSupport";
            this.T_minSupport.ReadOnly = true;
            this.T_minSupport.Size = new System.Drawing.Size(100, 22);
            this.T_minSupport.TabIndex = 7;
            this.T_minSupport.Text = "20";
            this.T_minSupport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_minSupport.TextChanged += new System.EventHandler(this.T_minSupport_TextChanged);
            this.T_minSupport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_minSupport_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Minimum Support (%)";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // B_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 401);
            this.Controls.Add(this.T_minSupport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_partNumber);
            this.Controls.Add(this.label1);
            this.Name = "B_load";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox T_partNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox T_minSupport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}

