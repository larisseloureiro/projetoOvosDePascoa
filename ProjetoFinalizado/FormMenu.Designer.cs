namespace ProjetoOvodePascoa
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.minMenu = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCadasPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuPedidos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatCadastroCl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pctFecharMenu = new System.Windows.Forms.PictureBox();
            this.pctMaxMenu = new System.Windows.Forms.PictureBox();
            this.picMinLogin = new System.Windows.Forms.PictureBox();
            this.dataGridCardapio = new System.Windows.Forms.DataGridView();
            this.tabCadOvosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdprojovosDataSet2 = new ProjetoOvodePascoa.BdprojovosDataSet2();
            this.tabCadOvosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdprojovosDataCardapio = new ProjetoOvodePascoa.BdprojovosDataCardapio();
            this.tabCadOvosTableAdapter = new ProjetoOvodePascoa.BdprojovosDataCardapioTableAdapters.TabCadOvosTableAdapter();
            this.tabCadOvosTableAdapter1 = new ProjetoOvodePascoa.BdprojovosDataSet2TableAdapters.TabCadOvosTableAdapter();
            this.btnAtt = new System.Windows.Forms.Button();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chocolateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.minMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFecharMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataCardapio)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // minMenu
            // 
            this.minMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minMenu.BackColor = System.Drawing.Color.Transparent;
            this.minMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minMenu.Image = ((System.Drawing.Image)(resources.GetObject("minMenu.Image")));
            this.minMenu.Location = new System.Drawing.Point(728, 0);
            this.minMenu.Name = "minMenu";
            this.minMenu.Size = new System.Drawing.Size(28, 30);
            this.minMenu.TabIndex = 2;
            this.minMenu.TabStop = false;
            this.minMenu.Click += new System.EventHandler(this.minMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.bunifuFlatButton2);
            this.panelMenu.Controls.Add(this.bunifuFlatButton1);
            this.panelMenu.Controls.Add(this.bunifuCadasPedido);
            this.panelMenu.Controls.Add(this.bunifuPedidos);
            this.panelMenu.Controls.Add(this.bunifuFlatCadastroCl);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(119, 619);
            this.panelMenu.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Consultar Clientes";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 451);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(119, 48);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "Consultar Clientes";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cadastro de Ovos";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 142);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(119, 48);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Cadastro de Ovos";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCadasPedido
            // 
            this.bunifuCadasPedido.Activecolor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuCadasPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCadasPedido.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuCadasPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCadasPedido.BorderRadius = 0;
            this.bunifuCadasPedido.ButtonText = "Cadastrar Pedido";
            this.bunifuCadasPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCadasPedido.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuCadasPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuCadasPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuCadasPedido.Iconimage")));
            this.bunifuCadasPedido.Iconimage_right = null;
            this.bunifuCadasPedido.Iconimage_right_Selected = null;
            this.bunifuCadasPedido.Iconimage_Selected = null;
            this.bunifuCadasPedido.IconMarginLeft = 0;
            this.bunifuCadasPedido.IconMarginRight = 0;
            this.bunifuCadasPedido.IconRightVisible = true;
            this.bunifuCadasPedido.IconRightZoom = 0D;
            this.bunifuCadasPedido.IconVisible = true;
            this.bunifuCadasPedido.IconZoom = 45D;
            this.bunifuCadasPedido.IsTab = false;
            this.bunifuCadasPedido.Location = new System.Drawing.Point(0, 81);
            this.bunifuCadasPedido.Name = "bunifuCadasPedido";
            this.bunifuCadasPedido.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuCadasPedido.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuCadasPedido.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuCadasPedido.selected = false;
            this.bunifuCadasPedido.Size = new System.Drawing.Size(119, 48);
            this.bunifuCadasPedido.TabIndex = 3;
            this.bunifuCadasPedido.Text = "Cadastrar Pedido";
            this.bunifuCadasPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCadasPedido.Textcolor = System.Drawing.Color.White;
            this.bunifuCadasPedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCadasPedido.Click += new System.EventHandler(this.bunifuCadasPedido_Click);
            // 
            // bunifuPedidos
            // 
            this.bunifuPedidos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuPedidos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPedidos.BorderRadius = 0;
            this.bunifuPedidos.ButtonText = "Controle de Pedidos";
            this.bunifuPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPedidos.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuPedidos.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuPedidos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuPedidos.Iconimage")));
            this.bunifuPedidos.Iconimage_right = null;
            this.bunifuPedidos.Iconimage_right_Selected = null;
            this.bunifuPedidos.Iconimage_Selected = null;
            this.bunifuPedidos.IconMarginLeft = 0;
            this.bunifuPedidos.IconMarginRight = 0;
            this.bunifuPedidos.IconRightVisible = true;
            this.bunifuPedidos.IconRightZoom = 0D;
            this.bunifuPedidos.IconVisible = true;
            this.bunifuPedidos.IconZoom = 90D;
            this.bunifuPedidos.IsTab = false;
            this.bunifuPedidos.Location = new System.Drawing.Point(0, 518);
            this.bunifuPedidos.Name = "bunifuPedidos";
            this.bunifuPedidos.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuPedidos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuPedidos.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuPedidos.selected = false;
            this.bunifuPedidos.Size = new System.Drawing.Size(119, 57);
            this.bunifuPedidos.TabIndex = 4;
            this.bunifuPedidos.Text = "Controle de Pedidos";
            this.bunifuPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuPedidos.Textcolor = System.Drawing.Color.White;
            this.bunifuPedidos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPedidos.Click += new System.EventHandler(this.bunifuPedidos_Click);
            // 
            // bunifuFlatCadastroCl
            // 
            this.bunifuFlatCadastroCl.Activecolor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuFlatCadastroCl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatCadastroCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatCadastroCl.BorderRadius = 0;
            this.bunifuFlatCadastroCl.ButtonText = "Cadastrar Clientes";
            this.bunifuFlatCadastroCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatCadastroCl.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatCadastroCl.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatCadastroCl.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatCadastroCl.Iconimage")));
            this.bunifuFlatCadastroCl.Iconimage_right = null;
            this.bunifuFlatCadastroCl.Iconimage_right_Selected = null;
            this.bunifuFlatCadastroCl.Iconimage_Selected = null;
            this.bunifuFlatCadastroCl.IconMarginLeft = 0;
            this.bunifuFlatCadastroCl.IconMarginRight = 0;
            this.bunifuFlatCadastroCl.IconRightVisible = true;
            this.bunifuFlatCadastroCl.IconRightZoom = 0D;
            this.bunifuFlatCadastroCl.IconVisible = true;
            this.bunifuFlatCadastroCl.IconZoom = 60D;
            this.bunifuFlatCadastroCl.IsTab = false;
            this.bunifuFlatCadastroCl.Location = new System.Drawing.Point(0, 21);
            this.bunifuFlatCadastroCl.Name = "bunifuFlatCadastroCl";
            this.bunifuFlatCadastroCl.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatCadastroCl.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatCadastroCl.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatCadastroCl.selected = false;
            this.bunifuFlatCadastroCl.Size = new System.Drawing.Size(119, 48);
            this.bunifuFlatCadastroCl.TabIndex = 1;
            this.bunifuFlatCadastroCl.Text = "Cadastrar Clientes";
            this.bunifuFlatCadastroCl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatCadastroCl.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatCadastroCl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatCadastroCl.Click += new System.EventHandler(this.bunifuFlatCadastroCl_Click);
            // 
            // pctFecharMenu
            // 
            this.pctFecharMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctFecharMenu.BackColor = System.Drawing.Color.Transparent;
            this.pctFecharMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFecharMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctFecharMenu.Image")));
            this.pctFecharMenu.Location = new System.Drawing.Point(790, 0);
            this.pctFecharMenu.Name = "pctFecharMenu";
            this.pctFecharMenu.Size = new System.Drawing.Size(27, 30);
            this.pctFecharMenu.TabIndex = 4;
            this.pctFecharMenu.TabStop = false;
            this.pctFecharMenu.Click += new System.EventHandler(this.pctFecharMenu_Click);
            // 
            // pctMaxMenu
            // 
            this.pctMaxMenu.BackColor = System.Drawing.Color.Transparent;
            this.pctMaxMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctMaxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctMaxMenu.Image")));
            this.pctMaxMenu.Location = new System.Drawing.Point(906, 0);
            this.pctMaxMenu.Name = "pctMaxMenu";
            this.pctMaxMenu.Size = new System.Drawing.Size(29, 30);
            this.pctMaxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMaxMenu.TabIndex = 16;
            this.pctMaxMenu.TabStop = false;
            this.pctMaxMenu.Click += new System.EventHandler(this.pctMaxMenu_Click);
            // 
            // picMinLogin
            // 
            this.picMinLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinLogin.BackColor = System.Drawing.Color.Transparent;
            this.picMinLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMinLogin.Image = ((System.Drawing.Image)(resources.GetObject("picMinLogin.Image")));
            this.picMinLogin.Location = new System.Drawing.Point(762, 0);
            this.picMinLogin.Name = "picMinLogin";
            this.picMinLogin.Size = new System.Drawing.Size(29, 30);
            this.picMinLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinLogin.TabIndex = 17;
            this.picMinLogin.TabStop = false;
            this.picMinLogin.Visible = false;
            this.picMinLogin.Click += new System.EventHandler(this.picMinLogin_Click);
            // 
            // dataGridCardapio
            // 
            this.dataGridCardapio.AutoGenerateColumns = false;
            this.dataGridCardapio.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saborDataGridViewTextBoxColumn,
            this.kgDataGridViewTextBoxColumn,
            this.chocolateDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn});
            this.dataGridCardapio.DataSource = this.tabCadOvosBindingSource1;
            this.dataGridCardapio.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridCardapio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridCardapio.Location = new System.Drawing.Point(186, 49);
            this.dataGridCardapio.Name = "dataGridCardapio";
            this.dataGridCardapio.Size = new System.Drawing.Size(552, 513);
            this.dataGridCardapio.TabIndex = 18;
            this.dataGridCardapio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCardapio_CellContentClick);
            // 
            // tabCadOvosBindingSource1
            // 
            this.tabCadOvosBindingSource1.DataMember = "TabCadOvos";
            this.tabCadOvosBindingSource1.DataSource = this.bdprojovosDataSet2;
            // 
            // bdprojovosDataSet2
            // 
            this.bdprojovosDataSet2.DataSetName = "BdprojovosDataSet2";
            this.bdprojovosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCadOvosBindingSource
            // 
            this.tabCadOvosBindingSource.DataMember = "TabCadOvos";
            this.tabCadOvosBindingSource.DataSource = this.bdprojovosDataCardapio;
            // 
            // bdprojovosDataCardapio
            // 
            this.bdprojovosDataCardapio.DataSetName = "BdprojovosDataCardapio";
            this.bdprojovosDataCardapio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCadOvosTableAdapter
            // 
            this.tabCadOvosTableAdapter.ClearBeforeFill = true;
            // 
            // tabCadOvosTableAdapter1
            // 
            this.tabCadOvosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAtt
            // 
            this.btnAtt.FlatAppearance.BorderSize = 0;
            this.btnAtt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.Location = new System.Drawing.Point(713, 580);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(78, 27);
            this.btnAtt.TabIndex = 19;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = true;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.Width = 80;
            // 
            // chocolateDataGridViewTextBoxColumn
            // 
            this.chocolateDataGridViewTextBoxColumn.DataPropertyName = "Chocolate";
            this.chocolateDataGridViewTextBoxColumn.HeaderText = "Chocolate";
            this.chocolateDataGridViewTextBoxColumn.Name = "chocolateDataGridViewTextBoxColumn";
            this.chocolateDataGridViewTextBoxColumn.Width = 160;
            // 
            // kgDataGridViewTextBoxColumn
            // 
            this.kgDataGridViewTextBoxColumn.DataPropertyName = "Kg";
            this.kgDataGridViewTextBoxColumn.HeaderText = "Kg";
            this.kgDataGridViewTextBoxColumn.Name = "kgDataGridViewTextBoxColumn";
            this.kgDataGridViewTextBoxColumn.Width = 70;
            // 
            // saborDataGridViewTextBoxColumn
            // 
            this.saborDataGridViewTextBoxColumn.DataPropertyName = "Sabor";
            this.saborDataGridViewTextBoxColumn.HeaderText = "Sabor";
            this.saborDataGridViewTextBoxColumn.Name = "saborDataGridViewTextBoxColumn";
            this.saborDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 619);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.dataGridCardapio);
            this.Controls.Add(this.picMinLogin);
            this.Controls.Add(this.pctMaxMenu);
            this.Controls.Add(this.pctFecharMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.minMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctFecharMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCardapio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataCardapio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox minMenu;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuCadasPedido;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuPedidos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatCadastroCl;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pctFecharMenu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox picMinLogin;
        private System.Windows.Forms.PictureBox pctMaxMenu;
        private BdprojovosDataCardapio bdprojovosDataCardapio;
        private System.Windows.Forms.BindingSource tabCadOvosBindingSource;
        private BdprojovosDataCardapioTableAdapters.TabCadOvosTableAdapter tabCadOvosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridCardapio;
        private BdprojovosDataSet2 bdprojovosDataSet2;
        private System.Windows.Forms.BindingSource tabCadOvosBindingSource1;
        private BdprojovosDataSet2TableAdapters.TabCadOvosTableAdapter tabCadOvosTableAdapter1;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn saborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chocolateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
    }
}