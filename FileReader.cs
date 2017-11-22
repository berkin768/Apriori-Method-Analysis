using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMining
{
    public sealed class FileReader
    {
        private FileReader()
        {
        }
        private static FileReader fileReader = null;
        public static FileReader Instance
        {
            get
            {
                if (fileReader == null)
                {
                    fileReader = new FileReader();
                }
                return fileReader;
            }
        }
    }
}