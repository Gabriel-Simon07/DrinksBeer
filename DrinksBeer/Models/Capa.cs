using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinksBeer.Models;
using MySql.Data.MySqlClient;

namespace DrinksBeer.Models
{
	public partial class Capa : Form
	{
		private MySqlConnection mConn;
		private MySqlDataAdapter mAdapter;
		private DataSet mDataSet;


		public Capa()
		{
			InitializeComponent();
			//mostraPedidos();
			geraNumPedido();
		}

		private void geraNumPedido()
		{
			string Pedido_data1 = "";
			DateTime pedido_data1 = DateTime.Now;
			Pedido_data1 = pedido_data1.Year.ToString() + pedido_data1.Month.ToString() + pedido_data1.Day.ToString()
				+ pedido_data1.Hour.ToString() + pedido_data1.Minute.ToString() + pedido_data1.Second.ToString() +
				pedido_data1.Millisecond.ToString();
		}

		//private void mostraCarinho1()
		//{
		//	string Pedido_data1 = "";
		//	DateTime pedido_data1 = DateTime.Now;
		//	Pedido_data1 = pedido_data1.Year.ToString() + pedido_data1.Month.ToString() + pedido_data1.Day.ToString()
		//		+ pedido_data1.Hour.ToString() + pedido_data1.Minute.ToString() + pedido_data1.Second.ToString() +
		//		pedido_data1.Millisecond.ToString();

		//	mDataSet = new DataSet();

		//	mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

		//	mConn.Open();

		//	MySqlCommand command = new MySqlCommand("INSERT INTO itempedido(pedido)" + "VALUES('" + Pedido_data1 + "')", mConn);
		//	command.ExecuteNonQuery();
		//	//mAdapter.Fill(mDataSet, "itempedido");
		//	mConn.Close();
		//}

		//private void mostraPedidos()
		//{
		//	mDataSet = new DataSet();

		//	mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

		//	mConn.Open();

		//	mAdapter = new MySqlDataAdapter("SELECT pedido from itempedido where pedido is not null", mConn);

		//	mAdapter.Fill(mDataSet, "ITEMPEDIDO");

		//	tblPedidos.DataSource = mDataSet;

		//	tblPedidos.DataMember = "ITEMPEDIDO";

		//}
		private void Capa_Load(object sender, EventArgs e)
		{ }
		//private void mostraCarinho2()
		//{
		//	string Pedido_data1 = "";
		//	DateTime pedido_data1 = DateTime.Now;
		//	Pedido_data1 = pedido_data1.Year.ToString() + pedido_data1.Month.ToString() + pedido_data1.Day.ToString()
		//		+ pedido_data1.Hour.ToString() + pedido_data1.Minute.ToString() + pedido_data1.Second.ToString() +
		//		pedido_data1.Millisecond.ToString();

			//mDataSet = new DataSet();

			//mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			//mConn.Open();

			//MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(numeroPedido)" + "VALUES('" + Pedido_data1 + "')", mConn);

			//command.ExecuteNonQuery();

			//mAdapter.Fill(mDataSet, "PEDIDO");

			//mConn.Close();
			
		//}
		private void btnIniciar_Click(object sender, EventArgs e)
		{
			//mostraCarinho1();
			//mostraCarinho2();

			Visible = false;
			new telaCardapio().Show();
		}
		private void label2_Click(object sender, EventArgs e)
		{ }
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{ }
	}
}
