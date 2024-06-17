using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_Patterns
{
    internal class Athlete : IPerson
    {
        public string Name { get; set; }

        public bool IsAlive()
        {
            return true;
        }
    }
}
