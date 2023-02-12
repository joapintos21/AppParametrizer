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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Attribute = TopazParametrizer.Logic.Attribute;

namespace TopazParametrizer.Forms
{
    public partial class frmAdd : Form
    {
        addController addController;
        public frmAdd()
        {
            InitializeComponent();
            this.addController = new addController(this);
            //AppTheme
            DarkMode.applyTheme(this);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            addController.readFile(getFilePath());
        }

        //Crear ENUM para tipos de atributo
        public void agregarValorAlGird(string nombreAtributo, string valorActual, string tipo)
        {
            gridAttributes.Rows.Insert(0,nombreAtributo,valorActual, true, null);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveField();
        }

        private void saveField()
        {
            string verdadero = "";
            List<Attribute> attrList = new List<Attribute>();
            Attribute aux;
            foreach (DataGridViewRow dgvr in gridAttributes.Rows)
            {
                if (dgvr.Cells[2].Value == "")
                {
                    aux = new Attribute(dgvr.Cells[0].Value.ToString(), dgvr.Cells[1].Value.ToString());
                    attrList.Add(aux);
                }
            }
            addController.saveField(txtFieldName.Text, attrList);
        }

        //Metodo para abrir archivos
        private string getFilePath()
        {
            string result = "";
            using (var fd = new OpenFileDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    result = fd.FileName;
                    txtFilePath.Text = result;
                }
            }
            return result;
        }
    }
}
