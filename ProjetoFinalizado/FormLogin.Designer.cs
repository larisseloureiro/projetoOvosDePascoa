namespace ProjetoOvodePascoa
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.fecharLogin = new System.Windows.Forms.PictureBox();
            this.minLogin = new System.Windows.Forms.PictureBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCadasUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fecharLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLogin)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // fecharLogin
            // 
            this.fecharLogin.BackColor = System.Drawing.Color.Transparent;
            this.fecharLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fecharLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fecharLogin.Image = ((System.Drawing.Image)(resources.GetObject("fecharLogin.Image")));
            this.fecharLogin.Location = new System.Drawing.Point(934, 0);
            this.fecharLogin.Name = "fecharLogin";
            this.fecharLogin.Size = new System.Drawing.Size(27, 30);
            this.fecharLogin.TabIndex = 0;
            this.fecharLogin.TabStop = false;
            this.fecharLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minLogin
            // 
            this.minLogin.BackColor = System.Drawing.Color.Transparent;
            this.minLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minLogin.Image = ((System.Drawing.Image)(resources.GetObject("minLogin.Image")));
            this.minLogin.Location = new System.Drawing.Point(900, 0);
            this.minLogin.Name = "minLogin";
            this.minLogin.Size = new System.Drawing.Size(28, 30);
            this.minLogin.TabIndex = 1;
            this.minLogin.TabStop = false;
            this.minLogin.Click += new System.EventHandler(this.minLogin_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(76, 113);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(268, 19);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.Text = "USUÁRIO";
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            this.textBoxUsuario.Enter += new System.EventHandler(this.textBoxUsuario_Enter);
            this.textBoxUsuario.Leave += new System.EventHandler(this.textBoxUsuario_Leave);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSenha.Location = new System.Drawing.Point(76, 155);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(268, 19);
            this.textBoxSenha.TabIndex = 3;
            this.textBoxSenha.Text = "SENHA";
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            this.textBoxSenha.Enter += new System.EventHandler(this.textBoxSenha_Enter);
            this.textBoxSenha.Leave += new System.EventHandler(this.textBoxSenha_Leave);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(296, 54);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(111, 33);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "LOGIN";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxLogin.Controls.Add(this.panel2);
            this.groupBoxLogin.Controls.Add(this.panel1);
            this.groupBoxLogin.Controls.Add(this.bunifuCadasUsuario);
            this.groupBoxLogin.Controls.Add(this.btnEntrar);
            this.groupBoxLogin.Controls.Add(this.buttonLimpar);
            this.groupBoxLogin.Controls.Add(this.labelLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxSenha);
            this.groupBoxLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(70, 73);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(695, 368);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Enter += new System.EventHandler(this.groupBoxLogin_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(76, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 2);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(76, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 2);
            this.panel1.TabIndex = 27;
            // 
            // bunifuCadasUsuario
            // 
            this.bunifuCadasUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuCadasUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuCadasUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCadasUsuario.BorderRadius = 0;
            this.bunifuCadasUsuario.ButtonText = "Cadastrar Usuário";
            this.bunifuCadasUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCadasUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuCadasUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuCadasUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuCadasUsuario.Iconimage")));
            this.bunifuCadasUsuario.Iconimage_right = null;
            this.bunifuCadasUsuario.Iconimage_right_Selected = null;
            this.bunifuCadasUsuario.Iconimage_Selected = null;
            this.bunifuCadasUsuario.IconMarginLeft = 0;
            this.bunifuCadasUsuario.IconMarginRight = 0;
            this.bunifuCadasUsuario.IconRightVisible = true;
            this.bunifuCadasUsuario.IconRightZoom = 0D;
            this.bunifuCadasUsuario.IconVisible = true;
            this.bunifuCadasUsuario.IconZoom = 90D;
            this.bunifuCadasUsuario.IsTab = false;
            this.bunifuCadasUsuario.Location = new System.Drawing.Point(492, 271);
            this.bunifuCadasUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuCadasUsuario.Name = "bunifuCadasUsuario";
            this.bunifuCadasUsuario.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuCadasUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuCadasUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuCadasUsuario.selected = false;
            this.bunifuCadasUsuario.Size = new System.Drawing.Size(195, 57);
            this.bunifuCadasUsuario.TabIndex = 5;
            this.bunifuCadasUsuario.Text = "Cadastrar Usuário";
            this.bunifuCadasUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCadasUsuario.Textcolor = System.Drawing.Color.White;
            this.bunifuCadasUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCadasUsuario.Click += new System.EventHandler(this.bunifuCadasUsuario_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrar.Location = new System.Drawing.Point(302, 220);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(96, 44);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpar.Image")));
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(600, 336);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonLimpar.Size = new System.Drawing.Size(89, 26);
            this.buttonLimpar.TabIndex = 0;
            this.buttonLimpar.Text = "    Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(842, 515);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.minLogin);
            this.Controls.Add(this.fecharLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fecharLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLogin)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox fecharLogin;
        private System.Windows.Forms.PictureBox minLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button btnEntrar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuCadasUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

