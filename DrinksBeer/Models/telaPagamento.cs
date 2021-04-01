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
    public partial class telaPagamento : Form
    {
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
    }
}
