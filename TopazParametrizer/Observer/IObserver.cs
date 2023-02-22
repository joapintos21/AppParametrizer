using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopazParametrizer.Observer
{
    public interface IObserver
    {
        public void Update(Object _event, Subject origin);
    }
}