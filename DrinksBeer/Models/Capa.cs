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
			mostraPedidos();
        }		
		private void mostraPedidos()
		{
			mDataSet = new DataSet();

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			mAdapter = new MySqlDataAdapter("SELECT pedido from itempedido where pedido is not null", mConn);

			mAdapter.Fill(mDataSet, "ITEMPEDIDO");

			tblPedidos.DataSource = mDataSet;

			tblPedidos.DataMember = "ITEMPEDIDO";

		}
		private void Capa_Load(object sender, EventArgs e)
        { }
		private void btnIniciar_Click(object sender, EventArgs e)
        {
			string Pedido_data = "";
			DateTime pedido_data = DateTime.Now;
			Pedido_data = pedido_data.Year.ToString() + pedido_data.Month.ToString() + pedido_data.Day.ToString()
				+ pedido_data.Hour.ToString() + pedido_data.Minute.ToString() + pedido_data.Second.ToString() +
				pedido_data.Millisecond.ToString();

			mDataSet = new DataSet();

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();
			
			mAdapter = new MySqlDataAdapter("INSERT INTO itempedido(pedido)" + "VALUES('" + Pedido_data + "')", mConn);

			mConn.Close();

			mAdapter.Fill(mDataSet, "itempedido");

			Visible = false;
            new telaCardapio().Show();
        }
        private void label2_Click(object sender, EventArgs e)
        { }
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
	}
}
