using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SidewaysT.Models
{
    public class Weapon
    {    
        public int WeaponID { get; set; }
        public string Item { get; set; }
        public string Category { get; set; }
        public int Modifier { get; set; }

        //public ICollection<TypeDef> Types { get; set; }
        //public ICollection<Range> Range { get; set; }
        //public WCat WCat { get; set; }
    }
}
