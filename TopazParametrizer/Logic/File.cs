using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TopazParametrizer.Persistence;

namespace TopazParametrizer.Logic
{
    public class File
    {
        ExpandoObject data;

        string text;

        string path;

        List<Attribute> attributes = new List<Attribute>();

        public File(string path)
        {
            this.path = path;
        }

        public void readData()
        {
            this.data = jsonParser.convertText(FileManager.read(this.path));
        }

        public void readAttributes()
        {
            Attribute attributeAux;
            foreach (var property in (IDictionary<String, Object>)data)
            {
                attributeAux = new Attribute(
                                        property.Key,
                                        this,
                                        property.Value);
                attributes.Add(attributeAux);

            }
        }

        public List<Attribute> getAttributes()
        {
            return this.attributes;
        }
    }
}
