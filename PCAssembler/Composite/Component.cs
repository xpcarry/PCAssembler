using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    public abstract class Component
    {
        public string Name { get; set; }
        public int Efficency { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public abstract int Count();
        public abstract int SumEfficency();

    }
}
