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
        static List<String> rawData = null;
        FileReader fileReader = new FileReader();
        static string fileName = null;

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

            if (T_partNumber.Text.Length >= 2)
            {
                int acceptednumber = Convert.ToInt32(T_partNumber.Text);
                if (acceptednumber < 0)
                {
                    e.Handled = true;
                }
                else
                {
                    T_partNumber.Text = T_partNumber.Text;
                }
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
            fileName = null;
            DialogResult result = fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                fileName = fileDialog.FileName;
                fileReader.ReadFile(fileName, progressBar);
                lines = fileReader.GetEntries().Cast<Entry>().ToList();
            }
            B_fullData.Enabled = true;
            B_supportedData.Enabled = true;
            B_seperatedData.Enabled = true;
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
            B_seperatedData.Enabled = false;
        }

        private void B_supportedData_Click(object sender, EventArgs e)
        {
            var aprioriProcessInfo = new ProcessStartInfo();
            aprioriProcessInfo.UseShellExecute = true;

            string supportValue = T_minSupport.Text;
            string workingDirectory = getDirectory();
            string outputFile = "output.txt";

            deleteFile(outputFile);

            //proc1.WorkingDirectory = @"C:\Users\berki\Documents\Visual Studio 2017\Projects\DataMining\DataMining";
            aprioriProcessInfo.WorkingDirectory = workingDirectory;
            aprioriProcessInfo.FileName = @"C:\Windows\System32\cmd.exe";

            string command = "-s" + supportValue + " census.dat - >> " + outputFile;
            aprioriProcessInfo.Arguments = "/c apriori.exe " + command;

            var aprioriProcess = Process.Start(aprioriProcessInfo);
            aprioriProcess.WaitForExit();


            fileReader.ReadFile(workingDirectory + outputFile);
            aprioriLines = fileReader.GetEntries().Cast<AprioriOutput>().ToList();
            List<AprioriOutput> sortedAprioriLines = aprioriLines.OrderByDescending(o => o.supportValue).ToList();


            Form3 form3 = new Form3();
            form3.Show();
            var textBox = form3.getTextBox();


            printAprioriOutputListToRichText(sortedAprioriLines, textBox);
        }

        private void printAprioriOutputListToRichText(List<AprioriOutput> input,RichTextBox textBox)
        {
            int counter = 1;
            foreach (var line in input)
            {
                string output = "";
                output += counter + " ";
                output += " SUPPORT " + line.supportValue + "  {";
                output += (!string.IsNullOrEmpty(line.age)) ? line.age : "*,";
                output += (!string.IsNullOrEmpty(line.country)) ? "," + line.country : "*,";
                output += (!string.IsNullOrEmpty(line.education)) ? "," + line.education : "*,";
                output += (!string.IsNullOrEmpty(line.edu_num)) ? "," + line.edu_num : "*,";
                output += (!string.IsNullOrEmpty(line.gain)) ? "," + line.gain : "*,";
                output += (!string.IsNullOrEmpty(line.hours)) ? "," + line.hours : "*,";
                output += (!string.IsNullOrEmpty(line.loss)) ? "," + line.loss : "*,";
                output += (!string.IsNullOrEmpty(line.marital)) ? "," + line.marital : "*,";
                output += (!string.IsNullOrEmpty(line.occupation)) ? "," + line.occupation : "*,";
                output += (!string.IsNullOrEmpty(line.race)) ? "," + line.race : "*,";
                output += (!string.IsNullOrEmpty(line.relationship)) ? "," + line.relationship : "*,";
                output += (!string.IsNullOrEmpty(line.salary)) ? "," + line.salary : "*,";
                output += (!string.IsNullOrEmpty(line.sex)) ? "," + line.sex : "*,";
                output += (!string.IsNullOrEmpty(line.workClass)) ? "," + line.workClass : "*,";
                output += "}\n";
                counter++;

                StringBuilder sb = new StringBuilder(output);
                sb.Replace("*,", "");
                sb.Replace("{,", "{");
                output = sb.ToString();
                textBox.AppendText(output);
            }
        }

        private void printDistinctAprioriOutputListToRichText(List<DistinctAprioriOutput> input, RichTextBox textBox)
        {
            int counter = 1;
            foreach (var line in input)
            {
                string output = "";
                output += counter + " ";
                output += "{";
                output += (!string.IsNullOrEmpty(line.age)) ? line.age : "*,";
                output += (!string.IsNullOrEmpty(line.country)) ? "," + line.country : "*,";
                output += (!string.IsNullOrEmpty(line.education)) ? "," + line.education : "*,";
                output += (!string.IsNullOrEmpty(line.edu_num)) ? "," + line.edu_num : "*,";
                output += (!string.IsNullOrEmpty(line.gain)) ? "," + line.gain : "*,";
                output += (!string.IsNullOrEmpty(line.hours)) ? "," + line.hours : "*,";
                output += (!string.IsNullOrEmpty(line.loss)) ? "," + line.loss : "*,";
                output += (!string.IsNullOrEmpty(line.marital)) ? "," + line.marital : "*,";
                output += (!string.IsNullOrEmpty(line.occupation)) ? "," + line.occupation : "*,";
                output += (!string.IsNullOrEmpty(line.race)) ? "," + line.race : "*,";
                output += (!string.IsNullOrEmpty(line.relationship)) ? "," + line.relationship : "*,";
                output += (!string.IsNullOrEmpty(line.salary)) ? "," + line.salary : "*,";
                output += (!string.IsNullOrEmpty(line.sex)) ? "," + line.sex : "*,";
                output += (!string.IsNullOrEmpty(line.workClass)) ? "," + line.workClass : "*,";
                output += "} ";
                foreach(var fileId in line.fileIDs)
                {
                    output += fileId + ", ";
                }
                output += "\n";
                counter++;

                StringBuilder sb = new StringBuilder(output);
                sb.Replace("*,", "");
                sb.Replace("{,", "{");
                output = sb.ToString();
                textBox.AppendText(output);
            }
        }

        private void B_seperatedData_Click(object sender, EventArgs e)
        {
            fileReader.ReadRawFile(fileName);
            rawData = fileReader.GetEntries().Cast<string>().ToList();

            seperateFile(rawData);
            getSupportValuesFromFiles();
            analyseSupportedFiles();
        }


        private void getSupportValuesFromFiles()
        {
            string filesToDelete = @"outputCSV*.txt";
            deleteFile(filesToDelete);            

            string filesToProcess = @"census*.csv";
            int fileId = 1;
            string workingDirectory = getDirectory();
            string[] fileList = Directory.GetFiles(workingDirectory, filesToProcess);

            foreach (string file in fileList)
            {
                var aprioriProcessInfo = new ProcessStartInfo();
                aprioriProcessInfo.UseShellExecute = true;

                string supportValue = T_minSupport.Text;                
                string outputFile = "outputCSV" + fileId + ".txt";

                //proc1.WorkingDirectory = @"C:\Users\berki\Documents\Visual Studio 2017\Projects\DataMining\DataMining";
                aprioriProcessInfo.WorkingDirectory = workingDirectory;
                aprioriProcessInfo.FileName = @"C:\Windows\System32\cmd.exe";

                string command = "-s" + supportValue + " census" + fileId + ".csv" + " - >> " + outputFile;
                aprioriProcessInfo.Arguments = "/c apriori.exe " + command;

                var aprioriProcess = Process.Start(aprioriProcessInfo);
                aprioriProcess.WaitForExit();
                fileId++;
            }
        }

        private void analyseSupportedFiles()
        {
            string workingDirectory = getDirectory();
            string filesToProcess = @"outputCSV*.txt";
            string[] fileList = Directory.GetFiles(workingDirectory, filesToProcess);

            List<AprioriOutput> supportedFiles = new List<AprioriOutput>();

            foreach(var file in fileList){
                fileReader.ReadFile(file);
                supportedFiles.AddRange(fileReader.GetEntries().Cast<AprioriOutput>().ToList());
            }
            
            List<DistinctAprioriOutput> distinctAprioriOutput = findDuplicate(supportedFiles);
            fileReader.ReadList(distinctAprioriOutput);
            distinctAprioriOutput = fileReader.GetEntries().Cast<DistinctAprioriOutput>().ToList();


            Form4 form4 = new Form4();
            form4.Show();
            var textBox = form4.getTextBox();

            printDistinctAprioriOutputListToRichText(distinctAprioriOutput,textBox);
        }

        private List<DistinctAprioriOutput> findDuplicate(List <AprioriOutput> input)
        {
            foreach(var line in input)
            {
                int idx = line.rawLine.IndexOf(" (");
                if (idx > -1)
                    line.rawLine = line.rawLine.Remove(idx);
            }

            int treshold = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(T_partNumber.Text) / 2));

            var query = input.GroupBy(x => x.rawLine)
              .Where(g => g.Count() >= treshold)
              .Select(y => new {Value = y, Count = y.Count() })
              .ToList();


            List<DistinctAprioriOutput> distinctAprioriOutputs = new List<DistinctAprioriOutput>();
            foreach (var element in query)
            {
                var distinctAprioriOutput = new DistinctAprioriOutput();
                distinctAprioriOutput.fileIDs = new List<int>();
                foreach (var ids in element.Value.ToList())
                {
                    distinctAprioriOutput.fileIDs.Add(ids.fileId);
                }

                distinctAprioriOutput.rawLine = element.Value.First().rawLine;
                distinctAprioriOutput.duplicateCount = element.Count;

                distinctAprioriOutputs.Add(distinctAprioriOutput);
            }

            return distinctAprioriOutputs;
        }

        //---------------------------BELOW FUNCTIONS TO SEPERATE CSV FILES INTO ONE .DAT FILE------------------------
        private void deleteFile(string fileToDelete)
        {
            string workingDirectory = getDirectory();
            string[] fileList = Directory.GetFiles(workingDirectory, fileToDelete);
            foreach (string file in fileList)
            {
                File.Delete(file);
            }
        }

        private void seperateFile(List<string> rawData)
        {
            string filesToDelete = @"census*.csv";
            deleteFile(filesToDelete);

            double partNumber = Convert.ToDouble(T_partNumber.Text);
            double fileSize = rawData.Count;

            int indexSize = Convert.ToInt32(Math.Ceiling(fileSize / partNumber));

            string workingDirectory = getDirectory();

            progressSeperated.Value = 0;
            int progress = 0;
            for (int i = 1; i <= partNumber; i++)
            {
                string fileName = workingDirectory + "census" + i + ".csv";
                List<String> seperatedList = seperateList(rawData, indexSize, i);

                CreateCSVFile(seperatedList, fileName);
                progress += 100 / Convert.ToInt32(partNumber);
                progressSeperated.Value = progress;
            }
        }

        private List<string> seperateList(List<string> input, int splitSize, int loopIndex)
        {
            int endIndex = splitSize * loopIndex;  //For example 1000*2. This means seperate array by 2000-1000 For example
            int startIndex = endIndex - splitSize;  //endIndex = 2000, startIndex = 1000 for example

            List<string> output = new List<string>();
            for (int i = startIndex; i < endIndex; i++)
            {
                if (input.Count > i)
                    output.Add(input.ElementAt(i));
            }

            return output;
        }

        private string getDirectory()
        {
            string workingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            int index = workingDirectory.IndexOf("bin");
            if (index > 0)
            {
                workingDirectory = workingDirectory.Remove(index, 10);
            }

            return workingDirectory;
        }

        private void CreateCSVFile(List<String> input, string fileName)
        {

            StreamWriter sw = new StreamWriter(fileName);
            foreach (var line in input)
            {
                string outputLine = line.Replace(' ', ',');

                sw.WriteLine(outputLine);
            }
            sw.Flush();
            sw.Close();
        }
    }
}