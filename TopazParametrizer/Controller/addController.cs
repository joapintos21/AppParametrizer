using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopazParametrizer.Controller.Interface;
using TopazParametrizer.Logic;
using TopazParametrizer.Observer;
using File = TopazParametrizer.Logic.File;

namespace TopazParametrizer.Controller
{
    public class AddController : IObserver
    {
        AddView addView;
        HomeView homeView;
        Facade facade = Facade.getInstance();
        Field field = new Field();

        public AddController(AddView addView, HomeView homeView)
        {
            this.addView = addView;
            this.homeView = homeView;
            facade.Attach(this);
        }

        public File readFile(string path)
        {
            File result = facade.readFile(path);
            return result;
        }

        public void Update(object _event, Subject origin)
        {
            //toDo: reaccionar ante cambio en atributo para crear actualizacion dinamica
        }

        internal void saveField(String name, List<Logic.Attribute> attrList, dynamic value)
        {
            field = new Field(name, attrList, value);
            facade.addField(field);
        }
    }
}
