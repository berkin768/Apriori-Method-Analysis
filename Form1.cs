using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining
{
    public partial class Frame : Form
    {
        static List<Entry> lines = null;
        public Frame()
        {
            InitializeComponent();
        }

        private void T_partNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void T_minSupport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void B_load_Click(object sender, EventArgs e)
        {
            string fileName = null;
            DialogResult result = fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                fileName = fileDialog.FileName;
                var fileReader = FileReader.Instance(fileName, progressBar);
                lines = fileReader.GetEntries;
            }
            B_fullData.Enabled = true;
            
        }

        private void B_fullData_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            var binding = form2.GetBindingSource();
            binding.DataSource = lines;
        }

        private void Frame_Load(object sender, EventArgs e)
        {
            B_fullData.Enabled = false;
            
        }
    }
}
