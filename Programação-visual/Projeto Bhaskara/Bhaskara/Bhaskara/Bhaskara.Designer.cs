namespace Bhaskara
{
    partial class Bhaskara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bhaskara));
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lbx1 = new System.Windows.Forms.Label();
            this.lbx2 = new System.Windows.Forms.Label();
            this.lbzero = new System.Windows.Forms.Label();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbXP = new System.Windows.Forms.Label();
            this.lbXN = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbdescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(40, 51);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(30, 26);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(121, 51);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(32, 26);
            this.txtB.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(200, 51);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(36, 26);
            this.txtC.TabIndex = 2;
            // 
            // lbx1
            // 
            this.lbx1.AutoSize = true;
            this.lbx1.BackColor = System.Drawing.Color.White;
            this.lbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx1.Location = new System.Drawing.Point(76, 57);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(38, 20);
            this.lbx1.TabIndex = 3;
            this.lbx1.Text = "X² +";
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.BackColor = System.Drawing.Color.White;
            this.lbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx2.Location = new System.Drawing.Point(159, 57);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(29, 20);
            this.lbx2.TabIndex = 4;
            this.lbx2.Text = "X+";
            // 
            // lbzero
            // 
            this.lbzero.AutoSize = true;
            this.lbzero.BackColor = System.Drawing.Color.White;
            this.lbzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbzero.Location = new System.Drawing.Point(242, 57);
            this.lbzero.Name = "lbzero";
            this.lbzero.Size = new System.Drawing.Size(27, 20);
            this.lbzero.TabIndex = 5;
            this.lbzero.Text = "=0";
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.BackColor = System.Drawing.Color.White;
            this.lbDelta.Location = new System.Drawing.Point(12, 159);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(31, 13);
            this.lbDelta.TabIndex = 6;
            this.lbDelta.Text = "--------";
            // 
            // lbXP
            // 
            this.lbXP.AutoSize = true;
            this.lbXP.BackColor = System.Drawing.Color.White;
            this.lbXP.Location = new System.Drawing.Point(12, 204);
            this.lbXP.Name = "lbXP";
            this.lbXP.Size = new System.Drawing.Size(31, 13);
            this.lbXP.TabIndex = 7;
            this.lbXP.Text = "--------";
            // 
            // lbXN
            // 
            this.lbXN.AutoSize = true;
            this.lbXN.BackColor = System.Drawing.Color.White;
            this.lbXN.Location = new System.Drawing.Point(12, 250);
            this.lbXN.Name = "lbXN";
            this.lbXN.Size = new System.Drawing.Size(31, 13);
            this.lbXN.TabIndex = 8;
            this.lbXN.Text = "--------";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCalcular.Location = new System.Drawing.Point(12, 83);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(257, 51);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbdescricao
            // 
            this.lbdescricao.AutoSize = true;
            this.lbdescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.lbdescricao.Location = new System.Drawing.Point(117, 9);
            this.lbdescricao.Name = "lbdescricao";
            this.lbdescricao.Size = new System.Drawing.Size(77, 20);
            this.lbdescricao.TabIndex = 10;
            this.lbdescricao.Text = "Bhaskara";
            // 
            // Bhaskara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Bhaskara.Properties.Resources.a_formula_de_bhaskara_18373302_200120201846;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(385, 304);
            this.Controls.Add(this.lbdescricao);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbXN);
            this.Controls.Add(this.lbXP);
            this.Controls.Add(this.lbDelta);
            this.Controls.Add(this.lbzero);
            this.Controls.Add(this.lbx2);
            this.Controls.Add(this.lbx1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bhaskara";
            this.Text = "Bhaskara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lbx1;
        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lbzero;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbXP;
        private System.Windows.Forms.Label lbXN;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbdescricao;
    }
}

