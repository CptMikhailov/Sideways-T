using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT.Models
{
    public class AmmoVolley
    {
        public int AmmoVolleyID { get; set; }
        public int WeaponID { get; set; }
        public int Volley { get; set; }

        public Weapon Weapon { get; set; }
    }
}
