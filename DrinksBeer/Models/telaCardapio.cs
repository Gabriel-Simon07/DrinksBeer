using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DrinksBeer.Models
{
    public partial class telaCardapio : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public telaCardapio()
        {
            InitializeComponent();
            mostraAlcoolicos();
            mostraNao_alcoolicos();
            mostraCarrinho();
        }

        private void mostraCarrinho()
        {
            {

                mDataSet = new DataSet();

                mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

                mConn.Open();

                

                mAdapter = new MySqlDataAdapter("SELECT * FROM ITEMPEDIDO WHERE qtd>0", mConn);

                

                mAdapter.Fill(mDataSet, "ITEMPEDIDO");



                tblCarinho.DataSource = mDataSet;

                tblCarinho.DataMember = "ITEMPEDIDO";

            }
        }

        private void mostraNao_alcoolicos()
        {
            string dados = ("datasource=localhost;port=3306;username=root");
            string comando = ("select * from sadrinksbeer.ITEMPEDIDO where vendaLivre = 's';");
            MySqlConnection conexao = new MySqlConnection(dados);
            MySqlCommand cmdBanco = new MySqlCommand(comando, conexao);
            MySqlDataReader ler;
            try
            {
                conexao.Open();
                ler = cmdBanco.ExecuteReader();

                while (ler.Read())
                {
                    string nomeProduto = (ler.GetString("nomeProduto")) + " - R$ " + (ler.GetString("valorProduto")) + ",00";
                    cbmNao_alcoolicos.Items.Add(nomeProduto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro");
            }
        }
        private void mostraAlcoolicos()
        {
            string dados = ("datasource=localhost;port=3306;username=root");
            string comando = ("select * from sadrinksbeer.itempedido where vendaLivre = 'n';");
            MySqlConnection conexao = new MySqlConnection(dados);
            MySqlCommand cmdBanco = new MySqlCommand(comando, conexao);
            MySqlDataReader ler;
            
            try
            {
                conexao.Open();
                ler = cmdBanco.ExecuteReader();

                while (ler.Read())
                {
                    string nomeProduto =( ler.GetString("nomeProduto"))+" - R$ "+(ler.GetString("valorProduto"))+",00";
                    cmbAlcoolicos.Items.Add(nomeProduto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro");                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_pedido_Click(object sender, EventArgs e)
        {
            Visible = false;
            new Capa().Show();
        }

        private void btnFinalizar_cardapio_Click(object sender, EventArgs e)
        {
            Visible = false;
            new telaPagamento().Show();
        }

        private void telaCardapio_Load(object sender, EventArgs e)
        {			
			this.itempedidoTableAdapter.Fill(this.sadrinksbeerDataSet2.itempedido);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbAlcoolicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAtualiza_lista_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

            mConn.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO ITEMPEDIDO(id_itempedido, nomeProduto, valorProduto," +
				" vendaLivre, pedido, subtotal, qtd)"
                + "VALUES('" + txtAlcoolicos.Text + "',)", mConn);
			
			command.ExecuteNonQuery();

            mConn.Close();
                       
            mostraCarrinho();
        }

		private void label4_Click_1(object sender, EventArgs e)
		{

		}
	}
}
