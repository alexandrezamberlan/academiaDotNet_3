namespace WinFormsApp4
{
    partial class Form_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_titulo = new System.Windows.Forms.Label();
            this.button_trocar = new System.Windows.Forms.Button();
            this.label_nomeJogador = new System.Windows.Forms.Label();
            this.textBox_nomeJogador = new System.Windows.Forms.TextBox();
            this.button_paraMaiusculo = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.textBox_listaJogadores = new System.Windows.Forms.TextBox();
            this.button_inserir = new System.Windows.Forms.Button();
            this.label_totalNomes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_titulo.Location = new System.Drawing.Point(12, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(218, 15);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Turma de Programação .Net Atos e UFN";
            // 
            // button_trocar
            // 
            this.button_trocar.Location = new System.Drawing.Point(12, 27);
            this.button_trocar.Name = "button_trocar";
            this.button_trocar.Size = new System.Drawing.Size(199, 23);
            this.button_trocar.TabIndex = 1;
            this.button_trocar.Text = "Oi turma de .Net da Atos e UFN";
            this.button_trocar.UseVisualStyleBackColor = true;
            this.button_trocar.Click += new System.EventHandler(this.button_trocar_Click);
            // 
            // label_nomeJogador
            // 
            this.label_nomeJogador.AutoSize = true;
            this.label_nomeJogador.Location = new System.Drawing.Point(12, 120);
            this.label_nomeJogador.Name = "label_nomeJogador";
            this.label_nomeJogador.Size = new System.Drawing.Size(87, 15);
            this.label_nomeJogador.TabIndex = 2;
            this.label_nomeJogador.Text = "Nome jogador:";
            // 
            // textBox_nomeJogador
            // 
            this.textBox_nomeJogador.Location = new System.Drawing.Point(111, 112);
            this.textBox_nomeJogador.Name = "textBox_nomeJogador";
            this.textBox_nomeJogador.Size = new System.Drawing.Size(232, 23);
            this.textBox_nomeJogador.TabIndex = 3;
            // 
            // button_paraMaiusculo
            // 
            this.button_paraMaiusculo.Location = new System.Drawing.Point(111, 141);
            this.button_paraMaiusculo.Name = "button_paraMaiusculo";
            this.button_paraMaiusculo.Size = new System.Drawing.Size(119, 23);
            this.button_paraMaiusculo.TabIndex = 4;
            this.button_paraMaiusculo.Text = "Para Maiusculo";
            this.button_paraMaiusculo.UseVisualStyleBackColor = true;
            this.button_paraMaiusculo.Click += new System.EventHandler(this.button_paraMaiusculo_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(236, 141);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(107, 23);
            this.button_limpar.TabIndex = 5;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // textBox_listaJogadores
            // 
            this.textBox_listaJogadores.Location = new System.Drawing.Point(369, 112);
            this.textBox_listaJogadores.Multiline = true;
            this.textBox_listaJogadores.Name = "textBox_listaJogadores";
            this.textBox_listaJogadores.ReadOnly = true;
            this.textBox_listaJogadores.Size = new System.Drawing.Size(233, 289);
            this.textBox_listaJogadores.TabIndex = 6;
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(111, 170);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(119, 23);
            this.button_inserir.TabIndex = 7;
            this.button_inserir.Text = "Inserir Nome";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // label_totalNomes
            // 
            this.label_totalNomes.AutoSize = true;
            this.label_totalNomes.Location = new System.Drawing.Point(309, 386);
            this.label_totalNomes.Name = "label_totalNomes";
            this.label_totalNomes.Size = new System.Drawing.Size(44, 15);
            this.label_totalNomes.TabIndex = 8;
            this.label_totalNomes.Text = "Total: 0";
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 413);
            this.Controls.Add(this.label_totalNomes);
            this.Controls.Add(this.button_inserir);
            this.Controls.Add(this.textBox_listaJogadores);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_paraMaiusculo);
            this.Controls.Add(this.textBox_nomeJogador);
            this.Controls.Add(this.label_nomeJogador);
            this.Controls.Add(this.button_trocar);
            this.Controls.Add(this.label_titulo);
            this.MaximumSize = new System.Drawing.Size(630, 452);
            this.MinimumSize = new System.Drawing.Size(630, 452);
            this.Name = "Form_principal";
            this.Text = "Formulário Desktop Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_titulo;
        private Button button_trocar;
        private Label label_nomeJogador;
        private TextBox textBox_nomeJogador;
        private Button button_paraMaiusculo;
        private Button button_limpar;
        private TextBox textBox_listaJogadores;
        private Button button_inserir;
        private Label label_totalNomes;
    }
}