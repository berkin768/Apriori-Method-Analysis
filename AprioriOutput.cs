﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMining
{
    public class AprioriOutput : Entry
    {
        public double supportValue { get; set; }

        public int fileId { get; set; }

        public string rawLine { get; set; }
    }
}
