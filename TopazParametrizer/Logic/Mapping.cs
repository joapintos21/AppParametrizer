using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TopazParametrizer.Logic
{
    internal class Mapping
    {
        private string runTimeId;

        private string name;
        
        private List<Field> fields = new List<Field>();

        public Mapping(List<Field> fields)
        {
            this.fields = fields;
        }

        public Mapping()
        {
        }

        public void addField(Field field)
        {
            fields.Add(field);
        }

        public void removeField(Field field)
        {
            fields.Remove(field);
        }

        public void existsField(Field field)
        {
            fields.Contains(field);
        }
    }
}
