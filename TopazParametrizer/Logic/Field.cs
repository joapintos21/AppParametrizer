using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopazParametrizer.Logic
{
    public class Field
    {
        private string name;

        private List<Attribute> attributes = new List<Attribute>();

        public Field(string name, List<Attribute> attributes)
        {
            this.name = name;
            this.attributes = attributes;
        }

        public string getName()
        {
            return name;
        }

        public List<Attribute> getAttributes()
        {
            return attributes;
        }

        public void setName()
        {
            name = name.Trim(); 
        }

        public void addAttributes(Attribute a)
        {
            attributes.Add(a);
        }
    }
}
