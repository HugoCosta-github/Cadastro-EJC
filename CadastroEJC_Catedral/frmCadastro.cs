using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEJC_Catedral
{

    
    public partial class frmCadastro : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bd_ejc.mdf;Integrated Security=True";
        bool novo;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ejcDataSet.jovem'. Você pode movê-la ou removê-la conforme necessário.
            this.jovemTableAdapter.Fill(this.bd_ejcDataSet.jovem);
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txtTelefone.Enabled = false;
            dtpData_Nascimento.Text = "";
            dtpData_Nascimento.Enabled = false;
            txtApelido.Enabled = false;
            txtNome_Pai.Enabled = false;
            txtNome_Mae.Enabled = false;
            txtLocalEJC.Enabled = false;
            txtAnoEJC.Enabled = false;
            checkBoxBatismo.Enabled = false;
            checkBoxEucaristia.Enabled = false;
            checkBoxCrisma.Enabled = false;
            checkBoxEspiao.Enabled = false;
            txtParoquia.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            txtTelefone.Enabled = true;
            dtpData_Nascimento.Enabled = true;
            txtApelido.Enabled = true;
            txtNome_Pai.Enabled = true;
            txtNome_Mae.Enabled = true;
            txtLocalEJC.Enabled = true;
            txtAnoEJC.Enabled = true;
            checkBoxBatismo.Enabled = true;
            checkBoxEucaristia.Enabled = true;
            checkBoxCrisma.Enabled = true;
            checkBoxEspiao.Enabled = false;
            txtParoquia.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = true;
            novo = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO JOVEM (NOME, ENDERECO, BAIRRO, CIDADE, UF, TELEFONE, DATA_NASCIMENTO, APELIDO," +
                    "NOME_PAI, NOME_MAE, LOCALEJC, ANOEJC, ESPIAO, BATISMO, PRIMEIRA_EUCARISTIA, CRISMA, PAROQUIA)"
                      + "VALUES ('" + txtNome.Text + "', '" + txtEndereco.Text + "', '"
                      + txtBairro.Text + "', '" + txtCidade.Text + "', '"
                      + txtUF.Text + "', '" + txtTelefone.Text + "', '"
                      + dtpData_Nascimento.Text + "', '" + txtApelido.Text + "', '"
                      + txtNome_Pai.Text + "', '" + txtNome_Mae.Text + "', '"
                      + txtLocalEJC.Text + "', '" + txtAnoEJC.Text + "', '"
                      + checkBoxBatismo.Checked + "', '" + checkBoxEucaristia.Checked + "', '"
                      + checkBoxEspiao.Checked + "', '" + checkBoxCrisma.Checked + "', '" 
                      + txtParoquia.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            
        }

        private void JovemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jovemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ejcDataSet);

        }
    }
}
