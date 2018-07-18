using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT.Models
{
    public enum AmmoTypeEnum
    {
        LRM, SRM
    }

    public class Ammo
    {
        public int AmmoID { get; set; }
        public int WeaponID { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public AmmoTypeEnum AmmoType { get; set; }

        public Weapon Weapon { get; set; }
    }
}
