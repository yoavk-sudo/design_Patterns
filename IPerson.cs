﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace design_Patterns
{
    internal interface IPerson
    {
        public string Name { get; set; }
        public bool IsAlive();
    }
}
