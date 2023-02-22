using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopazParametrizer.Forms.Utils
{
    internal static class FileUtils
    {
        //Metodo para abrir archivos
        internal static string getFilePath()
        {
            string result = "";
            using (var fd = new OpenFileDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    result = fd.FileName;
                }
            }
            return result;
        }
    }
}
