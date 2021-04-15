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
using DrinksBeer.Views;

namespace DrinksBeer.Models
{


	public partial class telaCardapio : Form
	{
		string[] alcoolicos = {"Skol 350ml - R$ 3,00", "Brahma 350ml - R$ 3,00", "Whisky Jack Daniels 1L - R$ 135,0", "Whisky Red Label - R$ 130,00", "Corona 350ml - R$ 5,00",
			"Budweiser 350ml - R$ 5,00"};
		string[] alcoolicosNomes = {"Skol 350ml", "Brahma 350ml", "Whisky Jack Daniels 1L", "Whisky Red Label", "Corona 350ml",
			"Budweiser 350ml", "Red Bull 250ml"};
		double[] alcoolicosPrecos = { 3.0, 3.0, 135.0, 130.0, 5.0, 5.0 };


		string[] naoAlcoolicos = { "Coca-Cola 2L - R$ 10,0", "Fanta Laranja 2L - R$ 10,0", "Guaraná Kuat 2L - R$ 10,0", "Água Mineral 350ml - R$ 4,00", "Red Bull 250ml - R$ 12,0", "Água de Coco - R$ 6,0" };
		string[] naoAlcoolicosNomes = { "Coca-Cola 2L", "Fanta Laranja 2L", "Guaraná Kuat 2L", "Água Mineral 350ml", "Red Bull 250ml", "Água de Coco" };
		double[] naoAlcoolicosPrecos = { 10.0, 10.0, 10.0, 4.0, 12.0, 6.0 };

		private MySqlConnection mConn;
		private MySqlDataAdapter mAdapter;
		private DataSet mDataSet;
		string Pedido_data1 = "";

		public telaCardapio()
		{
			InitializeComponent();
			cmbAlcoolicos.DataSource = alcoolicos;
			cbmNao_alcoolicos.DataSource = naoAlcoolicos;
			//mostraAlcoolicos();
			//mostraNao_alcoolicos();
			//mostraCarrinho();
			//mostraValor();
		}

		//private void mostraValor()
		//{
		//	mDataSet = new DataSet();

		//	mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

		//	mConn.Open();

		//	mAdapter = new MySqlDataAdapter("SELECT valorProduto FROM itempedido;  ", mConn);

		//	mAdapter.Fill(mDataSet, "ITEMPEDIDO");

		//	tblCarinho.DataSource = mDataSet;

		//	tblCarinho.DataMember = "ITEMPEDIDO";
		//}		
		//private void mostraCarrinho()
		//{
		//	{
		//		mDataSet = new DataSet();

		//		mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

		//		mConn.Open();

		//		mAdapter = new MySqlDataAdapter("SELECT nomeProduto, valorProduto, subtotal,qtd FROM ITEMPEDIDO where id_itempedido > 12;  ", mConn);

		//		mAdapter.Fill(mDataSet, "ITEMPEDIDO");

		//		tblCarinho.DataSource = mDataSet;

		//		tblCarinho.DataMember = "ITEMPEDIDO";
		//	}
		//}

		//private void mostraNao_alcoolicos()
		//{
		//	string dados = ("datasource=localhost;port=3306;username=root");
		//	string comando = ("select * from sadrinksbeer.ITEMPEDIDO where vendaLivre = 's';");
		//	MySqlConnection conexao = new MySqlConnection(dados);
		//	MySqlCommand cmdBanco = new MySqlCommand(comando, conexao);
		//	MySqlDataReader ler;
		//	try
		//	{
		//		conexao.Open();
		//		ler = cmdBanco.ExecuteReader();

		//		while (ler.Read())
		//		{
		//			string nomeProduto = (ler.GetString("nomeProduto")) + " - R$ " + (ler.GetString("valorProduto"));
		//			cbmNao_alcoolicos.Items.Add(nomeProduto);
		//		}
		//	}
		//	catch (Exception)
		//	{
		//		MessageBox.Show("erro");
		//	}
		//}
		//private void mostraAlcoolicos()
		//{
		//	string dados = ("datasource=localhost;port=3306;username=root");
		//	string comando = ("select * from sadrinksbeer.itempedido where vendaLivre = 'n';");
		//	MySqlConnection conexao = new MySqlConnection(dados);
		//	MySqlCommand cmdBanco = new MySqlCommand(comando, conexao);
		//	MySqlDataReader ler;

		//	try
		//	{
		//		conexao.Open();
		//		ler = cmdBanco.ExecuteReader();

		//		while (ler.Read())
		//		{
		//			string nomeProduto = (ler.GetString("nomeProduto")) + " - R$ " + (ler.GetString("valorProduto"));
		//			cmbAlcoolicos.Items.Add(nomeProduto);
		//		}
		//	}
		//	catch (Exception)
		//	{
		//		MessageBox.Show("erro");
		//	}
		//}

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



			DateTime pedido_data1 = DateTime.Now;
			Pedido_data1 = pedido_data1.Year.ToString() + pedido_data1.Month.ToString() + pedido_data1.Day.ToString()
				+ pedido_data1.Hour.ToString() + pedido_data1.Minute.ToString() + pedido_data1.Second.ToString() +
				pedido_data1.Millisecond.ToString();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void cmbAlcoolicos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnAtualiza_lista_Click(object sender, EventArgs e)
		{
			string nomeBebida = alcoolicosNomes[cmbAlcoolicos.SelectedIndex];
			double precoBebida = alcoolicosPrecos[cmbAlcoolicos.SelectedIndex];
			double valorItem = precoBebida * Convert.ToDouble(txtAlcoolicos.Text);

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();
			//Column count doesn't match value count at row 1'

			MySqlCommand command = new MySqlCommand("INSERT INTO ITEMPEDIDO (qtd, nomeProduto, valorProduto, subtotal, pedido, vendaLivre)"
				+ "VALUES(" + int.Parse(txtAlcoolicos.Text) + ",'" + nomeBebida + "'," + precoBebida + "," + valorItem + "," + Pedido_data1 + ",'n')", mConn);

			command.ExecuteNonQuery();
			

			mConn.Close();
		}

		private void label4_Click_1(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string nomeBebida = naoAlcoolicosNomes[cmbAlcoolicos.SelectedIndex];
			double precoBebida = naoAlcoolicosPrecos[cmbAlcoolicos.SelectedIndex];
			double valorItem = precoBebida * Convert.ToDouble(txtNao_alcoolicos.Text);

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			MySqlCommand command = new MySqlCommand("INSERT INTO ITEMPEDIDO (qtd, nomeProduto, valorProduto, subtotal, pedido, vendaLivre)"
				+ "VALUES(" + txtNao_alcoolicos.Text + ",'" + nomeBebida + "'," + precoBebida + "," + valorItem + "," + Pedido_data1 + ",'s')", mConn);

			command.ExecuteNonQuery();

			mConn.Close();
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void cbmNao_alcoolicos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
