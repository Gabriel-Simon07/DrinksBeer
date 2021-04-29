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
		public static string Pedido_data1 = "";
		public static string Grid_data1 = "";

		public Capa()
		{
			InitializeComponent();
			geraNumPedido();
			geraNumDia();
		}
		private void geraNumPedido()
		{
			DateTime pedido_data1 = DateTime.Now;
			Pedido_data1 = pedido_data1.Year.ToString() + pedido_data1.Month.ToString() + pedido_data1.Day.ToString()
				+ pedido_data1.Hour.ToString() + pedido_data1.Minute.ToString() + pedido_data1.Second.ToString() +
				pedido_data1.Millisecond.ToString();
		}
		private void geraNumDia()
		{
			DateTime grid_data1 = DateTime.Now;
			Grid_data1 = grid_data1.Year.ToString() + grid_data1.Month.ToString() + grid_data1.Day.ToString();
		}
		private void Capa_Load(object sender, EventArgs e)
		{			
			this.pedidoTableAdapter.Fill(this.sadrinksbeerDataSet7.pedido);
			mDataSet = new DataSet();

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			mAdapter = new MySqlDataAdapter($"select numeroPedido from " +
				"sadrinksbeer.pedido where numeroPedido like'" + Grid_data1 + "%"+"';", mConn);

			mAdapter.Fill(mDataSet, "PEDIDO");

			tblPedidos.DataSource = mDataSet;

			tblPedidos.DataMember = "PEDIDO";

			this.itempedidoTableAdapter.Fill(this.sadrinksbeerDataSet5.itempedido);
		}
		private void btnIniciar_Click(object sender, EventArgs e)
		{
			Visible = false;
			new telaCardapio().Show();
		}
		private void label2_Click(object sender, EventArgs e)
		{ }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void btnBkpItempedido_Click(object sender, EventArgs e)
		{
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");
			mConn.Open();
			string hj = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();

			string sql = "CREATE TABLE ITEMPEDIDO" + hj + " AS SELECT * FROM ITEMPEDIDO";
			MySqlCommand command = new MySqlCommand(sql, mConn);
			int a = command.ExecuteNonQuery();

			mConn.Close();
			if (a > 0)
				MessageBox.Show("backup criado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnBkpPedido_Click(object sender, EventArgs e)
		{
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");
			mConn.Open();
			string hj = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();

			string sql = "CREATE TABLE PEDIDO" + hj + " AS SELECT * FROM PEDIDO";
			MySqlCommand command = new MySqlCommand(sql, mConn);
			int a = command.ExecuteNonQuery();

			mConn.Close();
			if (a > 0)
				MessageBox.Show("backup criado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}
