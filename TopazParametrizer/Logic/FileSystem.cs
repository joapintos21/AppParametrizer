using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopazParametrizer.Persistence;

namespace TopazParametrizer.Logic
{
    public class FileSystem
    {

        List<File> files = new List<File>();
        List<Mapping> mappings = new List<Mapping>();
        Mapping selectedMapping = new Mapping();

        public FileSystem()
        {
            mappings.Add(selectedMapping);
        }

        public Mapping getSelectedMapping()
        {
            if(selectedMapping == null)
            {
                selectedMapping = new Mapping();
                mappings.Add(selectedMapping);
            }
            return this.selectedMapping;
        }

        public void setMapping(Mapping mapping)
        {
            this.selectedMapping = mapping;

        }

        public File readFile(string path)
        {
            File file = new File(path);
            file.readData();
            file.readAttributes();
            files.Add(file);
            return file;
        }

        public List<File> getFiles()
        {
            return files;
        }

        internal void addField(Field field)
        {
            if (selectedMapping == null)
            {
                selectedMapping = new Mapping();
                mappings.Add(selectedMapping);
            }
            selectedMapping.addField(field);
            Facade.getInstance().Notify(Facade.Events.updateMapping);
        }

        internal void startApp()
        {
            getSelectedMapping().runApp();
        }

        internal void setAppPath(string path)
        {
            getSelectedMapping().setAppDir(path);
        }
    }
}
