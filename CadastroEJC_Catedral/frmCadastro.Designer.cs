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
            this.bd_ejcDataSet = new CadastroEJC_Catedral.bd_ejcDataSet();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblParoquia = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBatismo = new System.Windows.Forms.Label();
            this.lblPrimeira_Eucaristia = new System.Windows.Forms.Label();
            this.lblCrisma = new System.Windows.Forms.Label();
            this.lblNome_Pai = new System.Windows.Forms.Label();
            this.lblNome_Mae = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtParoquia = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome_Pai = new System.Windows.Forms.TextBox();
            this.txtNome_Mae = new System.Windows.Forms.TextBox();
            this.pictureBox_Foto = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ejcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).BeginInit();
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
            this.lblNome.Location = new System.Drawing.Point(28, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(28, 59);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(59, 13);
            this.lblEndereço.TabIndex = 1;
            this.lblEndereço.Text = "Endereço: ";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(529, 59);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblParoquia
            // 
            this.lblParoquia.AutoSize = true;
            this.lblParoquia.Location = new System.Drawing.Point(447, 22);
            this.lblParoquia.Name = "lblParoquia";
            this.lblParoquia.Size = new System.Drawing.Size(49, 13);
            this.lblParoquia.TabIndex = 3;
            this.lblParoquia.Text = "Paróquia";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(169, 99);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 4;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(28, 99);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(351, 59);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(702, 59);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 7;
            this.lblUF.Text = "UF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(360, 99);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblBatismo
            // 
            this.lblBatismo.AutoSize = true;
            this.lblBatismo.Location = new System.Drawing.Point(28, 139);
            this.lblBatismo.Name = "lblBatismo";
            this.lblBatismo.Size = new System.Drawing.Size(47, 13);
            this.lblBatismo.TabIndex = 9;
            this.lblBatismo.Text = "Batismo:";
            this.lblBatismo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPrimeira_Eucaristia
            // 
            this.lblPrimeira_Eucaristia.AutoSize = true;
            this.lblPrimeira_Eucaristia.Location = new System.Drawing.Point(135, 139);
            this.lblPrimeira_Eucaristia.Name = "lblPrimeira_Eucaristia";
            this.lblPrimeira_Eucaristia.Size = new System.Drawing.Size(96, 13);
            this.lblPrimeira_Eucaristia.TabIndex = 10;
            this.lblPrimeira_Eucaristia.Text = "Primeira Eucarisita:";
            // 
            // lblCrisma
            // 
            this.lblCrisma.AutoSize = true;
            this.lblCrisma.Location = new System.Drawing.Point(304, 139);
            this.lblCrisma.Name = "lblCrisma";
            this.lblCrisma.Size = new System.Drawing.Size(41, 13);
            this.lblCrisma.TabIndex = 11;
            this.lblCrisma.Text = "Crisma:";
            // 
            // lblNome_Pai
            // 
            this.lblNome_Pai.AutoSize = true;
            this.lblNome_Pai.Location = new System.Drawing.Point(28, 176);
            this.lblNome_Pai.Name = "lblNome_Pai";
            this.lblNome_Pai.Size = new System.Drawing.Size(71, 13);
            this.lblNome_Pai.TabIndex = 12;
            this.lblNome_Pai.Text = "Nome do Pai:";
            // 
            // lblNome_Mae
            // 
            this.lblNome_Mae.AutoSize = true;
            this.lblNome_Mae.Location = new System.Drawing.Point(28, 211);
            this.lblNome_Mae.Name = "lblNome_Mae";
            this.lblNome_Mae.Size = new System.Drawing.Size(77, 13);
            this.lblNome_Mae.TabIndex = 13;
            this.lblNome_Mae.Text = "Nome da Mãe:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 20);
            this.txtNome.TabIndex = 14;
            // 
            // txtParoquia
            // 
            this.txtParoquia.Location = new System.Drawing.Point(502, 19);
            this.txtParoquia.Name = "txtParoquia";
            this.txtParoquia.Size = new System.Drawing.Size(273, 20);
            this.txtParoquia.TabIndex = 15;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(93, 56);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(252, 20);
            this.txtEndereco.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(395, 56);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(128, 20);
            this.txtBairro.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(578, 56);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(117, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(730, 56);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(45, 20);
            this.txtUF.TabIndex = 19;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(71, 96);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(57, 20);
            this.txtIdade.TabIndex = 20;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(221, 96);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(100, 20);
            this.txtApelido.TabIndex = 21;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(418, 96);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(129, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // txtNome_Pai
            // 
            this.txtNome_Pai.Location = new System.Drawing.Point(106, 176);
            this.txtNome_Pai.Name = "txtNome_Pai";
            this.txtNome_Pai.Size = new System.Drawing.Size(297, 20);
            this.txtNome_Pai.TabIndex = 23;
            // 
            // txtNome_Mae
            // 
            this.txtNome_Mae.Location = new System.Drawing.Point(106, 208);
            this.txtNome_Mae.Name = "txtNome_Mae";
            this.txtNome_Mae.Size = new System.Drawing.Size(297, 20);
            this.txtNome_Mae.TabIndex = 24;
            // 
            // pictureBox_Foto
            // 
            this.pictureBox_Foto.Location = new System.Drawing.Point(622, 110);
            this.pictureBox_Foto.Name = "pictureBox_Foto";
            this.pictureBox_Foto.Size = new System.Drawing.Size(116, 142);
            this.pictureBox_Foto.TabIndex = 25;
            this.pictureBox_Foto.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(31, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 29);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(153, 258);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 29);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(275, 258);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(97, 29);
            this.btnDeletar.TabIndex = 28;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(395, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 29);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 307);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox_Foto);
            this.Controls.Add(this.txtNome_Mae);
            this.Controls.Add(this.txtNome_Pai);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtParoquia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome_Mae);
            this.Controls.Add(this.lblNome_Pai);
            this.Controls.Add(this.lblCrisma);
            this.Controls.Add(this.lblPrimeira_Eucaristia);
            this.Controls.Add(this.lblBatismo);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblParoquia);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de Membros do EJC";
            ((System.ComponentModel.ISupportInitialize)(this.bd_ejcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).EndInit();
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
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBatismo;
        private System.Windows.Forms.Label lblPrimeira_Eucaristia;
        private System.Windows.Forms.Label lblCrisma;
        private System.Windows.Forms.Label lblNome_Pai;
        private System.Windows.Forms.Label lblNome_Mae;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtParoquia;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome_Pai;
        private System.Windows.Forms.TextBox txtNome_Mae;
        private System.Windows.Forms.PictureBox pictureBox_Foto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

