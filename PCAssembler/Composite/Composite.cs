using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    public class Composite : Component
    {
        public List<Component> components = new List<Component>();
        public override int Count()
        {
            int sum = 0;

            foreach (var comp in components)
            {
                sum += comp.Count();
            }
            return sum;
        }

        public override int SumEfficency()
        {
            int sum = 0;
            foreach (Component comp in components)
            {
                sum += comp.Efficency;
            }
            return sum;
        }

        public void Add(Component newComp)
        {
            components.Add(newComp);
        }

        public object[] GetNamesByType(string type)
        {

            List<object> obj = new List<object>();
            int i = 0;
            foreach (var comp in components)
            {
                if (comp.Type == type)
                {
                    obj.Add(comp.Name);
                    i++;
                }
            }
            object[] outputs = obj.ToArray();        
            return outputs;
        }

        public Component GetComponentByName(string name)
        {
            foreach (var c in components)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
            
        }


    }
}
