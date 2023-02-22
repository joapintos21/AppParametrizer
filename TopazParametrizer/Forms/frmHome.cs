using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using System.Windows.Forms;
using TopazParametrizer.Controller;
using TopazParametrizer.Controller.Interface;
using TopazParametrizer.Forms.Themes;
using TopazParametrizer.Forms.Utils;
using TopazParametrizer.Logic;

namespace TopazParametrizer.Forms
{
    public partial class FrmHome : Form, HomeView
    {
        HomeController controller;
        public FrmHome()
        {
            InitializeComponent();
            controller = new HomeController(this);
            showMapping();
            //AppTheme
            DarkMode.applyTheme(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmAdd(this).ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            controller.startApp();
        }

        private void btnSetAppPath_Click(object sender, EventArgs e)
        {
            setAppPath();
        }

        private void setAppPath()
        {
            string path = FileUtils.getFilePath();
            if (!path.IsEmpty())
                controller.setAppPath(path);
        }

        public void addFieldRow(Field field)
        {
           gridFields.Rows.Insert(0, field.getName(), field.getValue());
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {

        }

        private void showFields()
        {
            IEnumerable<Field> fields = new List<Field>(controller.getMappingFields());
            //Solucionar problema en el que se repiten los valores en los Fields
            gridFields.DataSource = null;
            foreach (Field f in fields)
            {
                addFieldRow(f);
            }
        }

        public void showMapping()
        {
            
            showFields();
        }
    }
}
