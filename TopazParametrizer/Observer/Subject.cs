using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopazParametrizer.Observer
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver obs)
        {
            if (!observers.Contains(obs))
            {
                observers.Add(obs);
            }
        }

        public void Detach(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void Notify(Object _event)
        {
            List<IObserver> copy = new List<IObserver>(observers);
            foreach(IObserver obs in copy)
            {
                obs.Update(_event, this);
            }
        }
        

    }
}
