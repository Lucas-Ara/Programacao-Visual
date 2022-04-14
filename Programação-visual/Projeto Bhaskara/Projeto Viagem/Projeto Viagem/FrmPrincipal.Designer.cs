namespace Projeto_Viagem
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.lbPedagio = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtcombustivel = new System.Windows.Forms.TextBox();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.ckGastoPedagio = new System.Windows.Forms.CheckBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.Location = new System.Drawing.Point(12, 31);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(155, 20);
            this.lbDistancia.TabIndex = 0;
            this.lbDistancia.Text = "Distancia a pecorrer:";
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.Location = new System.Drawing.Point(12, 74);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(202, 20);
            this.lbConsumo.TabIndex = 1;
            this.lbConsumo.Text = "Consumo médio do veiculo:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombustivel.Location = new System.Drawing.Point(12, 120);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(184, 20);
            this.lbCombustivel.TabIndex = 2;
            this.lbCombustivel.Text = "Valor do combustivel: R$";
            // 
            // lbPedagio
            // 
            this.lbPedagio.AutoSize = true;
            this.lbPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedagio.Location = new System.Drawing.Point(12, 193);
            this.lbPedagio.Name = "lbPedagio";
            this.lbPedagio.Size = new System.Drawing.Size(104, 20);
            this.lbPedagio.TabIndex = 3;
            this.lbPedagio.Text = "Pedagios: R$";
            this.lbPedagio.Visible = false;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(292, 28);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(48, 26);
            this.txtDistancia.TabIndex = 4;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(292, 74);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(48, 26);
            this.txtConsumo.TabIndex = 5;
            // 
            // txtcombustivel
            // 
            this.txtcombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcombustivel.Location = new System.Drawing.Point(292, 114);
            this.txtcombustivel.Name = "txtcombustivel";
            this.txtcombustivel.Size = new System.Drawing.Size(48, 26);
            this.txtcombustivel.TabIndex = 6;
            // 
            // txtPedagio
            // 
            this.txtPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedagio.Location = new System.Drawing.Point(292, 190);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(48, 26);
            this.txtPedagio.TabIndex = 7;
            this.txtPedagio.Visible = false;
            // 
            // ckGastoPedagio
            // 
            this.ckGastoPedagio.AutoSize = true;
            this.ckGastoPedagio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckGastoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGastoPedagio.Location = new System.Drawing.Point(12, 154);
            this.ckGastoPedagio.Name = "ckGastoPedagio";
            this.ckGastoPedagio.Size = new System.Drawing.Size(221, 24);
            this.ckGastoPedagio.TabIndex = 8;
            this.ckGastoPedagio.Text = "Houve gastos com pedágio";
            this.ckGastoPedagio.UseVisualStyleBackColor = true;
            this.ckGastoPedagio.CheckedChanged += new System.EventHandler(this.ckGastoPedagio_CheckedChanged);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Red;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(98, 236);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(172, 54);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular Gastos";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "km/L";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "R$";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 316);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.ckGastoPedagio);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.txtcombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lbPedagio);
            this.Controls.Add(this.lbCombustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.Name = "FrmPrincipal";
            this.Text = "Gasto da viagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.Label lbPedagio;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtcombustivel;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.CheckBox ckGastoPedagio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

