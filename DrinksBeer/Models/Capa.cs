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
		public Capa()
		{
			InitializeComponent();
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
		private void Capa_Load(object sender, EventArgs e)
		{ }
		private void btnIniciar_Click(object sender, EventArgs e)
		{
			Visible = false;
			new telaCardapio().Show();
		}
		private void label2_Click(object sender, EventArgs e)
		{ }
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{ }
	}
}
