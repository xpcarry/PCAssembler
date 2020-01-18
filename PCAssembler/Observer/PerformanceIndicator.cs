using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    class PerformanceIndicator : IObserver
    {
        private double _currentPerformance;

        public double CurrentPerformance
        {
            get 
            { 
                return _currentPerformance; 
            }
            set 
            {
                if (value > 100)
                {
                    throw new Exception(message: "Przekroczona wartosć maksymalna");
                }
                else
                _currentPerformance = value; 
            }
        }

        public void Update(Component comp, int actionCode)
        {
            if (actionCode == 1)
            {
                CurrentPerformance += comp.Efficency;
            }
            if (actionCode == 2)
            {
                CurrentPerformance -= comp.Efficency;
            }
        }
    }
}
