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
        {

        }

        private void btnCancelar_cadastro_Click(object sender, EventArgs e)
        {
            Visible = false;
            new telaPagamento().Show();
        }

        private void telaCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");
            mConn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO cadastro_cliente(nomeCompleto," +
                " telefone, nomeRua, idade, cidade, cep, numeroCasa)" + "VALUES('" + txtNome.Text + "'," +
                "'" + txtTelefone.Text + "','" + txtRua.Text + "','" + txtIdade.Text + "','" + txtCidade.Text + "'," +
                "'" + txtCep.Text + "','" + txtNum_casa.Text + "')", mConn);
            command.ExecuteNonQuery();
            mConn.Close();

            string Pedido_data = "";
            DateTime pedido_data = DateTime.Now;
            Pedido_data = pedido_data.Year.ToString() + pedido_data.Month.ToString() + pedido_data.Day.ToString()
                + pedido_data.Hour.ToString() + pedido_data.Minute.ToString() + pedido_data.Second.ToString() +
                pedido_data.Millisecond.ToString();

            MessageBox.Show($"Pedido {Pedido_data} feito com Sucesso!", "Informação", MessageBoxButtons.OK,
                MessageBoxIcon.Information);



            Visible = false;
            new Capa().Show();



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
