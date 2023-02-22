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
using TopazParametrizer.Controller.Interface;
using TopazParametrizer.Forms.Themes;
using TopazParametrizer.Forms.Utils;
using TopazParametrizer.Logic;
using Attribute = TopazParametrizer.Logic.Attribute;
using File = TopazParametrizer.Logic.File;

namespace TopazParametrizer.Forms
{
    public partial class FrmAdd : Form, AddView
    {
        AddController addController;
        List<Attribute> openAttributes = new List<Attribute>();
        public FrmAdd(HomeView homeView) { 
            InitializeComponent();
            this.addController = new AddController(this, homeView);
            //AppTheme
            DarkMode.applyTheme(this);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            loadFile();
        }

        void loadFile()
        {
            File file = addController.readFile(FileUtils.getFilePath());
            foreach (Logic.Attribute a in file.getAttributes())
            {
                addAttributeRow(a.getName(), a.getStringValue());
                openAttributes.Add(a);
            }
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveField();
        }

        private void saveField()
        {
            List<Attribute> attrList = new List<Attribute>();
            Attribute aux;
            int position = 0;
            foreach (DataGridViewRow dgvr in gridAttributes.Rows)
            {
                
                if (dgvr.Cells[2].Value != null)
                {
                    if ((bool)dgvr.Cells[2].Value == true)
                    {
                        aux = openAttributes[position];
                        //aux = new Attribute(dgvr.Cells[0].Value.ToString(), dgvr.Cells[1].Value.ToString());
                        attrList.Add(aux);
                    }
                }
                position++;
            }
            
            addController.saveField(txtFieldName.Text, attrList,"ValorPrueba");
            Close();
        }

        private void addAttributeRow(string name, string stringValue)
        {
            gridAttributes.Rows.Insert(0, name, stringValue, true);
        }
    }
}
