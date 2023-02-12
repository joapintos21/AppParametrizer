using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopazParametrizer.Forms.Themes
{
    public static class DarkMode
    {

        public static void applyTheme(Form form)
        {
            form.BackColor = Color.FromArgb(34,36,49);
            changeLabelColors(form.Controls, Color.White);
        }

        public static void changeLabelColors(Control.ControlCollection controls, Color color)
        {
            foreach (Control c in controls)
            {
                if (c is Label)
                    c.ForeColor = color;
            }
        }
    }
}
