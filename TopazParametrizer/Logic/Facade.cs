using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopazParametrizer.Observer;

namespace TopazParametrizer.Logic
{
    internal class Facade : Subject
    {
        private static Facade instance;
        private FileSystem fileSystem = new FileSystem();

        public enum Events
        {
            updateMapping
        };


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

        internal void addField(Field field)
        {
            fileSystem.addField(field);
           
        }

        internal Mapping? getActualMapping()
        {
            return fileSystem.getSelectedMapping();
        }

        internal void startApp()
        {
            fileSystem.startApp();
        }

        internal void setAppPath(string path)
        {
            fileSystem.setAppPath(path);
        }
    }
}
