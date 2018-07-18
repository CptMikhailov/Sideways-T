using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SidewaysT.Models
{
    public class TypeDef
    {
        public int TypeDefID { get; set; }
        public string WType { get; set; }
        public string Name { get; set; }
    }
}
