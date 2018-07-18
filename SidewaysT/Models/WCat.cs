using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SidewaysT.Models
{
    public class WCat
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int WCatID { get; set; }
        [Key]
        public string Category { get; set; }

        //public ICollection<Weapon> Weapons { get; set; }
    }
}
