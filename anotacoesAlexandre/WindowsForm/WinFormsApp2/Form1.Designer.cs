namespace WinFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.button_adicionarLista = new System.Windows.Forms.Button();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo: ";
            // 
            // textBox_nomeCompleto
            // 
            this.textBox_nomeCompleto.Location = new System.Drawing.Point(118, 6);
            this.textBox_nomeCompleto.Name = "textBox_nomeCompleto";
            this.textBox_nomeCompleto.Size = new System.Drawing.Size(265, 23);
            this.textBox_nomeCompleto.TabIndex = 1;
            this.textBox_nomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nomeCompleto_KeyPress);
            // 
            // button_adicionarLista
            // 
            this.button_adicionarLista.Location = new System.Drawing.Point(118, 53);
            this.button_adicionarLista.Name = "button_adicionarLista";
            this.button_adicionarLista.Size = new System.Drawing.Size(75, 23);
            this.button_adicionarLista.TabIndex = 2;
            this.button_adicionarLista.Text = "Inserir";
            this.button_adicionarLista.UseVisualStyleBackColor = true;
            this.button_adicionarLista.Click += new System.EventHandler(this.button_adicionarLista_Click);
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Enabled = false;
            this.textBox_listaNomes.Location = new System.Drawing.Point(118, 95);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.Size = new System.Drawing.Size(265, 343);
            this.textBox_listaNomes.TabIndex = 3;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.button_adicionarLista);
            this.Controls.Add(this.textBox_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form_principal";
            this.Text = "Titulo do formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nomeCompleto;
        private Button button_adicionarLista;
        private TextBox textBox_listaNomes;
    }
}