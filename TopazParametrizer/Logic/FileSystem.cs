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
        Mapping selectedMapping;

        public FileSystem()
        {
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

        internal bool addField(Field field)
        {
            if (selectedMapping == null)
            {
                selectedMapping = new Mapping();
                mappings.Add(selectedMapping);
            }
            selectedMapping.addField(field);
            return true;
        }
    }
}
