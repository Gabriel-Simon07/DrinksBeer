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
			this.label1 = new System.Windows.Forms.Label();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tblPedidos = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPedidos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(26, 222);
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
			this.pictureBox1.Location = new System.Drawing.Point(189, 70);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 119);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tblPedidos
			// 
			this.tblPedidos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tblPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblPedidos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tblPedidos.Location = new System.Drawing.Point(547, 97);
			this.tblPedidos.Name = "tblPedidos";
			this.tblPedidos.Size = new System.Drawing.Size(179, 324);
			this.tblPedidos.TabIndex = 4;
			this.tblPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(531, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(238, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "Pedidos do dia ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Capa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridView tblPedidos;
        private System.Windows.Forms.Label label2;
	}
}