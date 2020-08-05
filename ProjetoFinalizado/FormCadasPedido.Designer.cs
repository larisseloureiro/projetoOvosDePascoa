namespace ProjetoOvodePascoa
{
    partial class FormCadasPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadasPedido));
            this.bunifuElipseCadasPedido = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.minLogin = new System.Windows.Forms.PictureBox();
            this.groupBoxCadasPedido = new System.Windows.Forms.GroupBox();
            this.maskedDataP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.button1Voltar = new System.Windows.Forms.Button();
            this.comboBoxSabor2 = new System.Windows.Forms.ComboBox();
            this.tabCadOvosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdprojovosDataSet3 = new ProjetoOvodePascoa.BdprojovosDataSet3();
            this.tabCadOvosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdprojovosDataSetOvos2 = new ProjetoOvodePascoa.BdprojovosDataSetOvos2();
            this.comboBox2nome = new System.Windows.Forms.ComboBox();
            this.tabCadclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdprojovosDataSet = new ProjetoOvodePascoa.BdprojovosDataSet();
            this.lblSabor2 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboKG = new System.Windows.Forms.ComboBox();
            this.comboSabor = new System.Windows.Forms.ComboBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.lblQntd = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBoxFecharPedidos = new System.Windows.Forms.PictureBox();
            this.tabCadclientesTableAdapter = new ProjetoOvodePascoa.BdprojovosDataSetTableAdapters.TabCadclientesTableAdapter();
            this.tabCadOvosTableAdapter = new ProjetoOvodePascoa.BdprojovosDataSet3TableAdapters.TabCadOvosTableAdapter();
            this.tabCadOvosTableAdapter1 = new ProjetoOvodePascoa.BdprojovosDataSetOvos2TableAdapters.TabCadOvosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.minLogin)).BeginInit();
            this.groupBoxCadasPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSetOvos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipseCadasPedido
            // 
            this.bunifuElipseCadasPedido.ElipseRadius = 5;
            this.bunifuElipseCadasPedido.TargetControl = this;
            // 
            // minLogin
            // 
            this.minLogin.BackColor = System.Drawing.Color.Transparent;
            this.minLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minLogin.Image = ((System.Drawing.Image)(resources.GetObject("minLogin.Image")));
            this.minLogin.Location = new System.Drawing.Point(1061, 1);
            this.minLogin.Name = "minLogin";
            this.minLogin.Size = new System.Drawing.Size(28, 27);
            this.minLogin.TabIndex = 2;
            this.minLogin.TabStop = false;
            this.minLogin.Click += new System.EventHandler(this.minLogin_Click);
            // 
            // groupBoxCadasPedido
            // 
            this.groupBoxCadasPedido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxCadasPedido.Controls.Add(this.maskedDataP);
            this.groupBoxCadasPedido.Controls.Add(this.label1);
            this.groupBoxCadasPedido.Controls.Add(this.txtObs);
            this.groupBoxCadasPedido.Controls.Add(this.lblObs);
            this.groupBoxCadasPedido.Controls.Add(this.button1Voltar);
            this.groupBoxCadasPedido.Controls.Add(this.comboBoxSabor2);
            this.groupBoxCadasPedido.Controls.Add(this.comboBox2nome);
            this.groupBoxCadasPedido.Controls.Add(this.lblSabor2);
            this.groupBoxCadasPedido.Controls.Add(this.buttonLimpar);
            this.groupBoxCadasPedido.Controls.Add(this.buttonSalvar);
            this.groupBoxCadasPedido.Controls.Add(this.maskedTextBox1);
            this.groupBoxCadasPedido.Controls.Add(this.comboBox1);
            this.groupBoxCadasPedido.Controls.Add(this.comboKG);
            this.groupBoxCadasPedido.Controls.Add(this.comboSabor);
            this.groupBoxCadasPedido.Controls.Add(this.lblSabor);
            this.groupBoxCadasPedido.Controls.Add(this.lblValor);
            this.groupBoxCadasPedido.Controls.Add(this.maskedTextBox3);
            this.groupBoxCadasPedido.Controls.Add(this.lblQntd);
            this.groupBoxCadasPedido.Controls.Add(this.lblKG);
            this.groupBoxCadasPedido.Controls.Add(this.lblNome);
            this.groupBoxCadasPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadasPedido.Location = new System.Drawing.Point(12, 65);
            this.groupBoxCadasPedido.Name = "groupBoxCadasPedido";
            this.groupBoxCadasPedido.Size = new System.Drawing.Size(776, 357);
            this.groupBoxCadasPedido.TabIndex = 0;
            this.groupBoxCadasPedido.TabStop = false;
            this.groupBoxCadasPedido.Text = "Cadastro de Pedido";
            this.groupBoxCadasPedido.Enter += new System.EventHandler(this.groupBoxCadasPedido_Enter);
            // 
            // maskedDataP
            // 
            this.maskedDataP.Location = new System.Drawing.Point(671, 7);
            this.maskedDataP.Mask = "00/00/0000";
            this.maskedDataP.Name = "maskedDataP";
            this.maskedDataP.Size = new System.Drawing.Size(87, 26);
            this.maskedDataP.TabIndex = 24;
            this.maskedDataP.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data do Pedido";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(274, 214);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(313, 85);
            this.txtObs.TabIndex = 22;
            this.txtObs.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(270, 191);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(38, 20);
            this.lblObs.TabIndex = 21;
            this.lblObs.Text = "Obs";
            // 
            // button1Voltar
            // 
            this.button1Voltar.FlatAppearance.BorderSize = 0;
            this.button1Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Voltar.Location = new System.Drawing.Point(671, 325);
            this.button1Voltar.Name = "button1Voltar";
            this.button1Voltar.Size = new System.Drawing.Size(89, 26);
            this.button1Voltar.TabIndex = 16;
            this.button1Voltar.Text = "Voltar";
            this.button1Voltar.UseVisualStyleBackColor = true;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // comboBoxSabor2
            // 
            this.comboBoxSabor2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSabor2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabCadOvosBindingSource, "Sabor", true));
            this.comboBoxSabor2.DataSource = this.tabCadOvosBindingSource1;
            this.comboBoxSabor2.DisplayMember = "Sabor";
            this.comboBoxSabor2.FormattingEnabled = true;
            this.comboBoxSabor2.Location = new System.Drawing.Point(89, 167);
            this.comboBoxSabor2.Name = "comboBoxSabor2";
            this.comboBoxSabor2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSabor2.TabIndex = 14;
            // 
            // tabCadOvosBindingSource
            // 
            this.tabCadOvosBindingSource.DataMember = "TabCadOvos";
            this.tabCadOvosBindingSource.DataSource = this.bdprojovosDataSet3;
            // 
            // bdprojovosDataSet3
            // 
            this.bdprojovosDataSet3.DataSetName = "BdprojovosDataSet3";
            this.bdprojovosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCadOvosBindingSource1
            // 
            this.tabCadOvosBindingSource1.DataMember = "TabCadOvos";
            this.tabCadOvosBindingSource1.DataSource = this.bdprojovosDataSetOvos2;
            // 
            // bdprojovosDataSetOvos2
            // 
            this.bdprojovosDataSetOvos2.DataSetName = "BdprojovosDataSetOvos2";
            this.bdprojovosDataSetOvos2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2nome
            // 
            this.comboBox2nome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2nome.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabCadclientesBindingSource, "Nome", true));
            this.comboBox2nome.DataSource = this.tabCadclientesBindingSource;
            this.comboBox2nome.DisplayMember = "Nome";
            this.comboBox2nome.FormattingEnabled = true;
            this.comboBox2nome.Location = new System.Drawing.Point(89, 52);
            this.comboBox2nome.Name = "comboBox2nome";
            this.comboBox2nome.Size = new System.Drawing.Size(498, 28);
            this.comboBox2nome.TabIndex = 4;
            this.comboBox2nome.ValueMember = "CPF";
            this.comboBox2nome.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // lblSabor2
            // 
            this.lblSabor2.AutoSize = true;
            this.lblSabor2.Location = new System.Drawing.Point(25, 175);
            this.lblSabor2.Name = "lblSabor2";
            this.lblSabor2.Size = new System.Drawing.Size(58, 20);
            this.lblSabor2.TabIndex = 13;
            this.lblSabor2.Text = "Sabor*";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpar.Image")));
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(576, 325);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonLimpar.Size = new System.Drawing.Size(89, 26);
            this.buttonLimpar.TabIndex = 19;
            this.buttonLimpar.Text = "    Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(671, 293);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(89, 26);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "    Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tabCadOvosBindingSource, "Kg", true));
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCadOvosBindingSource, "Preço", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
            this.maskedTextBox1.Location = new System.Drawing.Point(89, 220);
            this.maskedTextBox1.Mask = "$ 00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(79, 26);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // comboKG
            // 
            this.comboKG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboKG.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabCadOvosBindingSource, "Kg", true));
            this.comboKG.DataSource = this.tabCadOvosBindingSource;
            this.comboKG.DisplayMember = "Kg";
            this.comboKG.FormattingEnabled = true;
            this.comboKG.Location = new System.Drawing.Point(274, 113);
            this.comboKG.Name = "comboKG";
            this.comboKG.Size = new System.Drawing.Size(121, 28);
            this.comboKG.TabIndex = 10;
            // 
            // comboSabor
            // 
            this.comboSabor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSabor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabCadOvosBindingSource, "Sabor", true));
            this.comboSabor.DataSource = this.tabCadOvosBindingSource;
            this.comboSabor.DisplayMember = "Sabor";
            this.comboSabor.FormattingEnabled = true;
            this.comboSabor.Location = new System.Drawing.Point(89, 113);
            this.comboSabor.Name = "comboSabor";
            this.comboSabor.Size = new System.Drawing.Size(121, 28);
            this.comboSabor.TabIndex = 8;
            this.comboSabor.SelectedIndexChanged += new System.EventHandler(this.comboSabor_SelectedIndexChanged);
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(26, 121);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(52, 20);
            this.lblSabor.TabIndex = 7;
            this.lblSabor.Text = "Sabor";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(38, 223);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(-271, -90);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox3.TabIndex = 11;
            // 
            // lblQntd
            // 
            this.lblQntd.AutoSize = true;
            this.lblQntd.Location = new System.Drawing.Point(412, 116);
            this.lblQntd.Name = "lblQntd";
            this.lblQntd.Size = new System.Drawing.Size(48, 20);
            this.lblQntd.TabIndex = 11;
            this.lblQntd.Text = "Qntd.";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(226, 116);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(42, 20);
            this.lblKG.TabIndex = 9;
            this.lblKG.Text = "TAM";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // pictureBoxFecharPedidos
            // 
            this.pictureBoxFecharPedidos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFecharPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFecharPedidos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFecharPedidos.Image")));
            this.pictureBoxFecharPedidos.Location = new System.Drawing.Point(1095, 1);
            this.pictureBoxFecharPedidos.Name = "pictureBoxFecharPedidos";
            this.pictureBoxFecharPedidos.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxFecharPedidos.TabIndex = 15;
            this.pictureBoxFecharPedidos.TabStop = false;
            this.pictureBoxFecharPedidos.Click += new System.EventHandler(this.pictureBoxFecharLogin_Click);
            // 
            // tabCadclientesTableAdapter
            // 
            this.tabCadclientesTableAdapter.ClearBeforeFill = true;
            // 
            // tabCadOvosTableAdapter
            // 
            this.tabCadOvosTableAdapter.ClearBeforeFill = true;
            // 
            // tabCadOvosTableAdapter1
            // 
            this.tabCadOvosTableAdapter1.ClearBeforeFill = true;
            // 
            // FormCadasPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxFecharPedidos);
            this.Controls.Add(this.groupBoxCadasPedido);
            this.Controls.Add(this.minLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadasPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadasPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minLogin)).EndInit();
            this.groupBoxCadasPedido.ResumeLayout(false);
            this.groupBoxCadasPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadOvosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSetOvos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdprojovosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipseCadasPedido;
        private System.Windows.Forms.PictureBox minLogin;
        private System.Windows.Forms.GroupBox groupBoxCadasPedido;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboKG;
        private System.Windows.Forms.ComboBox comboSabor;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label lblQntd;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.PictureBox pictureBoxFecharPedidos;
        private System.Windows.Forms.ComboBox comboBox2nome;
        private System.Windows.Forms.ComboBox comboBoxSabor2;
        private System.Windows.Forms.Label lblSabor2;
        private System.Windows.Forms.Button button1Voltar;
        private BdprojovosDataSet bdprojovosDataSet;
        private System.Windows.Forms.BindingSource tabCadclientesBindingSource;
        private BdprojovosDataSetTableAdapters.TabCadclientesTableAdapter tabCadclientesTableAdapter;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private BdprojovosDataSet3 bdprojovosDataSet3;
        private System.Windows.Forms.BindingSource tabCadOvosBindingSource;
        private BdprojovosDataSet3TableAdapters.TabCadOvosTableAdapter tabCadOvosTableAdapter;
        private BdprojovosDataSetOvos2 bdprojovosDataSetOvos2;
        private System.Windows.Forms.BindingSource tabCadOvosBindingSource1;
        private BdprojovosDataSetOvos2TableAdapters.TabCadOvosTableAdapter tabCadOvosTableAdapter1;
        private System.Windows.Forms.MaskedTextBox maskedDataP;
        private System.Windows.Forms.Label label1;
    }
}