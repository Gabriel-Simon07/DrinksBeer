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
    public partial class telaPagamento : Form
    {
        public telaPagamento()
        {
            InitializeComponent();
        }

        private void btnCancelar_pedido_Click(object sender, EventArgs e)
        {
            Visible = false;
            new Form1().Show();
        }
    }
}
