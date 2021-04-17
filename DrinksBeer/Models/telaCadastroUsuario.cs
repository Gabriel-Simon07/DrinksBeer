﻿using System;
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
		string Pedido_data1 = "";
		public telaCadastroUsuario()
		{
			InitializeComponent();
			dataMostra();
		}
		private void dataMostra()
		{
			DateTime pedido_data1 = DateTime.Now;
			Pedido_data1 = pedido_data1.Year.ToString() + pedido_data1.Month.ToString() + pedido_data1.Day.ToString()
				+ pedido_data1.Hour.ToString() + pedido_data1.Minute.ToString() + pedido_data1.Second.ToString() +
				pedido_data1.Millisecond.ToString();
		}
		private void label2_Click(object sender, EventArgs e)
		{ }
		private void btnCancelar_cadastro_Click(object sender, EventArgs e)
		{
			Visible = false;
			new telaCardapio().Show();
		}
		private void telaCadastroUsuario_Load(object sender, EventArgs e)
		{ label16.Text = telaCardapio.Pedido_data1; }
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();
			if (rbEnvio_casa.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(nomeCompleto," +
				" telefone, nomeRua, dataNascimento, cidade, cep, numeroCasa, bairro, formaRetirada, numeroPedido, cpf)" + "VALUES('" + txtNome.Text + "','"
				+ txtTelefone.Text + "','" + txtRua.Text + "','" + dtpNascimento.Text + "','" + txtCidade.Text + "','"
				+ txtCep.Text + "','" + txtNum_casa.Text + "','" + txtBairro.Text + "','" + rbEnvio_casa.Text + "'," + telaCardapio.Pedido_data1 + ",'" + txtCpf.Text + "')", mConn);
				command.ExecuteNonQuery();
			}
			if (rbRetirada_local.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(nomeCompleto," +
				" telefone, nomeRua, dataNascimento, cidade, cep, numeroCasa, bairro, formaRetirada, numeroPedido, cpf)" + "VALUES('" + txtNome.Text + "','"
				+ txtTelefone.Text + "','" + txtRua.Text + "','" + dtpNascimento.Text + "','" + txtCidade.Text + "','"
				+ txtCep.Text + "','" + txtNum_casa.Text + "','" + txtBairro.Text + "','" + rbRetirada_local.Text + "'," + telaCardapio.Pedido_data1 + ",'" + txtCpf.Text + "')", mConn);
				command.ExecuteNonQuery();
			}
			if (radioButton1.Checked)
			{
				MySqlCommand command = new MySqlCommand($"UPDATE PEDIDO SET formaPagamento='{radioButton1.Text}' where numeroPedido={telaCardapio.Pedido_data1}", mConn);//debito

				command.ExecuteNonQuery();
			}
			if (radioButton2.Checked)
			{
				MySqlCommand command = new MySqlCommand($"UPDATE PEDIDO SET formaPagamento='{radioButton2.Text}' where numeroPedido={telaCardapio.Pedido_data1}", mConn);//credito
				command.ExecuteNonQuery();
			}
			if (radioButton3.Checked)
			{
				MySqlCommand command = new MySqlCommand($"UPDATE PEDIDO SET formaPagamento='{radioButton3.Text}', troco={txtTroco.Text} where numeroPedido={telaCardapio.Pedido_data1}", mConn);//dinheiro
				command.ExecuteNonQuery();
			}
			Visible = false;
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");
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
