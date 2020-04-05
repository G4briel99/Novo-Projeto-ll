namespace Projeto
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BntSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.TxtSenha);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.BntCancelar);
            this.panel1.Controls.Add(this.BntSalvar);
            this.panel1.Location = new System.Drawing.Point(173, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 260);
            this.panel1.TabIndex = 0;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(54, 86);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(281, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(281, 86);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Nome";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BntCancelar
            // 
            this.BntCancelar.Location = new System.Drawing.Point(294, 209);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(87, 33);
            this.BntCancelar.TabIndex = 1;
            this.BntCancelar.Text = "Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = true;
            this.BntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // BntSalvar
            // 
            this.BntSalvar.Location = new System.Drawing.Point(54, 209);
            this.BntSalvar.Name = "BntSalvar";
            this.BntSalvar.Size = new System.Drawing.Size(87, 33);
            this.BntSalvar.TabIndex = 0;
            this.BntSalvar.Text = "Salvar";
            this.BntSalvar.UseVisualStyleBackColor = true;
            this.BntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto.Properties.Resources.fundo_de_particulas_abstratas_tecnologia_realista_23_2148416025;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BntSalvar;
    }
}

