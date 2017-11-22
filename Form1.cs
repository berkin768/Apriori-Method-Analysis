using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining
{
    public partial class Frame : Form
    {
        static List<Entry> lines = null;
        static List<AprioriOutput> aprioriLines = null;
        FileReader fileReader = new FileReader();
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
                fileReader.ReadFile(fileName, progressBar);                  
                lines = fileReader.GetEntries().Cast<Entry>().ToList();
            }
            B_fullData.Enabled = true;
            B_supportedData.Enabled = true;
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
            B_supportedData.Enabled = false;
        }

        private void B_supportedData_Click(object sender, EventArgs e)
        {
            var aprioriProcessInfo = new ProcessStartInfo();
            aprioriProcessInfo.UseShellExecute = true;

            string supportValue = T_minSupport.Text;
            string workingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string outputFile = "output.txt";

            int index = workingDirectory.IndexOf("bin");
            if (index > 0)
            {
                workingDirectory = workingDirectory.Remove(index, 10);
            }

            if (File.Exists(workingDirectory + "/output.txt"))
            {
                File.Delete(workingDirectory + "/output.txt");
            }

            //proc1.WorkingDirectory = @"C:\Users\berki\Documents\Visual Studio 2017\Projects\DataMining\DataMining";
            aprioriProcessInfo.WorkingDirectory = workingDirectory;
            aprioriProcessInfo.FileName = @"C:\Windows\System32\cmd.exe";
            
            string command = "-s" + supportValue + " census.dat - >> " + outputFile;
            aprioriProcessInfo.Arguments = "/c apriori.exe " + command;
            
            var aprioriProcess = Process.Start(aprioriProcessInfo);
            aprioriProcess.WaitForExit();

            string fileName = outputFile;
            fileReader.ReadFile(workingDirectory + fileName);
            aprioriLines = fileReader.GetEntries().Cast<AprioriOutput>().ToList();
            List<AprioriOutput> sortedAprioriLines = aprioriLines.OrderByDescending(o => o.supportValue).ToList();


            Form3 form3 = new Form3();
            form3.Show();
            var textBox = form3.getTextBox();

            int counter = 0;
          
            foreach (var aprioriOutputLine in sortedAprioriLines) {
                string output = "";
                output += counter + " ";
                output += " SUPPORT " + aprioriOutputLine.supportValue + "  {";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.age)) ?  aprioriOutputLine.age : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.country)) ? "," + aprioriOutputLine.country : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.education)) ? "," + aprioriOutputLine.education : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.edu_num)) ? "," + aprioriOutputLine.edu_num : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.gain)) ? "," + aprioriOutputLine.gain : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.hours)) ? "," + aprioriOutputLine.hours: "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.loss)) ? "," + aprioriOutputLine.loss : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.marital)) ? "," + aprioriOutputLine.marital : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.occupation)) ? "," + aprioriOutputLine.occupation  : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.race)) ? "," + aprioriOutputLine.race  : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.relationship)) ? "," + aprioriOutputLine.relationship : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.salary)) ? "," + aprioriOutputLine.salary : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.sex)) ? "," + aprioriOutputLine.sex : "*,";
                output += (!string.IsNullOrEmpty(aprioriOutputLine.workClass)) ? "," + aprioriOutputLine.workClass : "*,";
                output += "}\n";
                counter++;

                StringBuilder sb = new StringBuilder(output);
                sb.Replace("*,", "");
                sb.Replace("{,", "{");
                output = sb.ToString();
                textBox.AppendText(output);
            }
        }
    }
}
