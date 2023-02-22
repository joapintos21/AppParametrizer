namespace TopazParametrizer.Forms
{
    partial class FrmHome
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridFields = new System.Windows.Forms.DataGridView();
            this.clmAtributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApplyConfiguration = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNewMapping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSetAppPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(460, 635);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar atributos";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridFields
            // 
            this.gridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAtributo,
            this.clmValor});
            this.gridFields.Location = new System.Drawing.Point(12, 118);
            this.gridFields.Name = "gridFields";
            this.gridFields.RowHeadersWidth = 51;
            this.gridFields.RowTemplate.Height = 29;
            this.gridFields.Size = new System.Drawing.Size(891, 511);
            this.gridFields.TabIndex = 1;
            // 
            // clmAtributo
            // 
            this.clmAtributo.HeaderText = "Atributo";
            this.clmAtributo.MinimumWidth = 6;
            this.clmAtributo.Name = "clmAtributo";
            this.clmAtributo.Width = 125;
            // 
            // clmValor
            // 
            this.clmValor.HeaderText = "Valor";
            this.clmValor.MinimumWidth = 6;
            this.clmValor.Name = "clmValor";
            this.clmValor.Width = 125;
            // 
            // btnApplyConfiguration
            // 
            this.btnApplyConfiguration.Location = new System.Drawing.Point(12, 635);
            this.btnApplyConfiguration.Name = "btnApplyConfiguration";
            this.btnApplyConfiguration.Size = new System.Drawing.Size(442, 29);
            this.btnApplyConfiguration.TabIndex = 2;
            this.btnApplyConfiguration.Text = "Aplicar configuracion";
            this.btnApplyConfiguration.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(843, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // btnNewMapping
            // 
            this.btnNewMapping.Location = new System.Drawing.Point(861, 29);
            this.btnNewMapping.Name = "btnNewMapping";
            this.btnNewMapping.Size = new System.Drawing.Size(42, 29);
            this.btnNewMapping.TabIndex = 4;
            this.btnNewMapping.Text = "+";
            this.btnNewMapping.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mapping:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 670);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(394, 29);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar ambiente";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar atributos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Instalacion:";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(645, 83);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(258, 29);
            this.btnSelectFolder.TabIndex = 9;
            this.btnSelectFolder.Text = "Seleccionar carpeta";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(627, 27);
            this.textBox1.TabIndex = 11;
            // 
            // btnSetAppPath
            // 
            this.btnSetAppPath.Location = new System.Drawing.Point(412, 670);
            this.btnSetAppPath.Name = "btnSetAppPath";
            this.btnSetAppPath.Size = new System.Drawing.Size(42, 29);
            this.btnSetAppPath.TabIndex = 12;
            this.btnSetAppPath.Text = "+";
            this.btnSetAppPath.UseVisualStyleBackColor = true;
            this.btnSetAppPath.Click += new System.EventHandler(this.btnSetAppPath_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 711);
            this.Controls.Add(this.btnSetAppPath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewMapping);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnApplyConfiguration);
            this.Controls.Add(this.gridFields);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmHome";
            this.Text = "App Parametrizer";
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private DataGridView gridFields;
        private DataGridViewTextBoxColumn clmAtributo;
        private DataGridViewTextBoxColumn clmValor;
        private Button btnApplyConfiguration;
        private ComboBox comboBox1;
        private Button btnNewMapping;
        private Label label1;
        private Button btnIniciar;
        private Button button1;
        private Label label2;
        private Button btnSelectFolder;
        private TextBox textBox1;
        private Button btnSetAppPath;
    }
}