using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TopazParametrizer.Logic
{
    public class Attribute
    {
        private int id;

        private string Name;

        private File file;

        private dynamic value;

        //Evaluar crear atributo tipo combobox seleccionable

        public Attribute(String name, File file, dynamic value)
        {
            this.Name = name;
            this.file = file;
            this.value = value;
        }

        public Attribute(String name, dynamic value)
        {
            this.Name = name;
            this.value = value;
        }

        public string getName() {
            return this.Name;
        }

        public void setName(String name)
        {
            this.Name = name;
        }

        public string getStringValue()
        {
            return Convert.ToString(this.value);
        }

        public void setValue(dynamic value)
        {
            this.value = value;
        }

        public File getFile()
        {
            return this.getFile();
        }

        public void setFile(File file)
        {
            this.file = file;
        }
    }
}
