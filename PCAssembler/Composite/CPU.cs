using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    class CPU : Component
    {
        public override int Count()
        {
            return 1;
        }

        public override int SumEfficency()
        {
            return this.Efficency;
        }
    }
}
