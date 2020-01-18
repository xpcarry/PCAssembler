using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    public interface IObserver
    {
        void Update(Component comp, int actionCode);
    }
}
