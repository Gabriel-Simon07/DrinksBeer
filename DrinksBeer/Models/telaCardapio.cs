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

                

                mAdapter = new MySqlDataAdapter("SELECT * FROM PEDIDO", mConn);

                

                mAdapter.Fill(mDataSet, "PEDIDO");



                tblCarinho.DataSource = mDataSet;

                tblCarinho.DataMember = "PEDIDO";

            }
        }

        private void mostraNao_alcoolicos()
        {
            string dados = ("datasource=localhost;port=3306;username=root");
            string comando = ("select * from sadrinksbeer.bebidas where vendaLivre = 's';");
            MySqlConnection conexao = new MySqlConnection(dados);
            MySqlCommand cmdBanco = new MySqlCommand(comando, conexao);
            MySqlDataReader ler;
            try
            {
                conexao.Open();
                ler = cmdBanco.ExecuteReader();

                while (ler.Read())
                {
                    string nomeProduto = (ler.GetString("nomeProdutos")) + " - R$ " + (ler.GetString("valorProdutos")) + ",00";
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
            string comando = ("select * from sadrinksbeer.bebidas where vendaLivre = 'n';");
            MySqlConnection conexao = new MySqlConnection(dados);
            MySqlCommand cmdBanco = new MySqlCommand(comando, conexao);
            MySqlDataReader ler;
            
            try
            {
                conexao.Open();
                ler = cmdBanco.ExecuteReader();

                while (ler.Read())
                {
                    string nomeProduto =( ler.GetString("nomeProdutos"))+" - R$ "+(ler.GetString("valorProdutos"))+",00";
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
            // TODO: esta linha de código carrega dados na tabela 'sadrinksbeerDataSet1.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.sadrinksbeerDataSet1.pedido);


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

            MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(prodSel, qtdSel)"
                + "VALUES('" + cmbAlcoolicos.Text + "','" + txtAlcoolicos.Text + "')", mConn);

            command.ExecuteNonQuery();

            mConn.Close();
                       
            mostraCarrinho();
        }
    }
}
