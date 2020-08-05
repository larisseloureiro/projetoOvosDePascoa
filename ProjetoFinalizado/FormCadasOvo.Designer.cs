namespace ProjetoOvodePascoa
{
    partial class FormCadasOvo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadasOvo));
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.pictureBoxFecharCadasOvo = new System.Windows.Forms.PictureBox();
            this.pctMinCadasOvo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKKg = new System.Windows.Forms.TextBox();
            this.textBoxChoc = new System.Windows.Forms.TextBox();
            this.button1Voltar = new System.Windows.Forms.Button();
            this.textBoxSabor = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblChocolate = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharCadasOvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinCadasOvo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 10;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // pictureBoxFecharCadasOvo
            // 
            this.pictureBoxFecharCadasOvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFecharCadasOvo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFecharCadasOvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFecharCadasOvo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFecharCadasOvo.Image")));
            this.pictureBoxFecharCadasOvo.Location = new System.Drawing.Point(760, 0);
            this.pictureBoxFecharCadasOvo.Name = "pictureBoxFecharCadasOvo";
            this.pictureBoxFecharCadasOvo.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxFecharCadasOvo.TabIndex = 0;
            this.pictureBoxFecharCadasOvo.TabStop = false;
            this.pictureBoxFecharCadasOvo.Click += new System.EventHandler(this.pictureBoxFecharCadasOvo_Click);
            // 
            // pctMinCadasOvo
            // 
            this.pctMinCadasOvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinCadasOvo.BackColor = System.Drawing.Color.Transparent;
            this.pctMinCadasOvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctMinCadasOvo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctMinCadasOvo.Image = ((System.Drawing.Image)(resources.GetObject("pctMinCadasOvo.Image")));
            this.pctMinCadasOvo.Location = new System.Drawing.Point(726, 0);
            this.pctMinCadasOvo.Name = "pctMinCadasOvo";
            this.pctMinCadasOvo.Size = new System.Drawing.Size(28, 28);
            this.pctMinCadasOvo.TabIndex = 1;
            this.pctMinCadasOvo.TabStop = false;
            this.pctMinCadasOvo.Click += new System.EventHandler(this.pctMinCadasOvo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.textBoxKKg);
            this.groupBox1.Controls.Add(this.textBoxChoc);
            this.groupBox1.Controls.Add(this.button1Voltar);
            this.groupBox1.Controls.Add(this.textBoxSabor);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.lblKg);
            this.groupBox1.Controls.Add(this.lblChocolate);
            this.groupBox1.Controls.Add(this.lblSabor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Ovos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxKKg
            // 
            this.textBoxKKg.Location = new System.Drawing.Point(389, 127);
            this.textBoxKKg.Name = "textBoxKKg";
            this.textBoxKKg.Size = new System.Drawing.Size(145, 31);
            this.textBoxKKg.TabIndex = 11;
            // 
            // textBoxChoc
            // 
            this.textBoxChoc.Location = new System.Drawing.Point(143, 127);
            this.textBoxChoc.Name = "textBoxChoc";
            this.textBoxChoc.Size = new System.Drawing.Size(176, 31);
            this.textBoxChoc.TabIndex = 10;
            // 
            // button1Voltar
            // 
            this.button1Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Voltar.Location = new System.Drawing.Point(516, 264);
            this.button1Voltar.Name = "button1Voltar";
            this.button1Voltar.Size = new System.Drawing.Size(113, 28);
            this.button1Voltar.TabIndex = 2;
            this.button1Voltar.Text = "Voltar";
            this.button1Voltar.UseVisualStyleBackColor = true;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // textBoxSabor
            // 
            this.textBoxSabor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSabor.Location = new System.Drawing.Point(143, 63);
            this.textBoxSabor.Name = "textBoxSabor";
            this.textBoxSabor.Size = new System.Drawing.Size(391, 31);
            this.textBoxSabor.TabIndex = 1;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(516, 230);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(113, 28);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "    Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpar.Image")));
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(389, 264);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonLimpar.Size = new System.Drawing.Size(113, 28);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "    Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 186);
            this.maskedTextBox1.Mask = "$ 000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(124, 31);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(64, 192);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(73, 25);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço";
            // 
            // lblKg
            // 
            this.lblKg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(343, 133);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(40, 25);
            this.lblKg.TabIndex = 4;
            this.lblKg.Text = "Kg";
            // 
            // lblChocolate
            // 
            this.lblChocolate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.Location = new System.Drawing.Point(19, 133);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(118, 25);
            this.lblChocolate.TabIndex = 2;
            this.lblChocolate.Text = "Chocolate";
            // 
            // lblSabor
            // 
            this.lblSabor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(63, 69);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(74, 25);
            this.lblSabor.TabIndex = 0;
            this.lblSabor.Text = "Sabor";
            // 
            // FormCadasOvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctMinCadasOvo);
            this.Controls.Add(this.pictureBoxFecharCadasOvo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadasOvo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadasOvo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharCadasOvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinCadasOvo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.PictureBox pictureBoxFecharCadasOvo;
        private System.Windows.Forms.PictureBox pctMinCadasOvo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TextBox textBoxSabor;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button button1Voltar;
        private System.Windows.Forms.TextBox textBoxKKg;
        private System.Windows.Forms.TextBox textBoxChoc;
    }
}