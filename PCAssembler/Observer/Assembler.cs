using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    class Assembler : Subject
    {
        public List<Component> displayedComps = new List<Component>();

        public void AddAsset(Component comp)
        {
            base.AddComponent(comp);
            displayedComps.Add(comp);   
        }

        public void RemoveAsset(Component comp)
        {
            base.RemoveComponent(comp);
            displayedComps.Remove(comp);
            displayedComps.TrimExcess();
        }
    }
}
