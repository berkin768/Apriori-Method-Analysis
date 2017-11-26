using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMining
{
    public class DistinctAprioriOutput : AprioriOutput
    {
        public List<int> fileIDs { get; set; }

        public int duplicateCount { get; set; }
    }
}
