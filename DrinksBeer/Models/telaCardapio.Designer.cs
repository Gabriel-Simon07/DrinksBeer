namespace DrinksBeer.Models
{
    partial class telaCardapio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbmNao_alcoolicos = new System.Windows.Forms.ComboBox();
            this.cmbAlcoolicos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar_cardapio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFinalizar_cardapio = new System.Windows.Forms.Button();
            this.btnAtualiza_lista = new System.Windows.Forms.Button();
            this.btnAlterar_pedido = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.cbmNao_alcoolicos);
            this.groupBox1.Controls.Add(this.cmbAlcoolicos);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "QTD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 6;
            // 
            // cbmNao_alcoolicos
            // 
            this.cbmNao_alcoolicos.FormattingEnabled = true;
            this.cbmNao_alcoolicos.Location = new System.Drawing.Point(127, 169);
            this.cbmNao_alcoolicos.Name = "cbmNao_alcoolicos";
            this.cbmNao_alcoolicos.Size = new System.Drawing.Size(130, 21);
            this.cbmNao_alcoolicos.TabIndex = 5;
            this.cbmNao_alcoolicos.Text = "Selecione um produto";
            // 
            // cmbAlcoolicos
            // 
            this.cmbAlcoolicos.FormattingEnabled = true;
            this.cmbAlcoolicos.Location = new System.Drawing.Point(127, 61);
            this.cmbAlcoolicos.Name = "cmbAlcoolicos";
            this.cmbAlcoolicos.Size = new System.Drawing.Size(130, 21);
            this.cmbAlcoolicos.TabIndex = 4;
            this.cmbAlcoolicos.Text = "Selecione um produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "QTD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cardápio";
            // 
            // btnCancelar_cardapio
            // 
            this.btnCancelar_cardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar_cardapio.Location = new System.Drawing.Point(82, 384);
            this.btnCancelar_cardapio.Name = "btnCancelar_cardapio";
            this.btnCancelar_cardapio.Size = new System.Drawing.Size(132, 54);
            this.btnCancelar_cardapio.TabIndex = 9;
            this.btnCancelar_cardapio.Text = "Cancelar";
            this.btnCancelar_cardapio.UseVisualStyleBackColor = true;
            this.btnCancelar_cardapio.Click += new System.EventHandler(this.btnCancelar_pedido_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 240);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnFinalizar_cardapio
            // 
            this.btnFinalizar_cardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar_cardapio.Location = new System.Drawing.Point(597, 384);
            this.btnFinalizar_cardapio.Name = "btnFinalizar_cardapio";
            this.btnFinalizar_cardapio.Size = new System.Drawing.Size(132, 54);
            this.btnFinalizar_cardapio.TabIndex = 11;
            this.btnFinalizar_cardapio.Text = "Próximo";
            this.btnFinalizar_cardapio.UseVisualStyleBackColor = true;
            this.btnFinalizar_cardapio.Click += new System.EventHandler(this.btnFinalizar_cardapio_Click);
            // 
            // btnAtualiza_lista
            // 
            this.btnAtualiza_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualiza_lista.Location = new System.Drawing.Point(333, 384);
            this.btnAtualiza_lista.Name = "btnAtualiza_lista";
            this.btnAtualiza_lista.Size = new System.Drawing.Size(169, 54);
            this.btnAtualiza_lista.TabIndex = 12;
            this.btnAtualiza_lista.Text = "Colocar no Carinho";
            this.btnAtualiza_lista.UseVisualStyleBackColor = true;
            // 
            // btnAlterar_pedido
            // 
            this.btnAlterar_pedido.Location = new System.Drawing.Point(191, 83);
            this.btnAlterar_pedido.Name = "btnAlterar_pedido";
            this.btnAlterar_pedido.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar_pedido.TabIndex = 13;
            this.btnAlterar_pedido.Text = "Alterar";
            this.btnAlterar_pedido.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alterar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DrinksBeer.Properties.Resources.refrigerante;
            this.pictureBox2.Location = new System.Drawing.Point(38, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrinksBeer.Properties.Resources.beer;
            this.pictureBox1.Location = new System.Drawing.Point(37, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(531, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Taxa de entrega : R$ 9,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(481, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Entrega grátis para pedidos acima de R$ 100,00";
            // 
            // telaCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterar_pedido);
            this.Controls.Add(this.btnAtualiza_lista);
            this.Controls.Add(this.btnFinalizar_cardapio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar_cardapio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "telaCardapio";
            this.Text = "telaCardapio";
            this.Load += new System.EventHandler(this.telaCardapio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbmNao_alcoolicos;
        private System.Windows.Forms.ComboBox cmbAlcoolicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar_cardapio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFinalizar_cardapio;
        private System.Windows.Forms.Button btnAtualiza_lista;
        private System.Windows.Forms.Button btnAlterar_pedido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}