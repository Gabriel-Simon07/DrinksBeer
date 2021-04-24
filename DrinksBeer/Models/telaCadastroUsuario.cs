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
using DrinksBeer.Views;
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
			new telaCardapio().Show();
		}
		private void telaCadastroUsuario_Load(object sender, EventArgs e)
		{ label16.Text = Capa.Pedido_data1; }

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			while (String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtTelefone.Text) ||
				String.IsNullOrWhiteSpace(dtpNascimento.Text) || String.IsNullOrWhiteSpace(txtCpf.Text) ||
				String.IsNullOrWhiteSpace(txtRua.Text) || String.IsNullOrWhiteSpace(txtNum_casa.Text) || String.IsNullOrWhiteSpace(txtBairro.Text)
				|| String.IsNullOrWhiteSpace(txtCep.Text) || String.IsNullOrWhiteSpace(txtCidade.Text) || String.IsNullOrWhiteSpace(rbEnvio_casa.Text)
				|| String.IsNullOrWhiteSpace(rbRetirada_local.Text) || String.IsNullOrWhiteSpace(radioButton1.Text) || String.IsNullOrWhiteSpace(radioButton2.Text)
				|| String.IsNullOrWhiteSpace(radioButton3.Text))
			{
				MessageBox.Show("É importante que todos os campos estejam preenchidos");
				return;
			}

			try
			{
				Cadastro cadastro = new Cadastro()
				{
					Nome=txtNome.Text
				};
			}
			catch (Exception)
			{

				throw;
			}

			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();

			if (rbEnvio_casa.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(nomeCompleto," +
				" telefone, nomeRua, dataNascimento, cidade, cep, numeroCasa, bairro, formaRetirada, numeroPedido, cpf)" + "VALUES('" + txtNome.Text + "','"
				+ txtTelefone.Text + "','" + txtRua.Text + "','" + dtpNascimento.Text + "','" + txtCidade.Text + "','"
				+ txtCep.Text + "','" + txtNum_casa.Text + "','" + txtBairro.Text + "','" + rbEnvio_casa.Text + "'," + Capa.Pedido_data1 + ",'" + txtCpf.Text + "')", mConn);
				command.ExecuteNonQuery();
			}
			if (rbRetirada_local.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(nomeCompleto," +
				" telefone, nomeRua, dataNascimento, cidade, cep, numeroCasa, bairro, formaRetirada, numeroPedido, cpf)" + "VALUES('" + txtNome.Text + "','"
				+ txtTelefone.Text + "','" + txtRua.Text + "','" + dtpNascimento.Text + "','" + txtCidade.Text + "','"
				+ txtCep.Text + "','" + txtNum_casa.Text + "','" + txtBairro.Text + "','" + rbRetirada_local.Text + "'," + Capa.Pedido_data1 + ",'" + txtCpf.Text + "')", mConn);
				command.ExecuteNonQuery();
			}
			if (radioButton1.Checked)
			{
				MySqlCommand command = new MySqlCommand($"UPDATE PEDIDO SET formaPagamento='{radioButton1.Text}' where numeroPedido={Capa.Pedido_data1}", mConn);//debito

				command.ExecuteNonQuery();
			}
			if (radioButton2.Checked)
			{
				MySqlCommand command = new MySqlCommand($"UPDATE PEDIDO SET formaPagamento='{radioButton2.Text}' where numeroPedido={Capa.Pedido_data1}", mConn);//credito
				command.ExecuteNonQuery();
			}
			if (radioButton3.Checked)
			{
				MySqlCommand command = new MySqlCommand($"UPDATE PEDIDO SET formaPagamento='{radioButton3.Text}', troco={txtTroco.Text} where numeroPedido={Capa.Pedido_data1}", mConn);//dinheiro
				command.ExecuteNonQuery();
			}
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
		private void label16_Click(object sender, EventArgs e)
		{ }
		private void label14_Click(object sender, EventArgs e)
		{ }
		private void groupBox1_Enter(object sender, EventArgs e)
		{ }
		private void groupBox2_Enter(object sender, EventArgs e)
		{ }
	}
}
