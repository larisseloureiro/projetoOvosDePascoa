namespace ProjetoOvodePascoa
{
    partial class FormConsultarClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarClientes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tabCadclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdprojovosDataSet = new ProjetoOvodePascoa.BdprojovosDataSet();
            this.pictureFecharConClientes = new System.Windows.Forms.PictureBox();
            this.pictureMinConClientes = new System.Windows.Forms.PictureBox();
            this.tabCadclientesTableAdapter = new ProjetoOvodePascoa.BdprojovosDataSetTableAdapters.TabCadclientesTableAdapter();
            this.button1Voltar = new System.Windows.Forms.Button();
            this.label1Consultar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFecharConClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinConClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tabCadclientesBindingSource
            // 
            this.tabCadclientesBindingSource.DataMember = "TabCadclientes";
            this.tabCadclientesBindingSource.DataSource = this.bdprojovosDataSet;
            // 
            // bdprojovosDataSet
            // 
            this.bdprojovosDataSet.DataSetName = "BdprojovosDataSet";
            this.bdprojovosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureFecharConClientes
            // 
            this.pictureFecharConClientes.BackColor = System.Drawing.Color.Transparent;
            this.pictureFecharConClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureFecharConClientes.Image = ((System.Drawing.Image)(resources.GetObject("pictureFecharConClientes.Image")));
            this.pictureFecharConClientes.Location = new System.Drawing.Point(1248, 1);
            this.pictureFecharConClientes.Name = "pictureFecharConClientes";
            this.pictureFecharConClientes.Size = new System.Drawing.Size(27, 28);
            this.pictureFecharConClientes.TabIndex = 1;
            this.pictureFecharConClientes.TabStop = false;
            this.pictureFecharConClientes.Click += new System.EventHandler(this.pictureFecharConClientes_Click);
            // 
            // pictureMinConClientes
            // 
            this.pictureMinConClientes.BackColor = System.Drawing.Color.Transparent;
            this.pictureMinConClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureMinConClientes.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinConClientes.Image")));
            this.pictureMinConClientes.Location = new System.Drawing.Point(1214, 1);
            this.pictureMinConClientes.Name = "pictureMinConClientes";
            this.pictureMinConClientes.Size = new System.Drawing.Size(28, 27);
            this.pictureMinConClientes.TabIndex = 2;
            this.pictureMinConClientes.TabStop = false;
            this.pictureMinConClientes.Click += new System.EventHandler(this.pictureMinConClientes_Click);
            // 
            // tabCadclientesTableAdapter
            // 
            this.tabCadclientesTableAdapter.ClearBeforeFill = true;
            // 
            // button1Voltar
            // 
            this.button1Voltar.FlatAppearance.BorderSize = 0;
            this.button1Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1Voltar.Location = new System.Drawing.Point(877, 26);
            this.button1Voltar.Name = "button1Voltar";
            this.button1Voltar.Size = new System.Drawing.Size(87, 27);
            this.button1Voltar.TabIndex = 3;
            this.button1Voltar.Text = "Voltar";
            this.button1Voltar.UseVisualStyleBackColor = true;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // label1Consultar
            // 
            this.label1Consultar.AutoSize = true;
            this.label1Consultar.BackColor = System.Drawing.Color.Transparent;
            this.label1Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Consultar.ForeColor = System.Drawing.Color.Black;
            this.label1Consultar.Location = new System.Drawing.Point(382, 24);
            this.label1Consultar.Name = "label1Consultar";
            this.label1Consultar.Size = new System.Drawing.Size(206, 25);
            this.label1Consultar.TabIndex = 4;
            this.label1Consultar.Text = "Consultar Clientes";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.tabCadclientesBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(605, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Nome";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AutoGenerateColumns = false;
            this.dataGridClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.Endereco,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridClientes.DataSource = this.tabCadclientesBindingSource;
            this.dataGridClientes.Location = new System.Drawing.Point(47, 96);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersWidth = 40;
            this.dataGridClientes.Size = new System.Drawing.Size(1217, 588);
            this.dataGridClientes.TabIndex = 0;
            this.dataGridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellContentClick);
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.Width = 150;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 160;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.Width = 130;
            // 
            // FormConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 732);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1Consultar);
            this.Controls.Add(this.button1Voltar);
            this.Controls.Add(this.pictureMinConClientes);
            this.Controls.Add(this.pictureFecharConClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultarClientes";
            this.Load += new System.EventHandler(this.FormConsultarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabCadclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFecharConClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinConClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureFecharConClientes;
        private System.Windows.Forms.PictureBox pictureMinConClientes;
        private BdprojovosDataSet bdprojovosDataSet;
        private System.Windows.Forms.BindingSource tabCadclientesBindingSource;
        private BdprojovosDataSetTableAdapters.TabCadclientesTableAdapter tabCadclientesTableAdapter;
        private System.Windows.Forms.Button button1Voltar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1Consultar;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}