namespace ProjetoOvodePascoa
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.bunifuElipsePedidos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.minPedidos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1Voltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdprojovosDataSet1 = new ProjetoOvodePascoa.BdprojovosDataSet1();
            this.tabCadPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCadPedidoTableAdapter = new ProjetoOvodePascoa.BdprojovosDataSet1TableAdapters.TabCadPedidoTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabor2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaçaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.minPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipsePedidos
            // 
            this.bunifuElipsePedidos.ElipseRadius = 5;
            this.bunifuElipsePedidos.TargetControl = this;
            // 
            // minPedidos
            // 
            this.minPedidos.BackColor = System.Drawing.Color.Transparent;
            this.minPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minPedidos.Image = ((System.Drawing.Image)(resources.GetObject("minPedidos.Image")));
            this.minPedidos.Location = new System.Drawing.Point(899, 1);
            this.minPedidos.Name = "minPedidos";
            this.minPedidos.Size = new System.Drawing.Size(28, 30);
            this.minPedidos.TabIndex = 2;
            this.minPedidos.TabStop = false;
            this.minPedidos.Click += new System.EventHandler(this.minPedidos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(933, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1Voltar
            // 
            this.button1Voltar.FlatAppearance.BorderSize = 0;
            this.button1Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1Voltar.Location = new System.Drawing.Point(31, 21);
            this.button1Voltar.Name = "button1Voltar";
            this.button1Voltar.Size = new System.Drawing.Size(75, 23);
            this.button1Voltar.TabIndex = 5;
            this.button1Voltar.Text = "Voltar";
            this.button1Voltar.UseVisualStyleBackColor = true;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.saborDataGridViewTextBoxColumn,
            this.sabor2DataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.observaçaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabCadPedidoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 507);
            this.dataGridView1.TabIndex = 8;
            // 
            // bdprojovosDataSet1
            // 
            this.bdprojovosDataSet1.DataSetName = "BdprojovosDataSet1";
            this.bdprojovosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCadPedidoBindingSource
            // 
            this.tabCadPedidoBindingSource.DataMember = "TabCadPedido";
            this.tabCadPedidoBindingSource.DataSource = this.bdprojovosDataSet1;
            // 
            // tabCadPedidoTableAdapter
            // 
            this.tabCadPedidoTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // saborDataGridViewTextBoxColumn
            // 
            this.saborDataGridViewTextBoxColumn.DataPropertyName = "Sabor";
            this.saborDataGridViewTextBoxColumn.HeaderText = "Sabor";
            this.saborDataGridViewTextBoxColumn.Name = "saborDataGridViewTextBoxColumn";
            // 
            // sabor2DataGridViewTextBoxColumn
            // 
            this.sabor2DataGridViewTextBoxColumn.DataPropertyName = "Sabor2";
            this.sabor2DataGridViewTextBoxColumn.HeaderText = "Sabor*";
            this.sabor2DataGridViewTextBoxColumn.Name = "sabor2DataGridViewTextBoxColumn";
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "Tam.";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            this.tamanhoDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Qtde.";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 50;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data do Pedido";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // observaçaoDataGridViewTextBoxColumn
            // 
            this.observaçaoDataGridViewTextBoxColumn.DataPropertyName = "Observaçao";
            this.observaçaoDataGridViewTextBoxColumn.HeaderText = "Obs:";
            this.observaçaoDataGridViewTextBoxColumn.Name = "observaçaoDataGridViewTextBoxColumn";
            this.observaçaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(973, 606);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1Voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipsePedidos;
        private System.Windows.Forms.PictureBox minPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1Voltar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private BdprojovosDataSet1 bdprojovosDataSet1;
        private System.Windows.Forms.BindingSource tabCadPedidoBindingSource;
        private BdprojovosDataSet1TableAdapters.TabCadPedidoTableAdapter tabCadPedidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaçaoDataGridViewTextBoxColumn;
    }
}