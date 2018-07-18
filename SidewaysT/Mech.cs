using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT
{
    public class Mech
    {
        private partial class MechWeapon { };
        private partial class MechPart { };

        private readonly string name;

        public Mech(string input)
        {
            name = input;
        }
    }
}
