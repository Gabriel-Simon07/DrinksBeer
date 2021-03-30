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

namespace DrinksBeer.Models
{
    public partial class telaCardapio : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public telaCardapio()
        {
            InitializeComponent();
            mostraRegistros();
        }

        private void mostraRegistros()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("server=localhost;user id=root;sslmode=None;database=sadrinksbeer");
            mConn.Open();
            mAdapter = new MySqlDataAdapter("SELECT * FROM bebidas ORDER BY id", mConn);
            mAdapter.Fill(mDataSet, "bebidas");
            cmbAlcoolicos.DataSource = mDataSet;
            cmbAlcoolicos.DataMember = "bebidas";            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_pedido_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFinalizar_cardapio_Click(object sender, EventArgs e)
        {
            Visible = false;
            new telaPagamento().Show();
        }

        private void telaCardapio_Load(object sender, EventArgs e)
        {

        }
    }
}
