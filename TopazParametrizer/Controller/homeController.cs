using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopazParametrizer.Controller.Interface;
using TopazParametrizer.Logic;
using TopazParametrizer.Observer;

namespace TopazParametrizer.Controller
{
    public class HomeController : IObserver
    {
        HomeView homeView;
        Facade facade = Facade.getInstance();
        Mapping actualMapping = new Mapping();
        public HomeController(HomeView homeView)
        {
            this.homeView = homeView;
            facade.Attach(this);
        }

        internal void setAppPath(string path)
        {
            facade.setAppPath(path);
        }

        internal void startApp()
        {
            facade.startApp();
        }

        public void showMapping()
        {
            UpdateMapping();
            homeView.showMapping();   
        }

        public IEnumerable<Field> getMappingFields()
        {
            return actualMapping.getFields();
        }

        public void Update(object _event, Subject origin)
        {
            if (_event.Equals(Facade.Events.updateMapping))
            {
                showMapping();
            }
        }

        private void UpdateMapping()
        {
            actualMapping = facade.getActualMapping();
        }
    }
}
