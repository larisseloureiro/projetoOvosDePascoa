namespace ProjetoOvodePascoa
{
    partial class FormCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.mskdAniver = new System.Windows.Forms.MaskedTextBox();
            this.lblAniver = new System.Windows.Forms.Label();
            this.textBox1Email = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskdTel = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.msdkCel = new System.Windows.Forms.MaskedTextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.minCadastroCl = new System.Windows.Forms.PictureBox();
            this.pictureBoxFecharCadasCliente = new System.Windows.Forms.PictureBox();
            this.button1Voltar = new System.Windows.Forms.Button();
            this.groupBoxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minCadastroCl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharCadasCliente)).BeginInit();
            this.SuspendLayout();
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
            this.buttonLimpar.Location = new System.Drawing.Point(604, 412);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonLimpar.Size = new System.Drawing.Size(89, 26);
            this.buttonLimpar.TabIndex = 2;
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
            this.buttonSalvar.Location = new System.Drawing.Point(699, 379);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(89, 26);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "    Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxCadastro.Controls.Add(this.cmbEstado);
            this.groupBoxCadastro.Controls.Add(this.cmbCidade);
            this.groupBoxCadastro.Controls.Add(this.mskdAniver);
            this.groupBoxCadastro.Controls.Add(this.lblAniver);
            this.groupBoxCadastro.Controls.Add(this.textBox1Email);
            this.groupBoxCadastro.Controls.Add(this.lblEmail);
            this.groupBoxCadastro.Controls.Add(this.mskdTel);
            this.groupBoxCadastro.Controls.Add(this.lblEstado);
            this.groupBoxCadastro.Controls.Add(this.lblCidade);
            this.groupBoxCadastro.Controls.Add(this.lblCel);
            this.groupBoxCadastro.Controls.Add(this.maskedTextBox3);
            this.groupBoxCadastro.Controls.Add(this.msdkCel);
            this.groupBoxCadastro.Controls.Add(this.lblEnd);
            this.groupBoxCadastro.Controls.Add(this.maskedTextBox1);
            this.groupBoxCadastro.Controls.Add(this.lblCEP);
            this.groupBoxCadastro.Controls.Add(this.mskdCPF);
            this.groupBoxCadastro.Controls.Add(this.lbl);
            this.groupBoxCadastro.Controls.Add(this.lblNome);
            this.groupBoxCadastro.Controls.Add(this.txtEnd);
            this.groupBoxCadastro.Controls.Add(this.txtNome);
            this.groupBoxCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastro.Location = new System.Drawing.Point(7, 101);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(781, 272);
            this.groupBoxCadastro.TabIndex = 0;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro do Cliente";
            this.groupBoxCadastro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(467, 178);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 18;
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(274, 178);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 28);
            this.cmbCidade.TabIndex = 17;
            // 
            // mskdAniver
            // 
            this.mskdAniver.Location = new System.Drawing.Point(665, 93);
            this.mskdAniver.Mask = "00/00/0000";
            this.mskdAniver.Name = "mskdAniver";
            this.mskdAniver.Size = new System.Drawing.Size(100, 26);
            this.mskdAniver.TabIndex = 8;
            this.mskdAniver.ValidatingType = typeof(System.DateTime);
            // 
            // lblAniver
            // 
            this.lblAniver.AutoSize = true;
            this.lblAniver.Location = new System.Drawing.Point(490, 99);
            this.lblAniver.Name = "lblAniver";
            this.lblAniver.Size = new System.Drawing.Size(154, 20);
            this.lblAniver.TabIndex = 7;
            this.lblAniver.Text = "Data de Nascimento";
            // 
            // textBox1Email
            // 
            this.textBox1Email.Location = new System.Drawing.Point(89, 138);
            this.textBox1Email.Name = "textBox1Email";
            this.textBox1Email.Size = new System.Drawing.Size(339, 26);
            this.textBox1Email.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // mskdTel
            // 
            this.mskdTel.Location = new System.Drawing.Point(230, 93);
            this.mskdTel.Mask = "(99) 90000-0000";
            this.mskdTel.Name = "mskdTel";
            this.mskdTel.Size = new System.Drawing.Size(125, 26);
            this.mskdTel.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(401, 186);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(209, 186);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 13;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(26, 96);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(58, 20);
            this.lblCel.TabIndex = 4;
            this.lblCel.Text = "Celular";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(-271, -90);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox3.TabIndex = 11;
            // 
            // msdkCel
            // 
            this.msdkCel.Location = new System.Drawing.Point(89, 93);
            this.msdkCel.Mask = "(99) 90000-0000";
            this.msdkCel.Name = "msdkCel";
            this.msdkCel.Size = new System.Drawing.Size(123, 26);
            this.msdkCel.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(6, 225);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(78, 20);
            this.lblEnd.TabIndex = 15;
            this.lblEnd.Text = "Endereço";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(89, 180);
            this.maskedTextBox1.Mask = "00000-999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(42, 186);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 11;
            this.lblCEP.Text = "CEP";
            this.lblCEP.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskdCPF
            // 
            this.mskdCPF.Location = new System.Drawing.Point(665, 47);
            this.mskdCPF.Mask = "000-000-000-00";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(100, 26);
            this.mskdCPF.TabIndex = 3;
            this.mskdCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdCPF_MaskInputRejected);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(619, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 20);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(89, 219);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(670, 26);
            this.txtEnd.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(524, 26);
            this.txtNome.TabIndex = 1;
            // 
            // minCadastroCl
            // 
            this.minCadastroCl.BackColor = System.Drawing.Color.Transparent;
            this.minCadastroCl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minCadastroCl.Image = ((System.Drawing.Image)(resources.GetObject("minCadastroCl.Image")));
            this.minCadastroCl.Location = new System.Drawing.Point(735, 4);
            this.minCadastroCl.Name = "minCadastroCl";
            this.minCadastroCl.Size = new System.Drawing.Size(28, 30);
            this.minCadastroCl.TabIndex = 2;
            this.minCadastroCl.TabStop = false;
            this.minCadastroCl.Click += new System.EventHandler(this.minCadastroCl_Click);
            // 
            // pictureBoxFecharCadasCliente
            // 
            this.pictureBoxFecharCadasCliente.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFecharCadasCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFecharCadasCliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFecharCadasCliente.Image")));
            this.pictureBoxFecharCadasCliente.Location = new System.Drawing.Point(769, 4);
            this.pictureBoxFecharCadasCliente.Name = "pictureBoxFecharCadasCliente";
            this.pictureBoxFecharCadasCliente.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxFecharCadasCliente.TabIndex = 14;
            this.pictureBoxFecharCadasCliente.TabStop = false;
            this.pictureBoxFecharCadasCliente.Click += new System.EventHandler(this.pictureBoxFecharCadasCliente_Click);
            // 
            // button1Voltar
            // 
            this.button1Voltar.FlatAppearance.BorderSize = 0;
            this.button1Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1Voltar.Location = new System.Drawing.Point(699, 412);
            this.button1Voltar.Name = "button1Voltar";
            this.button1Voltar.Size = new System.Drawing.Size(89, 26);
            this.button1Voltar.TabIndex = 15;
            this.button1Voltar.Text = "Voltar";
            this.button1Voltar.UseVisualStyleBackColor = true;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1Voltar);
            this.Controls.Add(this.pictureBoxFecharCadasCliente);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.minCadastroCl);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minCadastroCl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharCadasCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskdCPF;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox minCadastroCl;
        private System.Windows.Forms.MaskedTextBox msdkCel;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox mskdAniver;
        private System.Windows.Forms.Label lblAniver;
        private System.Windows.Forms.TextBox textBox1Email;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskdTel;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox pictureBoxFecharCadasCliente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Button button1Voltar;
    }
}