namespace CadastroEJC_Catedral
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.bd_ejcDataSet = new CadastroEJC_Catedral.bd_ejcDataSet();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblParoquia = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome_Pai = new System.Windows.Forms.Label();
            this.lblNome_Mae = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtParoquia = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome_Pai = new System.Windows.Forms.TextBox();
            this.txtNome_Mae = new System.Windows.Forms.TextBox();
            this.pictureBox_Foto = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxCrisma = new System.Windows.Forms.CheckBox();
            this.checkBoxBatismo = new System.Windows.Forms.CheckBox();
            this.checkBoxEucaristia = new System.Windows.Forms.CheckBox();
            this.txtDtNasc = new System.Windows.Forms.TextBox();
            this.lblLocalEJC = new System.Windows.Forms.Label();
            this.txtLocalEJC = new System.Windows.Forms.TextBox();
            this.lblAnoEJC = new System.Windows.Forms.Label();
            this.txtAnoEJC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ejcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).BeginInit();
            this.groupBoxDadosPessoais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bd_ejcDataSet
            // 
            this.bd_ejcDataSet.DataSetName = "bd_ejcDataSet";
            this.bd_ejcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(6, 25);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(59, 13);
            this.lblEndereço.TabIndex = 1;
            this.lblEndereço.Text = "Endereço: ";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 56);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblParoquia
            // 
            this.lblParoquia.AutoSize = true;
            this.lblParoquia.Location = new System.Drawing.Point(6, 52);
            this.lblParoquia.Name = "lblParoquia";
            this.lblParoquia.Size = new System.Drawing.Size(117, 13);
            this.lblParoquia.TabIndex = 3;
            this.lblParoquia.Text = "Paróquia que Participa:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(234, 91);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 4;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(6, 91);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDtNasc.TabIndex = 5;
            this.lblDtNasc.Text = "Data de Nascimento:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(332, 25);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(195, 56);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 7;
            this.lblUF.Text = "UF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(307, 56);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome_Pai
            // 
            this.lblNome_Pai.AutoSize = true;
            this.lblNome_Pai.Location = new System.Drawing.Point(6, 128);
            this.lblNome_Pai.Name = "lblNome_Pai";
            this.lblNome_Pai.Size = new System.Drawing.Size(25, 13);
            this.lblNome_Pai.TabIndex = 12;
            this.lblNome_Pai.Text = "Pai:";
            // 
            // lblNome_Mae
            // 
            this.lblNome_Mae.AutoSize = true;
            this.lblNome_Mae.Location = new System.Drawing.Point(6, 159);
            this.lblNome_Mae.Name = "lblNome_Mae";
            this.lblNome_Mae.Size = new System.Drawing.Size(31, 13);
            this.lblNome_Mae.TabIndex = 13;
            this.lblNome_Mae.Text = "Mãe:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(68, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 22);
            this.txtNome.TabIndex = 14;
            // 
            // txtParoquia
            // 
            this.txtParoquia.Location = new System.Drawing.Point(129, 49);
            this.txtParoquia.Name = "txtParoquia";
            this.txtParoquia.Size = new System.Drawing.Size(273, 20);
            this.txtParoquia.TabIndex = 15;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(71, 25);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(252, 20);
            this.txtEndereco.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(376, 22);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(141, 20);
            this.txtBairro.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(55, 53);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(134, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(225, 53);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(45, 20);
            this.txtUF.TabIndex = 19;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(285, 88);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(117, 20);
            this.txtApelido.TabIndex = 21;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(376, 53);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(141, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // txtNome_Pai
            // 
            this.txtNome_Pai.Location = new System.Drawing.Point(36, 125);
            this.txtNome_Pai.Name = "txtNome_Pai";
            this.txtNome_Pai.Size = new System.Drawing.Size(297, 20);
            this.txtNome_Pai.TabIndex = 23;
            // 
            // txtNome_Mae
            // 
            this.txtNome_Mae.Location = new System.Drawing.Point(36, 156);
            this.txtNome_Mae.Name = "txtNome_Mae";
            this.txtNome_Mae.Size = new System.Drawing.Size(297, 20);
            this.txtNome_Mae.TabIndex = 24;
            // 
            // pictureBox_Foto
            // 
            this.pictureBox_Foto.Location = new System.Drawing.Point(12, 20);
            this.pictureBox_Foto.Name = "pictureBox_Foto";
            this.pictureBox_Foto.Size = new System.Drawing.Size(101, 131);
            this.pictureBox_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Foto.TabIndex = 25;
            this.pictureBox_Foto.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 29);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(137, 382);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 29);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(259, 382);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(97, 29);
            this.btnDeletar.TabIndex = 28;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(379, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 29);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "O importante é a Rosa!";
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.Controls.Add(this.txtAnoEJC);
            this.groupBoxDadosPessoais.Controls.Add(this.lblAnoEJC);
            this.groupBoxDadosPessoais.Controls.Add(this.txtLocalEJC);
            this.groupBoxDadosPessoais.Controls.Add(this.lblLocalEJC);
            this.groupBoxDadosPessoais.Controls.Add(this.txtEndereco);
            this.groupBoxDadosPessoais.Controls.Add(this.lblEndereço);
            this.groupBoxDadosPessoais.Controls.Add(this.txtApelido);
            this.groupBoxDadosPessoais.Controls.Add(this.txtCidade);
            this.groupBoxDadosPessoais.Controls.Add(this.lblCidade);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBairro);
            this.groupBoxDadosPessoais.Controls.Add(this.txtDtNasc);
            this.groupBoxDadosPessoais.Controls.Add(this.lblApelido);
            this.groupBoxDadosPessoais.Controls.Add(this.txtTelefone);
            this.groupBoxDadosPessoais.Controls.Add(this.txtUF);
            this.groupBoxDadosPessoais.Controls.Add(this.lblDtNasc);
            this.groupBoxDadosPessoais.Controls.Add(this.txtNome_Pai);
            this.groupBoxDadosPessoais.Controls.Add(this.lblNome_Mae);
            this.groupBoxDadosPessoais.Controls.Add(this.lblBairro);
            this.groupBoxDadosPessoais.Controls.Add(this.lblTelefone);
            this.groupBoxDadosPessoais.Controls.Add(this.txtNome_Mae);
            this.groupBoxDadosPessoais.Controls.Add(this.lblUF);
            this.groupBoxDadosPessoais.Controls.Add(this.lblNome_Pai);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(15, 49);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(525, 231);
            this.groupBoxDadosPessoais.TabIndex = 31;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados Pessoais";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEucaristia);
            this.groupBox1.Controls.Add(this.checkBoxBatismo);
            this.groupBox1.Controls.Add(this.checkBoxCrisma);
            this.groupBox1.Controls.Add(this.lblParoquia);
            this.groupBox1.Controls.Add(this.txtParoquia);
            this.groupBox1.Location = new System.Drawing.Point(15, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 78);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vida Sacramental";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_Foto);
            this.groupBox2.Location = new System.Drawing.Point(554, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 163);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto";
            // 
            // checkBoxCrisma
            // 
            this.checkBoxCrisma.AutoSize = true;
            this.checkBoxCrisma.Location = new System.Drawing.Point(276, 24);
            this.checkBoxCrisma.Name = "checkBoxCrisma";
            this.checkBoxCrisma.Size = new System.Drawing.Size(57, 17);
            this.checkBoxCrisma.TabIndex = 16;
            this.checkBoxCrisma.Text = "Crisma";
            this.checkBoxCrisma.UseVisualStyleBackColor = true;
            // 
            // checkBoxBatismo
            // 
            this.checkBoxBatismo.AutoSize = true;
            this.checkBoxBatismo.Location = new System.Drawing.Point(9, 23);
            this.checkBoxBatismo.Name = "checkBoxBatismo";
            this.checkBoxBatismo.Size = new System.Drawing.Size(63, 17);
            this.checkBoxBatismo.TabIndex = 17;
            this.checkBoxBatismo.Text = "Batismo";
            this.checkBoxBatismo.UseVisualStyleBackColor = true;
            // 
            // checkBoxEucaristia
            // 
            this.checkBoxEucaristia.AutoSize = true;
            this.checkBoxEucaristia.Location = new System.Drawing.Point(110, 22);
            this.checkBoxEucaristia.Name = "checkBoxEucaristia";
            this.checkBoxEucaristia.Size = new System.Drawing.Size(112, 17);
            this.checkBoxEucaristia.TabIndex = 18;
            this.checkBoxEucaristia.Text = "Primeira Eucaristia";
            this.checkBoxEucaristia.UseVisualStyleBackColor = true;
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Location = new System.Drawing.Point(119, 88);
            this.txtDtNasc.MaxLength = 3;
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(109, 20);
            this.txtDtNasc.TabIndex = 20;
            // 
            // lblLocalEJC
            // 
            this.lblLocalEJC.AutoSize = true;
            this.lblLocalEJC.Location = new System.Drawing.Point(6, 194);
            this.lblLocalEJC.Name = "lblLocalEJC";
            this.lblLocalEJC.Size = new System.Drawing.Size(105, 13);
            this.lblLocalEJC.TabIndex = 25;
            this.lblLocalEJC.Text = "Local que fez o EJC:";
            // 
            // txtLocalEJC
            // 
            this.txtLocalEJC.Location = new System.Drawing.Point(110, 191);
            this.txtLocalEJC.Name = "txtLocalEJC";
            this.txtLocalEJC.Size = new System.Drawing.Size(242, 20);
            this.txtLocalEJC.TabIndex = 26;
            // 
            // lblAnoEJC
            // 
            this.lblAnoEJC.AutoSize = true;
            this.lblAnoEJC.Location = new System.Drawing.Point(361, 194);
            this.lblAnoEJC.Name = "lblAnoEJC";
            this.lblAnoEJC.Size = new System.Drawing.Size(51, 13);
            this.lblAnoEJC.TabIndex = 27;
            this.lblAnoEJC.Text = "Ano EJC:";
            // 
            // txtAnoEJC
            // 
            this.txtAnoEJC.Location = new System.Drawing.Point(418, 194);
            this.txtAnoEJC.Name = "txtAnoEJC";
            this.txtAnoEJC.Size = new System.Drawing.Size(64, 20);
            this.txtAnoEJC.TabIndex = 28;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(703, 422);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.Text = "Cadastro de Membros do EJC";
            ((System.ComponentModel.ISupportInitialize)(this.bd_ejcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).EndInit();
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bd_ejcDataSet bd_ejcDataSet;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblParoquia;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome_Pai;
        private System.Windows.Forms.Label lblNome_Mae;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtParoquia;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome_Pai;
        private System.Windows.Forms.TextBox txtNome_Mae;
        private System.Windows.Forms.PictureBox pictureBox_Foto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxEucaristia;
        private System.Windows.Forms.CheckBox checkBoxBatismo;
        private System.Windows.Forms.CheckBox checkBoxCrisma;
        private System.Windows.Forms.TextBox txtDtNasc;
        private System.Windows.Forms.TextBox txtAnoEJC;
        private System.Windows.Forms.Label lblAnoEJC;
        private System.Windows.Forms.TextBox txtLocalEJC;
        private System.Windows.Forms.Label lblLocalEJC;
    }
}

