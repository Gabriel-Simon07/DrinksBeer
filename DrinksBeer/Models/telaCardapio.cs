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
using System.Data.SqlClient;


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

		public static string txEntrega = "Taxa de entrega";
		public static double txEntregaValor = 9;

		private MySqlDataReader aReader;
		private MySqlConnection mConn;
		private MySqlDataAdapter mAdapter;
		private DataSet mDataSet;
		public static double soma = 0;
		public static double total = 0;
		public static double valorItem=0;

		public telaCardapio()
		{
			InitializeComponent();
			cmbAlcoolicos.DataSource = alcoolicos;
			cbmNao_alcoolicos.DataSource = naoAlcoolicos;
			mostraCarrinho();
			atualizaCarrinho();
			labelTotal.Text = Program.total.ToString();
			//verificaRegistros();
		}

		

		private void somaValores()
		{
			Program.total = 0;

			mDataSet = new DataSet();

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			MySqlCommand command = new MySqlCommand($"select sum(subtotal) from itempedido where pedido='{Capa.Pedido_data1}';", mConn);

			mAdapter.Fill(mDataSet, "ITEMPEDIDO");

			tblCarinho.DataSource = mDataSet;

			tblCarinho.DataMember = "ITEMPEDIDO";

			aReader = command.ExecuteReader();
			if (aReader.Read())
			{
				Program.total += double.Parse(aReader.GetValue(0).ToString());
			}

			mConn.Close();
			labelTotal.Text = Program.total.ToString();
		}
		private void label4_Click(object sender, EventArgs e)
		{ }
		private void btnCancelar_pedido_Click(object sender, EventArgs e)
		{
			Visible = false;
			new Capa().Show();
		}
		public static int valor = 0;
		private void btnFinalizar_cardapio_Click(object sender, EventArgs e)
		{
			while (String.IsNullOrWhiteSpace(txtAlcoolicos.Text) || String.IsNullOrWhiteSpace(txtNao_alcoolicos.Text))
			{
				MessageBox.Show("Fique a vontade para comprar o que quiser");
				return;
			}
			if (int.Parse(txtAlcoolicos.Text) >= 1 || int.Parse(txtNao_alcoolicos.Text) >= 1)
			{
				Visible = false;
				new telaCadastroUsuario().Show();
			}
			try
			{
				Cadastro cadastro = new Cadastro()
				{
					QtdMinAlcool = int.Parse(txtAlcoolicos.Text),
					QtdMinS_alcool = int.Parse(txtNao_alcoolicos.Text)
				};
			}
			catch (Exception erro)
			{
				MessageBox.Show(erro.Message);
			}

		}

		private void telaCardapio_Load(object sender, EventArgs e)
		{
			this.itempedidoTableAdapter1.Fill(this.sadrinksbeerDataSet3.itempedido);			
		}

		private void atualizaCarrinho()
		{
			mDataSet = new DataSet();

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			mAdapter = new MySqlDataAdapter($"select * from itempedido where pedido='{Capa.Pedido_data1}';", mConn);

			mAdapter.Fill(mDataSet, "ITEMPEDIDO");

			tblCarinho.DataSource = mDataSet;

			tblCarinho.DataMember = "ITEMPEDIDO";
		}

		public static string nomeProduto = "";
		private void deletaGrid()
		{
			nomeProduto = tblCarinho.CurrentRow.Cells[0].Value.ToString();

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			MySqlCommand command = new MySqlCommand($"DELETE FROM ITEMPEDIDO WHERE nomeProduto='" + nomeProduto + "' and pedido =  " + Capa.Pedido_data1, mConn);

			command.ExecuteNonQuery();

			mConn.Close();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{ }
		private void cmbAlcoolicos_SelectedIndexChanged(object sender, EventArgs e)
		{ }
		private void mostraCarrinho()
		{
			mDataSet = new DataSet();

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			mAdapter = new MySqlDataAdapter($"SELECT nomeProduto, valorProduto, subtotal,qtd FROM ITEMPEDIDO where pedido ='{Capa.Pedido_data1}'", mConn);

			mAdapter.Fill(mDataSet, "ITEMPEDIDO");

			tblCarinho.DataSource = mDataSet;

			tblCarinho.DataMember = "ITEMPEDIDO";
		}

		public void valorTotal()
		{
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();
			MySqlCommand command = new MySqlCommand($"select subtotal from itempedido where id_itempedido=" +
				$"(select max(id_itempedido) from itempedido)", mConn);

			aReader = command.ExecuteReader();
			if (aReader.Read())
			{
				Program.total += double.Parse(aReader.GetValue(0).ToString());
			}
			mConn.Close();
			labelTotal.Text = Program.total.ToString();
		}
		
		private void btnAtualiza_lista_Click(object sender, EventArgs e)
		{


			while (String.IsNullOrWhiteSpace(txtAlcoolicos.Text) || int.Parse(txtAlcoolicos.Text) <= 0)
			{
				MessageBox.Show("É importante que todos os campos estejam preenchidos");
				return;
			}
			if (int.Parse(txtAlcoolicos.Text) >= 1 || int.Parse(txtNao_alcoolicos.Text) >= 1)
			{
				string nomeBebida = alcoolicosNomes[cmbAlcoolicos.SelectedIndex];
				double precoBebida = alcoolicosPrecos[cmbAlcoolicos.SelectedIndex];
				double valorItem = precoBebida * Convert.ToDouble(txtAlcoolicos.Text);

				mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

				mConn.Open();

				MySqlCommand command = new MySqlCommand("INSERT INTO ITEMPEDIDO (qtd, nomeProduto, valorProduto, subtotal, pedido, vendaLivre)"
				+ "VALUES(" + int.Parse(txtAlcoolicos.Text) + ",'" + nomeBebida + "'," + precoBebida + "," + valorItem + "," + Capa.Pedido_data1 + ",'n')", mConn);

				command.ExecuteNonQuery();
				mostraCarrinho();
				valorTotal();
				mConn.Close();
			}
		}
		//private void verificaRegistros()
		//{
			
		//	mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=testeBd");

		//	mConn.Open();

		//	MySqlCommand command = new MySqlCommand("UPDATE itempedido SET qtd= '" + txtAlcoolicos.Text + "',subtotal='" + valorItem + "' WHERE nomeProduto=" +txtAlcoolicos.Text, mConn);

		//	command.ExecuteNonQuery();

		//	mConn.Close();
		//}
		private void label4_Click_1(object sender, EventArgs e)
		{ }
		private void button3_Click(object sender, EventArgs e)
		{
			string nomeBebida = naoAlcoolicosNomes[cbmNao_alcoolicos.SelectedIndex];
			double precoBebida = naoAlcoolicosPrecos[cbmNao_alcoolicos.SelectedIndex];
			double valorItem = precoBebida * Convert.ToDouble(txtNao_alcoolicos.Text);

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			MySqlCommand command = new MySqlCommand("INSERT INTO ITEMPEDIDO (qtd, nomeProduto, valorProduto, subtotal, pedido, vendaLivre)"
				+ "VALUES(" + txtNao_alcoolicos.Text + ",'" + nomeBebida + "'," + precoBebida + "," + valorItem + "," + Capa.Pedido_data1 + ",'s')", mConn);

			command.ExecuteNonQuery();
			//verificaRegistros();
			mostraCarrinho();
			valorTotal();
			mConn.Close();
		}
		private void button1_Click(object sender, EventArgs e)
		{ }
		private void groupBox1_Enter(object sender, EventArgs e)
		{ }
		private void cbmNao_alcoolicos_SelectedIndexChanged(object sender, EventArgs e)
		{ }
		private void labelTotal_Click(object sender, EventArgs e)
		{ }
		private void button4_Click(object sender, EventArgs e)
		{
			if (Program.total == 0)
			{
				MessageBox.Show("Carrinho vazio");
			}
			else
			{
				deletaGrid();
				atualizaCarrinho();
				somaValores();
			}
		}
	}
}
