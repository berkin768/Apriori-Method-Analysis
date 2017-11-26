namespace DataMining
{
    partial class Frame
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
            this.B_load = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.T_minSupport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.B_fullData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.B_supportedData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.B_seperatedData = new System.Windows.Forms.Button();
            this.progressSeperated = new System.Windows.Forms.ProgressBar();
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
            this.T_partNumber.Text = "1";
            this.T_partNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_partNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_partNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Load Data";
            // 
            // B_load
            // 
            this.B_load.Location = new System.Drawing.Point(308, 94);
            this.B_load.Name = "B_load";
            this.B_load.Size = new System.Drawing.Size(75, 23);
            this.B_load.TabIndex = 3;
            this.B_load.Text = "Load";
            this.B_load.UseVisualStyleBackColor = true;
            this.B_load.Click += new System.EventHandler(this.B_load_Click);
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
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(296, 123);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            this.progressBar.Tag = "";
            // 
            // T_minSupport
            // 
            this.T_minSupport.Location = new System.Drawing.Point(63, 151);
            this.T_minSupport.Name = "T_minSupport";
            this.T_minSupport.Size = new System.Drawing.Size(100, 22);
            this.T_minSupport.TabIndex = 7;
            this.T_minSupport.Text = "20";
            this.T_minSupport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "See Full Data";
            // 
            // B_fullData
            // 
            this.B_fullData.Location = new System.Drawing.Point(511, 87);
            this.B_fullData.Name = "B_fullData";
            this.B_fullData.Size = new System.Drawing.Size(90, 29);
            this.B_fullData.TabIndex = 9;
            this.B_fullData.Text = "View Full";
            this.B_fullData.UseVisualStyleBackColor = true;
            this.B_fullData.Click += new System.EventHandler(this.B_fullData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data With Support";
            // 
            // B_supportedData
            // 
            this.B_supportedData.Location = new System.Drawing.Point(511, 153);
            this.B_supportedData.Name = "B_supportedData";
            this.B_supportedData.Size = new System.Drawing.Size(90, 29);
            this.B_supportedData.TabIndex = 11;
            this.B_supportedData.Text = "View Data";
            this.B_supportedData.UseVisualStyleBackColor = true;
            this.B_supportedData.Click += new System.EventHandler(this.B_supportedData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Support In Seperated Data";
            // 
            // B_seperatedData
            // 
            this.B_seperatedData.Location = new System.Drawing.Point(511, 219);
            this.B_seperatedData.Name = "B_seperatedData";
            this.B_seperatedData.Size = new System.Drawing.Size(90, 29);
            this.B_seperatedData.TabIndex = 13;
            this.B_seperatedData.Text = "View Data";
            this.B_seperatedData.UseVisualStyleBackColor = true;
            this.B_seperatedData.Click += new System.EventHandler(this.B_seperatedData_Click);
            // 
            // progressSeperated
            // 
            this.progressSeperated.Location = new System.Drawing.Point(500, 254);
            this.progressSeperated.Name = "progressSeperated";
            this.progressSeperated.Size = new System.Drawing.Size(112, 23);
            this.progressSeperated.TabIndex = 14;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 401);
            this.Controls.Add(this.progressSeperated);
            this.Controls.Add(this.B_seperatedData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.B_supportedData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.B_fullData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.T_minSupport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_partNumber);
            this.Controls.Add(this.label1);
            this.Name = "Frame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox T_partNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox T_minSupport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_fullData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_supportedData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B_seperatedData;
        private System.Windows.Forms.ProgressBar progressSeperated;
    }
}

