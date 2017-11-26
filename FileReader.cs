using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining
{
    public class FileReader
    {
        private List<Object> lines = null;
        public FileReader() {
            
        }

        public void ReadFile(string fileName, ProgressBar progressBar)
        {
            lines = new List<Object>();
            int progress = 0;
            int id = 0; //TO WRITE HEADER NUMBERS
            int size = File.ReadAllLines(fileName).Length;

            foreach (var line in File.ReadLines(fileName))
            {
                progress++;
                progressBar.Value = progress * 100 / size;
                Entry entry = new Entry();
                string[] words = line.Split(' ');

                foreach (var word in words)
                {
                    string tag = word.Split('=')[0];
                    switch (tag)
                    {
                        case "age":
                            entry.age = word.Split('=')[1];
                            break;
                        case "workclass":
                            entry.workClass = word.Split('=')[1];
                            break;
                        case "education":
                            entry.education = word.Split('=')[1];
                            break;
                        case "edu_num":
                            entry.edu_num = word.Split('=')[1];
                            break;
                        case "marital":
                            entry.marital = word.Split('=')[1];
                            break;
                        case "occupation":
                            entry.occupation = word.Split('=')[1];
                            break;
                        case "relationship":
                            entry.relationship = word.Split('=')[1];
                            break;
                        case "race":
                            entry.race = word.Split('=')[1];
                            break;
                        case "sex":
                            entry.sex = word.Split('=')[1];
                            break;
                        case "gain":
                            entry.gain = word.Split('=')[1];
                            break;
                        case "loss":
                            entry.loss = word.Split('=')[1];
                            break;
                        case "hours":
                            entry.hours = word.Split('=')[1];
                            break;
                        case "country":
                            entry.country = word.Split('=')[1];
                            break;
                    }
                    if (word.Contains("salary"))
                        entry.salary = word.Split('y')[1];//salary, after Y letter                  
                }
                entry.id = id;
                lines.Add(entry);
                id++;
            }   
        }
   
       
        public void ReadFile(string fileName) //TO READ SUPPORTED FILES
        {
            lines = new List<Object>();
            foreach (var line in File.ReadLines(fileName))
            { 
                string[] words = line.Split(' ');
                AprioriOutput aprioriEntry = new AprioriOutput();
                foreach (var word in words)
                {
                    string tag = word.Split('=')[0];
                    switch (tag)
                    {
                        case "age":
                            aprioriEntry.age = word.Split('=')[1];
                            break;
                        case "workclass":
                            aprioriEntry.workClass = word.Split('=')[1];
                            break;
                        case "education":
                            aprioriEntry.education = word.Split('=')[1];
                            break;
                        case "edu_num":
                            aprioriEntry.edu_num = word.Split('=')[1];
                            break;
                        case "marital":
                            aprioriEntry.marital = word.Split('=')[1];
                            break;
                        case "occupation":
                            aprioriEntry.occupation = word.Split('=')[1];
                            break;
                        case "relationship":
                            aprioriEntry.relationship = word.Split('=')[1];
                            break;
                        case "race":
                            aprioriEntry.race = word.Split('=')[1];
                            break;
                        case "sex":
                            aprioriEntry.sex = word.Split('=')[1];
                            break;
                        case "gain":
                            aprioriEntry.gain = word.Split('=')[1];
                            break;
                        case "loss":
                            aprioriEntry.loss = word.Split('=')[1];
                            break;
                        case "hours":
                            aprioriEntry.hours = word.Split('=')[1];
                            break;
                        case "country":
                            aprioriEntry.country = word.Split('=')[1];
                            break;
                    }
                    if (word.Contains("salary"))
                        aprioriEntry.salary = word.Split('y')[1];//salary, after Y letter 
                    if (word.Contains("("))
                    {
                        int startIndex = word.IndexOf('(') +1;
                        int endIndex = word.IndexOf(')') -1;
                        string test = word.Substring(startIndex, endIndex);
                        aprioriEntry.supportValue = Convert.ToDouble(word.Substring(startIndex, endIndex).Replace('.',','));
                    }                
                }
                aprioriEntry.rawLine = line;
                
                Console.WriteLine(fileName);
                if (fileName.Contains("CSV")) {
                    int fileId = getFileIDFromFileName(fileName);
                    aprioriEntry.fileId = fileId;
                }
                
                lines.Add(aprioriEntry);
            }
        }

        public void ReadList(List<DistinctAprioriOutput>input)
        {
            lines = new List<Object>();
            foreach (var line in input)
            {
                string[] words = line.rawLine.Split(' ');
                DistinctAprioriOutput aprioriEntry = new DistinctAprioriOutput();
                foreach (var word in words)
                {
                    string tag = word.Split('=')[0];
                    switch (tag)
                    {
                        case "age":
                            aprioriEntry.age = word.Split('=')[1];
                            break;
                        case "workclass":
                            aprioriEntry.workClass = word.Split('=')[1];
                            break;
                        case "education":
                            aprioriEntry.education = word.Split('=')[1];
                            break;
                        case "edu_num":
                            aprioriEntry.edu_num = word.Split('=')[1];
                            break;
                        case "marital":
                            aprioriEntry.marital = word.Split('=')[1];
                            break;
                        case "occupation":
                            aprioriEntry.occupation = word.Split('=')[1];
                            break;
                        case "relationship":
                            aprioriEntry.relationship = word.Split('=')[1];
                            break;
                        case "race":
                            aprioriEntry.race = word.Split('=')[1];
                            break;
                        case "sex":
                            aprioriEntry.sex = word.Split('=')[1];
                            break;
                        case "gain":
                            aprioriEntry.gain = word.Split('=')[1];
                            break;
                        case "loss":
                            aprioriEntry.loss = word.Split('=')[1];
                            break;
                        case "hours":
                            aprioriEntry.hours = word.Split('=')[1];
                            break;
                        case "country":
                            aprioriEntry.country = word.Split('=')[1];
                            break;
                    }
                    if (word.Contains("salary"))
                        aprioriEntry.salary = word.Split('y')[1];//salary, after Y letter              
                    
                }
                aprioriEntry.duplicateCount = line.duplicateCount;
                aprioriEntry.fileIDs = new List<int>();
                aprioriEntry.fileIDs = line.fileIDs;
                lines.Add(aprioriEntry);
            }
        }

        private int getFileIDFromFileName(string fileName)
        {           
            int startIndex = fileName.IndexOf("CSV") +3;           
            int endIndex = fileName.IndexOf(".txt") + 3;
            int fileId = Convert.ToInt32(fileName.Substring(startIndex, fileName.Length - endIndex));

            return fileId;
        }

        public void ReadRawFile(string fileName) {
            lines = new List<Object>();
            foreach (var line in File.ReadLines(fileName)) {
                lines.Add(line);
            }
                 
        }

        public List<Object> GetEntries()
        {
            return lines;
        }   
    }
}