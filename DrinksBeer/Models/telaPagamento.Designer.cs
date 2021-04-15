namespace DrinksBeer.Models
{
    partial class telaPagamento
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
			this.tblSubtotal = new System.Windows.Forms.DataGridView();
			this.btnFinalizar_pedido = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rbRetirada_local = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.rbEnvio_casa = new System.Windows.Forms.RadioButton();
			this.btnCancelar_pedido = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTroco = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tblSubtotal)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tblSubtotal
			// 
			this.tblSubtotal.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tblSubtotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblSubtotal.Location = new System.Drawing.Point(85, 128);
			this.tblSubtotal.Name = "tblSubtotal";
			this.tblSubtotal.Size = new System.Drawing.Size(188, 222);
			this.tblSubtotal.TabIndex = 0;
			// 
			// btnFinalizar_pedido
			// 
			this.btnFinalizar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinalizar_pedido.Location = new System.Drawing.Point(537, 373);
			this.btnFinalizar_pedido.Name = "btnFinalizar_pedido";
			this.btnFinalizar_pedido.Size = new System.Drawing.Size(163, 65);
			this.btnFinalizar_pedido.TabIndex = 1;
			this.btnFinalizar_pedido.Text = "Próximo";
			this.btnFinalizar_pedido.UseVisualStyleBackColor = true;
			this.btnFinalizar_pedido.Click += new System.EventHandler(this.btnFinalizar_pedido_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(221, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(344, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "Pagamento e Envio";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.rbRetirada_local);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rbEnvio_casa);
			this.groupBox1.Location = new System.Drawing.Point(412, 78);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 142);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(21, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(235, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Entrega grátis para pedidos acima de R$ 100,00";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(71, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Taxa de entrega : R$ 9,00";
			// 
			// rbRetirada_local
			// 
			this.rbRetirada_local.AutoSize = true;
			this.rbRetirada_local.Location = new System.Drawing.Point(149, 55);
			this.rbRetirada_local.Name = "rbRetirada_local";
			this.rbRetirada_local.Size = new System.Drawing.Size(105, 17);
			this.rbRetirada_local.TabIndex = 10;
			this.rbRetirada_local.TabStop = true;
			this.rbRetirada_local.Text = "Retirada no local";
			this.rbRetirada_local.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Formas de retirada";
			// 
			// rbEnvio_casa
			// 
			this.rbEnvio_casa.AutoSize = true;
			this.rbEnvio_casa.Location = new System.Drawing.Point(24, 55);
			this.rbEnvio_casa.Name = "rbEnvio_casa";
			this.rbEnvio_casa.Size = new System.Drawing.Size(105, 17);
			this.rbEnvio_casa.TabIndex = 8;
			this.rbEnvio_casa.TabStop = true;
			this.rbEnvio_casa.Text = "Entrega em casa";
			this.rbEnvio_casa.UseVisualStyleBackColor = true;
			this.rbEnvio_casa.CheckedChanged += new System.EventHandler(this.rbEnvio_casa_CheckedChanged);
			// 
			// btnCancelar_pedido
			// 
			this.btnCancelar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar_pedido.Location = new System.Drawing.Point(115, 373);
			this.btnCancelar_pedido.Name = "btnCancelar_pedido";
			this.btnCancelar_pedido.Size = new System.Drawing.Size(144, 65);
			this.btnCancelar_pedido.TabIndex = 4;
			this.btnCancelar_pedido.Text = "Voltar";
			this.btnCancelar_pedido.UseVisualStyleBackColor = true;
			this.btnCancelar_pedido.Click += new System.EventHandler(this.btnCancelar_pedido_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtTroco);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(395, 241);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(318, 126);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// txtTroco
			// 
			this.txtTroco.Location = new System.Drawing.Point(237, 63);
			this.txtTroco.Name = "txtTroco";
			this.txtTroco.Size = new System.Drawing.Size(58, 20);
			this.txtTroco.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(20, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 16);
			this.label8.TabIndex = 15;
			this.label8.Text = "Aceitamos : ";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(19, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 16);
			this.label11.TabIndex = 18;
			this.label11.Text = "Master Card";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(130, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 16);
			this.label7.TabIndex = 14;
			this.label7.Text = "Troco para R$ :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(36, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 16);
			this.label10.TabIndex = 17;
			this.label10.Text = "Amex";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(156, 45);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(64, 17);
			this.radioButton3.TabIndex = 13;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Dinheiro";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(38, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Visa";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(68, 45);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(58, 17);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Crédito";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 45);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(56, 17);
			this.radioButton1.TabIndex = 11;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Débito";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(64, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(201, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Formas de pagamento";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(139, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Subtotal";
			// 
			// telaPagamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnCancelar_pedido);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFinalizar_pedido);
			this.Controls.Add(this.tblSubtotal);
			this.Name = "telaPagamento";
			this.Text = "telaPagamento";
			this.Load += new System.EventHandler(this.telaPagamento_Load);
			((System.ComponentModel.ISupportInitialize)(this.tblSubtotal)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblSubtotal;
        private System.Windows.Forms.Button btnFinalizar_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar_pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbRetirada_local;
        private System.Windows.Forms.RadioButton rbEnvio_casa;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}