namespace Ativ08_projeto_calculadora_tinta
{
    partial class frmCalculaTinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaTinta));
            this.lblLarg = new System.Windows.Forms.Label();
            this.pbxLogoApp = new System.Windows.Forms.PictureBox();
            this.lblAlt = new System.Windows.Forms.Label();
            this.txtLarg = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.lblRend = new System.Windows.Forms.Label();
            this.txtRend = new System.Windows.Forms.TextBox();
            this.lblEmb = new System.Windows.Forms.Label();
            this.txtEmb = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblAssinatura = new System.Windows.Forms.Label();
            this.nudDemaos = new System.Windows.Forms.NumericUpDown();
            this.lblDemaos = new System.Windows.Forms.Label();
            this.cbxDark = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDemaos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLarg
            // 
            this.lblLarg.AutoSize = true;
            this.lblLarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarg.Location = new System.Drawing.Point(75, 115);
            this.lblLarg.Name = "lblLarg";
            this.lblLarg.Size = new System.Drawing.Size(145, 16);
            this.lblLarg.TabIndex = 0;
            this.lblLarg.Text = "Largura da parede (m):";
            // 
            // pbxLogoApp
            // 
            this.pbxLogoApp.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoApp.Image")));
            this.pbxLogoApp.Location = new System.Drawing.Point(149, 0);
            this.pbxLogoApp.Name = "pbxLogoApp";
            this.pbxLogoApp.Size = new System.Drawing.Size(95, 95);
            this.pbxLogoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoApp.TabIndex = 1;
            this.pbxLogoApp.TabStop = false;
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.ForeColor = System.Drawing.Color.Black;
            this.lblAlt.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblAlt.Location = new System.Drawing.Point(75, 143);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(133, 16);
            this.lblAlt.TabIndex = 0;
            this.lblAlt.Text = "Altura da parede (m):";
            // 
            // txtLarg
            // 
            this.txtLarg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLarg.Location = new System.Drawing.Point(234, 112);
            this.txtLarg.MaxLength = 3;
            this.txtLarg.Name = "txtLarg";
            this.txtLarg.Size = new System.Drawing.Size(69, 22);
            this.txtLarg.TabIndex = 1;
            this.txtLarg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLarg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLarg_KeyPress);
            // 
            // txtAlt
            // 
            this.txtAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlt.Location = new System.Drawing.Point(234, 140);
            this.txtAlt.MaxLength = 3;
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(69, 22);
            this.txtAlt.TabIndex = 2;
            this.txtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlt_KeyPress);
            // 
            // lblRend
            // 
            this.lblRend.AutoSize = true;
            this.lblRend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRend.Location = new System.Drawing.Point(48, 207);
            this.lblRend.Name = "lblRend";
            this.lblRend.Size = new System.Drawing.Size(215, 16);
            this.lblRend.TabIndex = 0;
            this.lblRend.Text = "Rendimento por embalagem (m²) : ";
            // 
            // txtRend
            // 
            this.txtRend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRend.Location = new System.Drawing.Point(261, 204);
            this.txtRend.MaxLength = 3;
            this.txtRend.Name = "txtRend";
            this.txtRend.Size = new System.Drawing.Size(69, 22);
            this.txtRend.TabIndex = 3;
            this.txtRend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRend_KeyPress);
            // 
            // lblEmb
            // 
            this.lblEmb.AutoSize = true;
            this.lblEmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmb.Location = new System.Drawing.Point(73, 354);
            this.lblEmb.Name = "lblEmb";
            this.lblEmb.Size = new System.Drawing.Size(171, 16);
            this.lblEmb.TabIndex = 0;
            this.lblEmb.Text = "Embalagens necessárias:  ";
            // 
            // txtEmb
            // 
            this.txtEmb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmb.Enabled = false;
            this.txtEmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmb.Location = new System.Drawing.Point(236, 351);
            this.txtEmb.Name = "txtEmb";
            this.txtEmb.Size = new System.Drawing.Size(69, 22);
            this.txtEmb.TabIndex = 3;
            this.txtEmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(124, 278);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 41);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Tinta";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(111, 388);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(192, 388);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblAssinatura
            // 
            this.lblAssinatura.AutoSize = true;
            this.lblAssinatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssinatura.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAssinatura.Location = new System.Drawing.Point(198, 445);
            this.lblAssinatura.Name = "lblAssinatura";
            this.lblAssinatura.Size = new System.Drawing.Size(173, 16);
            this.lblAssinatura.TabIndex = 0;
            this.lblAssinatura.Text = "Criado por Fernando Ascari";
            // 
            // nudDemaos
            // 
            this.nudDemaos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDemaos.Location = new System.Drawing.Point(261, 244);
            this.nudDemaos.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDemaos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDemaos.Name = "nudDemaos";
            this.nudDemaos.Size = new System.Drawing.Size(69, 20);
            this.nudDemaos.TabIndex = 4;
            this.nudDemaos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDemaos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDemaos
            // 
            this.lblDemaos.AutoSize = true;
            this.lblDemaos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemaos.Location = new System.Drawing.Point(48, 248);
            this.lblDemaos.Name = "lblDemaos";
            this.lblDemaos.Size = new System.Drawing.Size(156, 16);
            this.lblDemaos.TabIndex = 0;
            this.lblDemaos.Text = "Quantidade de demãos: ";
            // 
            // cbxDark
            // 
            this.cbxDark.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxDark.BackColor = System.Drawing.Color.Gray;
            this.cbxDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDark.Location = new System.Drawing.Point(351, 10);
            this.cbxDark.Name = "cbxDark";
            this.cbxDark.Size = new System.Drawing.Size(20, 20);
            this.cbxDark.TabIndex = 8;
            this.cbxDark.UseVisualStyleBackColor = false;
            this.cbxDark.CheckedChanged += new System.EventHandler(this.cbxDark_CheckedChanged);
            // 
            // frmCalculaTinta
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(378, 471);
            this.Controls.Add(this.cbxDark);
            this.Controls.Add(this.nudDemaos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtEmb);
            this.Controls.Add(this.txtRend);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtLarg);
            this.Controls.Add(this.lblEmb);
            this.Controls.Add(this.pbxLogoApp);
            this.Controls.Add(this.lblAssinatura);
            this.Controls.Add(this.lblDemaos);
            this.Controls.Add(this.lblRend);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblLarg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(394, 510);
            this.MinimumSize = new System.Drawing.Size(394, 510);
            this.Name = "frmCalculaTinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcula Tinta";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDemaos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLarg;
        private System.Windows.Forms.PictureBox pbxLogoApp;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.TextBox txtLarg;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.Label lblRend;
        private System.Windows.Forms.TextBox txtRend;
        private System.Windows.Forms.Label lblEmb;
        private System.Windows.Forms.TextBox txtEmb;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblAssinatura;
        private System.Windows.Forms.NumericUpDown nudDemaos;
        private System.Windows.Forms.Label lblDemaos;
        private System.Windows.Forms.CheckBox cbxDark;
    }
}

