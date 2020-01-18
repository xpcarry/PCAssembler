using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    public class Subject
    {

        private List<IObserver> _observers = new List<IObserver>();
        public void AddObserver(IObserver newObs)
        {
            _observers.Add(newObs);
        }
        public void RemoveObserver(IObserver obs)
        {
            _observers.Remove(obs);
            _observers.TrimExcess();
        }
        public void AddComponent(Component comp)
        {
            foreach (var observer in _observers)
            {
                observer.Update(comp, actionCode: 1);
            }
        }

        public void RemoveComponent(Component comp)
        {
            foreach (var observer in _observers)
            {
                observer.Update(comp, actionCode: 2);
            }
        }

    }
}
