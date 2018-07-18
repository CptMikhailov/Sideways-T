using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT.Models
{
    public class Range
    {
        public int RangeID { get; set; }
        public int WeaponID { get; set; }
        public int? AmmoID { get; set; }
        public int RangeCatID { get; set; }
        
        public Weapon Weapon { get; set; }
        public Ammo Ammo { get; set; }
        public RangeCat RangeCat { get; set; }
    }
}
