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
using DrinksBeer.Models;

namespace DrinksBeer.Models
{
	public partial class telaCadastroUsuario : Form
	{
		private MySqlConnection mConn;
		private MySqlDataAdapter mAdapter;
		private DataSet mDataSet;

		public telaCadastroUsuario()
		{
			InitializeComponent();
		}
		private void label2_Click(object sender, EventArgs e)
		{ }
		private void btnCancelar_cadastro_Click(object sender, EventArgs e)
		{
			Visible = false;
			new telaPagamento().Show();
		}
		private void telaCadastroUsuario_Load(object sender, EventArgs e)
		{ }
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(nomeCompleto," +
				" telefone, nomeRua, dataNascimento, cidade, cep, numeroCasa, bairro)" + "VALUES('" + txtNome.Text + "','"
				+ txtTelefone.Text + "','" + txtRua.Text + "','" + dtpNascimento.Text + "','" + txtCidade.Text + "','"
				+ txtCep.Text + "','" + txtNum_casa.Text + "','" + txtBairro.Text + "')", mConn);

			command.ExecuteNonQuery();

			mConn.Close();

			MessageBox.Show($"Pedido feito com Sucesso!", "Informação", MessageBoxButtons.OK,
				MessageBoxIcon.Information);

			Visible = false;
			new Capa().Show();
		}
		private void label6_Click(object sender, EventArgs e)
		{ }
		private void txtCpf_TextChanged(object sender, EventArgs e)
		{ }
		private void txtNome_TextChanged(object sender, EventArgs e)
		{ }
		private void txtIdade_TextChanged(object sender, EventArgs e)
		{ }
		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{ }
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{ }
	}
}
