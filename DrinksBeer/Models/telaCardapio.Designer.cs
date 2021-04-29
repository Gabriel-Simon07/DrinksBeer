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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAlcoolicos = new System.Windows.Forms.TextBox();
			this.cbmNao_alcoolicos = new System.Windows.Forms.ComboBox();
			this.cmbAlcoolicos = new System.Windows.Forms.ComboBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnAtualiza_lista = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNao_alcoolicos = new System.Windows.Forms.TextBox();
			this.bebidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sadrinksbeerDataSet = new DrinksBeer.sadrinksbeerDataSet();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancelar_cardapio = new System.Windows.Forms.Button();
			this.tblCarinho = new System.Windows.Forms.DataGridView();
			this.id_itempedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.qtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itempedidoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.sadrinksbeerDataSet6 = new DrinksBeer.sadrinksbeerDataSet6();
			this.itempedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.sadrinksbeerDataSet3 = new DrinksBeer.sadrinksbeerDataSet3();
			this.itempedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sadrinksbeerDataSet2 = new DrinksBeer.sadrinksbeerDataSet2();
			this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sadrinksbeerDataSet1 = new DrinksBeer.sadrinksbeerDataSet1();
			this.btnFinalizar_cardapio = new System.Windows.Forms.Button();
			this.bebidasTableAdapter = new DrinksBeer.sadrinksbeerDataSetTableAdapters.bebidasTableAdapter();
			this.label4 = new System.Windows.Forms.Label();
			this.pedidoTableAdapter = new DrinksBeer.sadrinksbeerDataSet1TableAdapters.pedidoTableAdapter();
			this.itempedidoTableAdapter = new DrinksBeer.sadrinksbeerDataSet2TableAdapters.itempedidoTableAdapter();
			this.itempedidoTableAdapter1 = new DrinksBeer.sadrinksbeerDataSet3TableAdapters.itempedidoTableAdapter();
			this.valorFinal = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.itempedidoTableAdapter2 = new DrinksBeer.sadrinksbeerDataSet6TableAdapters.itempedidoTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bebidasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblCarinho)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtAlcoolicos);
			this.groupBox1.Controls.Add(this.cbmNao_alcoolicos);
			this.groupBox1.Controls.Add(this.cmbAlcoolicos);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.btnAtualiza_lista);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNao_alcoolicos);
			this.groupBox1.Location = new System.Drawing.Point(12, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(355, 224);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Green;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(183, 175);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 39);
			this.button3.TabIndex = 14;
			this.button3.Text = "+";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(308, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "QTD";
			// 
			// txtAlcoolicos
			// 
			this.txtAlcoolicos.Location = new System.Drawing.Point(308, 44);
			this.txtAlcoolicos.MaxLength = 2;
			this.txtAlcoolicos.Name = "txtAlcoolicos";
			this.txtAlcoolicos.Size = new System.Drawing.Size(41, 20);
			this.txtAlcoolicos.TabIndex = 6;
			this.txtAlcoolicos.TextChanged += new System.EventHandler(this.txtAlcoolicos_TextChanged);
			// 
			// cbmNao_alcoolicos
			// 
			this.cbmNao_alcoolicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbmNao_alcoolicos.FormattingEnabled = true;
			this.cbmNao_alcoolicos.Location = new System.Drawing.Point(93, 148);
			this.cbmNao_alcoolicos.Name = "cbmNao_alcoolicos";
			this.cbmNao_alcoolicos.Size = new System.Drawing.Size(194, 21);
			this.cbmNao_alcoolicos.TabIndex = 5;
			this.cbmNao_alcoolicos.SelectedIndexChanged += new System.EventHandler(this.cbmNao_alcoolicos_SelectedIndexChanged);
			// 
			// cmbAlcoolicos
			// 
			this.cmbAlcoolicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAlcoolicos.FormattingEnabled = true;
			this.cmbAlcoolicos.Location = new System.Drawing.Point(94, 44);
			this.cmbAlcoolicos.Name = "cmbAlcoolicos";
			this.cmbAlcoolicos.Size = new System.Drawing.Size(194, 21);
			this.cmbAlcoolicos.TabIndex = 4;
			this.cmbAlcoolicos.SelectedIndexChanged += new System.EventHandler(this.cmbAlcoolicos_SelectedIndexChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::DrinksBeer.Properties.Resources.refrigerante;
			this.pictureBox2.Location = new System.Drawing.Point(16, 110);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(71, 85);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// btnAtualiza_lista
			// 
			this.btnAtualiza_lista.BackColor = System.Drawing.Color.Green;
			this.btnAtualiza_lista.CausesValidation = false;
			this.btnAtualiza_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAtualiza_lista.Location = new System.Drawing.Point(184, 71);
			this.btnAtualiza_lista.Name = "btnAtualiza_lista";
			this.btnAtualiza_lista.Size = new System.Drawing.Size(40, 38);
			this.btnAtualiza_lista.TabIndex = 12;
			this.btnAtualiza_lista.Text = "+";
			this.btnAtualiza_lista.UseVisualStyleBackColor = false;
			this.btnAtualiza_lista.Click += new System.EventHandler(this.btnAtualiza_lista_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DrinksBeer.Properties.Resources.beer;
			this.pictureBox1.Location = new System.Drawing.Point(16, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(314, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "QTD";
			// 
			// txtNao_alcoolicos
			// 
			this.txtNao_alcoolicos.Location = new System.Drawing.Point(302, 148);
			this.txtNao_alcoolicos.MaxLength = 2;
			this.txtNao_alcoolicos.Name = "txtNao_alcoolicos";
			this.txtNao_alcoolicos.Size = new System.Drawing.Size(41, 20);
			this.txtNao_alcoolicos.TabIndex = 0;
			this.txtNao_alcoolicos.TextChanged += new System.EventHandler(this.txtNao_alcoolicos_TextChanged);
			// 
			// bebidasBindingSource
			// 
			this.bebidasBindingSource.DataMember = "bebidas";
			this.bebidasBindingSource.DataSource = this.sadrinksbeerDataSet;
			// 
			// sadrinksbeerDataSet
			// 
			this.sadrinksbeerDataSet.DataSetName = "sadrinksbeerDataSet";
			this.sadrinksbeerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// tblCarinho
			// 
			this.tblCarinho.AutoGenerateColumns = false;
			this.tblCarinho.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tblCarinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblCarinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_itempedido,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.valorProdutoDataGridViewTextBoxColumn,
            this.qtdDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn});
			this.tblCarinho.DataSource = this.itempedidoBindingSource2;
			this.tblCarinho.Location = new System.Drawing.Point(380, 91);
			this.tblCarinho.MultiSelect = false;
			this.tblCarinho.Name = "tblCarinho";
			this.tblCarinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.tblCarinho.Size = new System.Drawing.Size(408, 196);
			this.tblCarinho.TabIndex = 10;
			this.tblCarinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// id_itempedido
			// 
			this.id_itempedido.DataPropertyName = "id_itempedido";
			this.id_itempedido.HeaderText = "ID";
			this.id_itempedido.Name = "id_itempedido";
			this.id_itempedido.Visible = false;
			// 
			// nomeProdutoDataGridViewTextBoxColumn
			// 
			this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NOME DO PRODUTO";
			this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
			// 
			// valorProdutoDataGridViewTextBoxColumn
			// 
			this.valorProdutoDataGridViewTextBoxColumn.DataPropertyName = "valorProduto";
			this.valorProdutoDataGridViewTextBoxColumn.HeaderText = "VALOR DO PRODUTO";
			this.valorProdutoDataGridViewTextBoxColumn.Name = "valorProdutoDataGridViewTextBoxColumn";
			// 
			// qtdDataGridViewTextBoxColumn
			// 
			this.qtdDataGridViewTextBoxColumn.DataPropertyName = "qtd";
			this.qtdDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
			this.qtdDataGridViewTextBoxColumn.Name = "qtdDataGridViewTextBoxColumn";
			this.qtdDataGridViewTextBoxColumn.Width = 85;
			// 
			// subtotalDataGridViewTextBoxColumn
			// 
			this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal";
			this.subtotalDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL";
			this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
			this.subtotalDataGridViewTextBoxColumn.Width = 80;
			// 
			// itempedidoBindingSource2
			// 
			this.itempedidoBindingSource2.DataMember = "itempedido";
			this.itempedidoBindingSource2.DataSource = this.sadrinksbeerDataSet6;
			// 
			// sadrinksbeerDataSet6
			// 
			this.sadrinksbeerDataSet6.DataSetName = "sadrinksbeerDataSet6";
			this.sadrinksbeerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// itempedidoBindingSource1
			// 
			this.itempedidoBindingSource1.DataMember = "itempedido";
			this.itempedidoBindingSource1.DataSource = this.sadrinksbeerDataSet3;
			// 
			// sadrinksbeerDataSet3
			// 
			this.sadrinksbeerDataSet3.DataSetName = "sadrinksbeerDataSet3";
			this.sadrinksbeerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// itempedidoBindingSource
			// 
			this.itempedidoBindingSource.DataMember = "itempedido";
			this.itempedidoBindingSource.DataSource = this.sadrinksbeerDataSet2;
			// 
			// sadrinksbeerDataSet2
			// 
			this.sadrinksbeerDataSet2.DataSetName = "sadrinksbeerDataSet2";
			this.sadrinksbeerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pedidoBindingSource
			// 
			this.pedidoBindingSource.DataMember = "pedido";
			this.pedidoBindingSource.DataSource = this.sadrinksbeerDataSet1;
			// 
			// sadrinksbeerDataSet1
			// 
			this.sadrinksbeerDataSet1.DataSetName = "sadrinksbeerDataSet1";
			this.sadrinksbeerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// bebidasTableAdapter
			// 
			this.bebidasTableAdapter.ClearBeforeFill = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(533, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 29);
			this.label4.TabIndex = 14;
			this.label4.Text = "Carrinho";
			this.label4.Click += new System.EventHandler(this.label4_Click_1);
			// 
			// pedidoTableAdapter
			// 
			this.pedidoTableAdapter.ClearBeforeFill = true;
			// 
			// itempedidoTableAdapter
			// 
			this.itempedidoTableAdapter.ClearBeforeFill = true;
			// 
			// itempedidoTableAdapter1
			// 
			this.itempedidoTableAdapter1.ClearBeforeFill = true;
			// 
			// valorFinal
			// 
			this.valorFinal.AutoSize = true;
			this.valorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.valorFinal.Location = new System.Drawing.Point(566, 312);
			this.valorFinal.Name = "valorFinal";
			this.valorFinal.Size = new System.Drawing.Size(133, 33);
			this.valorFinal.TabIndex = 16;
			this.valorFinal.Text = "Total R$:";
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotal.Location = new System.Drawing.Point(695, 312);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(55, 33);
			this.labelTotal.TabIndex = 17;
			this.labelTotal.Text = "0,0";
			this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(333, 384);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(132, 54);
			this.button4.TabIndex = 18;
			this.button4.Text = "Retirar Item";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// itempedidoTableAdapter2
			// 
			this.itempedidoTableAdapter2.ClearBeforeFill = true;
			// 
			// telaCardapio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.valorFinal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnFinalizar_cardapio);
			this.Controls.Add(this.tblCarinho);
			this.Controls.Add(this.btnCancelar_cardapio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Name = "telaCardapio";
			this.Text = "telaCardapio";
			this.Load += new System.EventHandler(this.telaCardapio_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bebidasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblCarinho)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmNao_alcoolicos;
        private System.Windows.Forms.ComboBox cmbAlcoolicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar_cardapio;
        private System.Windows.Forms.DataGridView tblCarinho;
        private System.Windows.Forms.Button btnFinalizar_cardapio;
        private System.Windows.Forms.Button btnAtualiza_lista;
        private System.Windows.Forms.TextBox txtAlcoolicos;
        private System.Windows.Forms.TextBox txtNao_alcoolicos;
        private sadrinksbeerDataSet sadrinksbeerDataSet;
        private System.Windows.Forms.BindingSource bebidasBindingSource;
        private sadrinksbeerDataSetTableAdapters.bebidasTableAdapter bebidasTableAdapter;
        private System.Windows.Forms.Label label4;
        private sadrinksbeerDataSet1 sadrinksbeerDataSet1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private sadrinksbeerDataSet1TableAdapters.pedidoTableAdapter pedidoTableAdapter;
		private sadrinksbeerDataSet2 sadrinksbeerDataSet2;
		private System.Windows.Forms.BindingSource itempedidoBindingSource;
		private sadrinksbeerDataSet2TableAdapters.itempedidoTableAdapter itempedidoTableAdapter;
		private System.Windows.Forms.Button button3;
		private sadrinksbeerDataSet3 sadrinksbeerDataSet3;
		private System.Windows.Forms.BindingSource itempedidoBindingSource1;
		private sadrinksbeerDataSet3TableAdapters.itempedidoTableAdapter itempedidoTableAdapter1;
		private System.Windows.Forms.Label valorFinal;
		private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button button4;
		private sadrinksbeerDataSet6 sadrinksbeerDataSet6;
		private System.Windows.Forms.BindingSource itempedidoBindingSource2;
		private sadrinksbeerDataSet6TableAdapters.itempedidoTableAdapter itempedidoTableAdapter2;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_itempedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorProdutoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn qtdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
	}
}