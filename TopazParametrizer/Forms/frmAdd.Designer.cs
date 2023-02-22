namespace TopazParametrizer.Forms
{
    partial class FrmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridAttributes = new System.Windows.Forms.DataGridView();
            this.clmAtributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValorActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAttributes
            // 
            this.gridAttributes.AllowUserToAddRows = false;
            this.gridAttributes.AllowUserToDeleteRows = false;
            this.gridAttributes.AllowUserToResizeRows = false;
            this.gridAttributes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAttributes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAtributo,
            this.clmValorActual,
            this.clmSeleccionar,
            this.clmFile});
            this.gridAttributes.Location = new System.Drawing.Point(12, 134);
            this.gridAttributes.MultiSelect = false;
            this.gridAttributes.Name = "gridAttributes";
            this.gridAttributes.RowHeadersVisible = false;
            this.gridAttributes.RowHeadersWidth = 51;
            this.gridAttributes.RowTemplate.Height = 29;
            this.gridAttributes.Size = new System.Drawing.Size(1021, 324);
            this.gridAttributes.TabIndex = 0;
            // 
            // clmAtributo
            // 
            this.clmAtributo.HeaderText = "Atributo";
            this.clmAtributo.MinimumWidth = 6;
            this.clmAtributo.Name = "clmAtributo";
            this.clmAtributo.ReadOnly = true;
            this.clmAtributo.Width = 125;
            // 
            // clmValorActual
            // 
            this.clmValorActual.HeaderText = "Valor actual";
            this.clmValorActual.MinimumWidth = 6;
            this.clmValorActual.Name = "clmValorActual";
            this.clmValorActual.ReadOnly = true;
            this.clmValorActual.Width = 125;
            // 
            // clmSeleccionar
            // 
            this.clmSeleccionar.HeaderText = "Seleccionar";
            this.clmSeleccionar.MinimumWidth = 6;
            this.clmSeleccionar.Name = "clmSeleccionar";
            this.clmSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmSeleccionar.Width = 125;
            // 
            // clmFile
            // 
            this.clmFile.HeaderText = "Archivo";
            this.clmFile.MinimumWidth = 6;
            this.clmFile.Name = "clmFile";
            this.clmFile.ReadOnly = true;
            this.clmFile.Width = 125;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(104, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(762, 27);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(870, 11);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(161, 29);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 464);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 29);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre:";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(17, 49);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(62, 20);
            this.lblArchivo.TabIndex = 6;
            this.lblArchivo.Text = "Archivo:";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(104, 46);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(762, 27);
            this.txtFieldName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(104, 80);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(762, 28);
            this.cboType.TabIndex = 9;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 505);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.gridAttributes);
            this.Name = "FrmAdd";
            this.Text = "Agregar campo";
            ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridAttributes;
        private TextBox txtFilePath;
        private Button btnSeleccionar;
        private Button btnGuardar;
        private Button button1;
        private Label lblName;
        private Label lblArchivo;
        private TextBox txtFieldName;
        private DataGridViewTextBoxColumn clmAtributo;
        private DataGridViewTextBoxColumn clmValorActual;
        private DataGridViewCheckBoxColumn clmSeleccionar;
        private DataGridViewTextBoxColumn clmFile;
        private Label label1;
        private ComboBox cboType;
    }
}