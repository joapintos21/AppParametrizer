using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopazParametrizer.Forms;
using TopazParametrizer.Logic;
using File = TopazParametrizer.Logic.File;

namespace TopazParametrizer.Controller
{
    public class addController
    {
        frmAdd addForm;
        Facade facade = Facade.getInstance();
        Field field;

        public addController(frmAdd addForm)
        {
            this.addForm = addForm;
        }

        public void readFile(string path)
        {
            File result = facade.readFile(path);
            foreach(Logic.Attribute a in result.getAttributes())
                addForm.agregarValorAlGird(a.getName(), a.getStringValue(), "");
        }

        internal void saveField(String name, List<Logic.Attribute> attrList)
        {
            field = new Field(name,attrList);
            facade.addField(field);
        }
    }
}
