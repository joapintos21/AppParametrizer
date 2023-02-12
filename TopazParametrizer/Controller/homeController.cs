using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopazParametrizer.Forms;
using TopazParametrizer.Logic;

namespace TopazParametrizer.Controller
{
    public class homeController
    {
        frmHome homeForm;
        Facade facade = Facade.getInstance();

        public homeController(frmHome homeForm)
        {
            this.homeForm = homeForm;
        }
    }
}
