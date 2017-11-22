using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining
{
    public class FileReader
    {
        private static FileReader fileReader = null;
        
        private static List<Entry> lines = null;
        private FileReader() { }

        public static FileReader Instance(string fileName, ProgressBar progressBar)
        {
            if (fileReader == null)
            {
                Create(fileName, progressBar);
            }
            return fileReader;

        }

        private static void Create(string fileName, ProgressBar progressBar)
        {
            if (fileReader != null)
            {
                throw new Exception("Object already created");
            }
            lines = new List<Entry>();
            fileReader = new FileReader();
            ReadFile(fileName, progressBar);
        }

        private static void ReadFile(string fileName, ProgressBar progressBar)
        {
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
                    if(word.Contains("salary"))
                        entry.salary = word.Split('y')[1];//salary, after Y letter                  
                }
                entry.id = id;
                lines.Add(entry);
                id++;
            }
                    
            Console.WriteLine(lines); // <-- Shows file size in debugging mode.
        }

        public List<Entry> GetEntries
        {
            get { return lines; }
            set { }
        }
    }
}