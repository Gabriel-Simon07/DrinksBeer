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
    public partial class telaPagamento : Form
    {
		private MySqlConnection mConn;
		private MySqlDataAdapter mAdapter;
		private DataSet mDataSet;
		string Pedido_data1 = "";
		public telaPagamento()
        {
            InitializeComponent();
        }

        private void btnCancelar_pedido_Click(object sender, EventArgs e)
        {
            Visible = false;
            new telaCardapio().Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
		//private void mostraCarrinho()
		//{
		//	mDataSet = new DataSet();

		//	mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

		//	mConn.Open();

		//	mAdapter = new MySqlDataAdapter($"SELECT nomeProduto, valorProduto, subtotal,qtd FROM ITEMPEDIDO where pedido ='{Pedido_data1}'", mConn);

		//	mAdapter.Fill(mDataSet, "ITEMPEDIDO");

		//	tblSubtotal.DataSource = mDataSet;

		//	tblSubtotal.DataMember = "ITEMPEDIDO";
		//}
		private void telaPagamento_Load(object sender, EventArgs e)
        {
			//mostraCarrinho();

			DateTime pedido_data1 = DateTime.Now;
			Pedido_data1 = pedido_data1.Year.ToString() + pedido_data1.Month.ToString() + pedido_data1.Day.ToString()
				+ pedido_data1.Hour.ToString() + pedido_data1.Minute.ToString() + pedido_data1.Second.ToString() +
				pedido_data1.Millisecond.ToString();

		}

        private void btnFinalizar_pedido_Click(object sender, EventArgs e)
        {
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();
			if (rbEnvio_casa.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(formaRetirada, numeroPedido)"
				+ "VALUES('" + rbEnvio_casa.Text + "','" + Pedido_data1 + "')", mConn);
				command.ExecuteNonQuery();
			}
			if (rbRetirada_local.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(formaRetirada)"
				+ "VALUES('" + rbRetirada_local.Text + "')", mConn);
				command.ExecuteNonQuery();
			}
			//if (radioButton1.Checked)
			//{
			//	MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(formaPagamento)"
			//	+ "VALUES('" + radioButton1.Text + "')", mConn);//debito
			//	command.ExecuteNonQuery();
			//}
			//if (radioButton2.Checked)
			//{
			//	MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(formaPagamento)"
			//	+ "VALUES('" + radioButton2.Text + "')", mConn);//credito
			//	command.ExecuteNonQuery();
			//}
			//if (radioButton3.Checked)
			//{
			//	MySqlCommand command = new MySqlCommand($"INSERT INTO PEDIDO(formaPagamento, troco)where numeroPedido={Pedido_data1}"
			//	+ "VALUES('" + radioButton3.Text + "','" + txtTroco.Text + "')", mConn);//dinheiro
			//	command.ExecuteNonQuery();
			//}

			mConn.Close();

			Visible = false;
            new telaCadastroUsuario().Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rbEnvio_casa_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
