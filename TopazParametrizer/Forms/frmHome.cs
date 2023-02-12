using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopazParametrizer.Controller;
using TopazParametrizer.Forms.Themes;

namespace TopazParametrizer.Forms
{
    public partial class frmHome : Form
    {
        homeController controller;
        public frmHome()
        {
            InitializeComponent();
            controller = new homeController(this);
            //AppTheme
            DarkMode.applyTheme(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAdd().ShowDialog();
        }
    }
}
