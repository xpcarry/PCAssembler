using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    class PriceIndicator : IObserver
    {
        public double TotalPrice { get; set; }
        public void Update(Component comp, int actionCode)
        {
            if (actionCode == 1)
            {
                TotalPrice += comp.Price;
            }
            else if (actionCode == 2)
            {
                TotalPrice -= comp.Price;
            }

        }
    }
}
