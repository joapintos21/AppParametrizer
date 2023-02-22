using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;

namespace TopazParametrizer.Logic
{
    public class Launcher
    {
        private string path;
        public Launcher()
        {
            path = "";
        }

        public string getPath() { return path; }

        public void setPath(string path) { this.path = path; }

        public void executeApp()
        {
            if (path != null)
                if (!this.path.IsEmpty())            
                    Process.Start(this.path);
        }
    }
}
