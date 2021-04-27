namespace DrinksBeer.Models
{
    partial class Capa
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tblPedidos = new System.Windows.Forms.DataGridView();
			this.itempedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sadrinksbeerDataSet5 = new DrinksBeer.sadrinksbeerDataSet5();
			this.label2 = new System.Windows.Forms.Label();
			this.itempedidoTableAdapter = new DrinksBeer.sadrinksbeerDataSet5TableAdapters.itempedidoTableAdapter();
			this.btnBkpPedido = new System.Windows.Forms.Button();
			this.btnBkpItempedido = new System.Windows.Forms.Button();
			this.sadrinksbeerDataSet7 = new DrinksBeer.sadrinksbeerDataSet7();
			this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pedidoTableAdapter = new DrinksBeer.sadrinksbeerDataSet7TableAdapters.pedidoTableAdapter();
			this.numeroPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(26, 249);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(442, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tá com sede ? Pede um gole!";
			// 
			// btnIniciar
			// 
			this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnIniciar.Location = new System.Drawing.Point(189, 356);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(128, 65);
			this.btnIniciar.TabIndex = 3;
			this.btnIniciar.Text = "Iniciar pedido";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DrinksBeer.Properties.Resources.LogoGole_drinks_1_;
			this.pictureBox1.Location = new System.Drawing.Point(189, 97);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 125);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tblPedidos
			// 
			this.tblPedidos.AutoGenerateColumns = false;
			this.tblPedidos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tblPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroPedidoDataGridViewTextBoxColumn});
			this.tblPedidos.DataSource = this.pedidoBindingSource;
			this.tblPedidos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tblPedidos.Location = new System.Drawing.Point(531, 97);
			this.tblPedidos.Name = "tblPedidos";
			this.tblPedidos.Size = new System.Drawing.Size(237, 324);
			this.tblPedidos.TabIndex = 4;
			this.tblPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// itempedidoBindingSource
			// 
			this.itempedidoBindingSource.DataMember = "itempedido";
			this.itempedidoBindingSource.DataSource = this.sadrinksbeerDataSet5;
			// 
			// sadrinksbeerDataSet5
			// 
			this.sadrinksbeerDataSet5.DataSetName = "sadrinksbeerDataSet5";
			this.sadrinksbeerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(534, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(238, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "Pedidos do dia ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// itempedidoTableAdapter
			// 
			this.itempedidoTableAdapter.ClearBeforeFill = true;
			// 
			// btnBkpPedido
			// 
			this.btnBkpPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnBkpPedido.Location = new System.Drawing.Point(275, 9);
			this.btnBkpPedido.Name = "btnBkpPedido";
			this.btnBkpPedido.Size = new System.Drawing.Size(104, 55);
			this.btnBkpPedido.TabIndex = 6;
			this.btnBkpPedido.Text = "Backup pedido";
			this.btnBkpPedido.UseVisualStyleBackColor = true;
			this.btnBkpPedido.Click += new System.EventHandler(this.btnBkpPedido_Click);
			// 
			// btnBkpItempedido
			// 
			this.btnBkpItempedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnBkpItempedido.Location = new System.Drawing.Point(138, 9);
			this.btnBkpItempedido.Name = "btnBkpItempedido";
			this.btnBkpItempedido.Size = new System.Drawing.Size(104, 55);
			this.btnBkpItempedido.TabIndex = 7;
			this.btnBkpItempedido.Text = "Backup itempedido";
			this.btnBkpItempedido.UseVisualStyleBackColor = true;
			this.btnBkpItempedido.Click += new System.EventHandler(this.btnBkpItempedido_Click);
			// 
			// sadrinksbeerDataSet7
			// 
			this.sadrinksbeerDataSet7.DataSetName = "sadrinksbeerDataSet7";
			this.sadrinksbeerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pedidoBindingSource
			// 
			this.pedidoBindingSource.DataMember = "pedido";
			this.pedidoBindingSource.DataSource = this.sadrinksbeerDataSet7;
			// 
			// pedidoTableAdapter
			// 
			this.pedidoTableAdapter.ClearBeforeFill = true;
			// 
			// numeroPedidoDataGridViewTextBoxColumn
			// 
			this.numeroPedidoDataGridViewTextBoxColumn.DataPropertyName = "numeroPedido";
			this.numeroPedidoDataGridViewTextBoxColumn.HeaderText = "NÚMERO DO PEDIDO";
			this.numeroPedidoDataGridViewTextBoxColumn.Name = "numeroPedidoDataGridViewTextBoxColumn";
			this.numeroPedidoDataGridViewTextBoxColumn.Width = 193;
			// 
			// Capa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBkpItempedido);
			this.Controls.Add(this.btnBkpPedido);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tblPedidos);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Capa";
			this.Text = "Capa";
			this.Load += new System.EventHandler(this.Capa_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itempedidoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sadrinksbeerDataSet7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridView tblPedidos;
        private System.Windows.Forms.Label label2;
		private sadrinksbeerDataSet5 sadrinksbeerDataSet5;
		private System.Windows.Forms.BindingSource itempedidoBindingSource;
		private sadrinksbeerDataSet5TableAdapters.itempedidoTableAdapter itempedidoTableAdapter;
		private System.Windows.Forms.Button btnBkpPedido;
		private System.Windows.Forms.Button btnBkpItempedido;
		private sadrinksbeerDataSet7 sadrinksbeerDataSet7;
		private System.Windows.Forms.BindingSource pedidoBindingSource;
		private sadrinksbeerDataSet7TableAdapters.pedidoTableAdapter pedidoTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroPedidoDataGridViewTextBoxColumn;
	}
}