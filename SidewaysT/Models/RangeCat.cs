using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT.Models
{
    public class RangeCat
    {
        public int RangeCatID { get; set; }
        public int Min { get; set; }
        public int Short { get; set; }
        public int Med { get; set; }
        public int? Long { get; set; }
    }
}
