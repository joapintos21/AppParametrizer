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
    public class Mapping
    {
        private string runTimeId;

        private string name;
        
        private List<Field> fields = new List<Field>();

        private Launcher launcher;

        public Mapping(List<Field> fields)
        {
            this.fields = fields;
            this.launcher = new Launcher(); 
        }

        public Mapping()
        {
            this.launcher = new Launcher();
        }

        public void setLauncher(Launcher launcher){
            this.launcher = launcher;
        }

        public void runApp() {
            launcher.executeApp();
        }

        public void setAppDir(string path)
        {
            launcher.setPath(path);
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

        internal void addFields(List<Field> fields)
        {
            fields.Concat(fields);
        }

        internal IEnumerable<Field> getFields()
        {
            return fields;
        }
    }
}
