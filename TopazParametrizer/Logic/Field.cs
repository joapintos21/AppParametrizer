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

        private dynamic value;

        public Field(string name, List<Attribute> attributes, dynamic value)
        {
            this.name = name;
            this.attributes = attributes;
            this.value = value;
        }

        public Field()
        {
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

        public void setValue(dynamic value)
        {
            this.value = value;
        }

        public dynamic getValue()
        {
            return value;
        }
    }
}
