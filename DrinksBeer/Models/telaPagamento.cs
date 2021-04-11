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

        private void telaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_pedido_Click(object sender, EventArgs e)
        {
			mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");

			mConn.Open();
			if (rbEnvio_casa.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(formaRetirada)"
				+ "VALUES('" + rbEnvio_casa.Text + "')", mConn);
				command.ExecuteNonQuery();
			}
			if (rbRetirada_local.Checked)
			{
				MySqlCommand command = new MySqlCommand("INSERT INTO PEDIDO(formaRetirada)"
				+ "VALUES('" + rbRetirada_local.Text + "')", mConn);
				command.ExecuteNonQuery();
			}			

		
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
