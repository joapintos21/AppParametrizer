using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopazParametrizer.Logic
{
    internal class Facade
    {
        private static Facade instance;
        private FileSystem fileSystem = new FileSystem();

        public static Facade getInstance()
        {
            if (instance == null)
            {
                instance = new Facade();

            }
            return instance;
        }

        public File readFile(string path)
        {
            return fileSystem.readFile(path);   
        }

        public List<File> getFiles()
        {
            return fileSystem.getFiles();
        }

        internal bool addField(Field field)
        {
            return fileSystem.addField(field);
        }
    }
}
