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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.button_adicionarLista = new System.Windows.Forms.Button();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button_listarEmails = new System.Windows.Forms.Button();
            this.button_listarDominios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_listaEmails = new System.Windows.Forms.TextBox();
            this.textBox_listaDominios = new System.Windows.Forms.TextBox();
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
            // 
            // button_adicionarLista
            // 
            this.button_adicionarLista.Location = new System.Drawing.Point(12, 109);
            this.button_adicionarLista.Name = "button_adicionarLista";
            this.button_adicionarLista.Size = new System.Drawing.Size(102, 23);
            this.button_adicionarLista.TabIndex = 3;
            this.button_adicionarLista.Text = "Inserir";
            this.button_adicionarLista.UseVisualStyleBackColor = true;
            this.button_adicionarLista.Click += new System.EventHandler(this.button_adicionarLista_Click);
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Location = new System.Drawing.Point(12, 148);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.ReadOnly = true;
            this.textBox_listaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaNomes.Size = new System.Drawing.Size(193, 290);
            this.textBox_listaNomes.TabIndex = 6;
            this.textBox_listaNomes.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button_listarEmails
            // 
            this.button_listarEmails.Location = new System.Drawing.Point(229, 109);
            this.button_listarEmails.Name = "button_listarEmails";
            this.button_listarEmails.Size = new System.Drawing.Size(102, 23);
            this.button_listarEmails.TabIndex = 4;
            this.button_listarEmails.Text = "Listar Emails";
            this.button_listarEmails.UseVisualStyleBackColor = true;
            // 
            // button_listarDominios
            // 
            this.button_listarDominios.Location = new System.Drawing.Point(438, 109);
            this.button_listarDominios.Name = "button_listarDominios";
            this.button_listarDominios.Size = new System.Drawing.Size(101, 23);
            this.button_listarDominios.TabIndex = 5;
            this.button_listarDominios.Text = "Listar Domínios";
            this.button_listarDominios.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email: ";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(120, 43);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(263, 23);
            this.textBox_email.TabIndex = 2;
            // 
            // textBox_listaEmails
            // 
            this.textBox_listaEmails.Location = new System.Drawing.Point(228, 148);
            this.textBox_listaEmails.Multiline = true;
            this.textBox_listaEmails.Name = "textBox_listaEmails";
            this.textBox_listaEmails.ReadOnly = true;
            this.textBox_listaEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaEmails.Size = new System.Drawing.Size(183, 290);
            this.textBox_listaEmails.TabIndex = 7;
            this.textBox_listaEmails.TabStop = false;
            // 
            // textBox_listaDominios
            // 
            this.textBox_listaDominios.Location = new System.Drawing.Point(438, 148);
            this.textBox_listaDominios.Multiline = true;
            this.textBox_listaDominios.Name = "textBox_listaDominios";
            this.textBox_listaDominios.ReadOnly = true;
            this.textBox_listaDominios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaDominios.Size = new System.Drawing.Size(183, 290);
            this.textBox_listaDominios.TabIndex = 8;
            this.textBox_listaDominios.TabStop = false;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 443);
            this.Controls.Add(this.textBox_listaDominios);
            this.Controls.Add(this.textBox_listaEmails);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_listarDominios);
            this.Controls.Add(this.button_listarEmails);
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
        private PrintPreviewDialog printPreviewDialog1;
        private Button button_listarEmails;
        private Button button_listarDominios;
        private Label label2;
        private TextBox textBox_email;
        private TextBox textBox_listaEmails;
        private TextBox textBox_listaDominios;
    }
}