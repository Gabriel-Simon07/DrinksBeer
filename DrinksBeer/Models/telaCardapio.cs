using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinksBeer.Models
{
    public partial class telaCardapio : Form
    {
        public telaCardapio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_pedido_Click(object sender, EventArgs e)
        {
            Visible = false;
            new Form1().Show();
        }

        private void btnFinalizar_cardapio_Click(object sender, EventArgs e)
        {
            Visible = false;
            new telaPagamento().Show();
        }
    }
}
