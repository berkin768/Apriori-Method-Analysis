using System.Windows.Forms;

namespace DataMining
{
    partial class Form2
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
        /// 
        
            
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edunumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.workClassDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.edunumDataGridViewTextBoxColumn,
            this.maritalDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.relationshipDataGridViewTextBoxColumn,
            this.raceDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.gainDataGridViewTextBoxColumn,
            this.lossDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 721);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workClassDataGridViewTextBoxColumn
            // 
            this.workClassDataGridViewTextBoxColumn.DataPropertyName = "workClass";
            this.workClassDataGridViewTextBoxColumn.HeaderText = "workClass";
            this.workClassDataGridViewTextBoxColumn.Name = "workClassDataGridViewTextBoxColumn";
            this.workClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "education";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            this.educationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edunumDataGridViewTextBoxColumn
            // 
            this.edunumDataGridViewTextBoxColumn.DataPropertyName = "edu_num";
            this.edunumDataGridViewTextBoxColumn.HeaderText = "edu_num";
            this.edunumDataGridViewTextBoxColumn.Name = "edunumDataGridViewTextBoxColumn";
            this.edunumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maritalDataGridViewTextBoxColumn
            // 
            this.maritalDataGridViewTextBoxColumn.DataPropertyName = "marital";
            this.maritalDataGridViewTextBoxColumn.HeaderText = "marital";
            this.maritalDataGridViewTextBoxColumn.Name = "maritalDataGridViewTextBoxColumn";
            this.maritalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            this.occupationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationshipDataGridViewTextBoxColumn
            // 
            this.relationshipDataGridViewTextBoxColumn.DataPropertyName = "relationship";
            this.relationshipDataGridViewTextBoxColumn.HeaderText = "relationship";
            this.relationshipDataGridViewTextBoxColumn.Name = "relationshipDataGridViewTextBoxColumn";
            this.relationshipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raceDataGridViewTextBoxColumn
            // 
            this.raceDataGridViewTextBoxColumn.DataPropertyName = "race";
            this.raceDataGridViewTextBoxColumn.HeaderText = "race";
            this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
            this.raceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gainDataGridViewTextBoxColumn
            // 
            this.gainDataGridViewTextBoxColumn.DataPropertyName = "gain";
            this.gainDataGridViewTextBoxColumn.HeaderText = "gain";
            this.gainDataGridViewTextBoxColumn.Name = "gainDataGridViewTextBoxColumn";
            this.gainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lossDataGridViewTextBoxColumn
            // 
            this.lossDataGridViewTextBoxColumn.DataPropertyName = "loss";
            this.lossDataGridViewTextBoxColumn.HeaderText = "loss";
            this.lossDataGridViewTextBoxColumn.Name = "lossDataGridViewTextBoxColumn";
            this.lossDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataSource = typeof(DataMining.Entry);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Full Data View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        


        public System.Windows.Forms.BindingSource GetBindingSource()
        {
            return entryBindingSource;
        }

        private BindingSource entryBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workClassDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edunumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maritalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn relationshipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gainDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lossDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}