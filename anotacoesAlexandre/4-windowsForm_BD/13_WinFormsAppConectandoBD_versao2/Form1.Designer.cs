
namespace WinFormsAppBancoExemplo
{
    partial class Form1
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
            this.button_conectar = new System.Windows.Forms.Button();
            this.listView_pacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.panel_campos = new System.Windows.Forms.Panel();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.panel_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(13, 182);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(75, 23);
            this.button_conectar.TabIndex = 0;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // listView_pacientes
            // 
            this.listView_pacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_pacientes.HideSelection = false;
            this.listView_pacientes.Location = new System.Drawing.Point(12, 12);
            this.listView_pacientes.Name = "listView_pacientes";
            this.listView_pacientes.Size = new System.Drawing.Size(376, 146);
            this.listView_pacientes.TabIndex = 1;
            this.listView_pacientes.UseCompatibleStateImageBehavior = false;
            this.listView_pacientes.View = System.Windows.Forms.View.Details;
            this.listView_pacientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_pacientes_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idPaciente";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 150;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(110, 182);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 2;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // panel_campos
            // 
            this.panel_campos.Controls.Add(this.button_voltar);
            this.panel_campos.Controls.Add(this.button_salvar);
            this.panel_campos.Controls.Add(this.textBox_email);
            this.panel_campos.Controls.Add(this.textBox_nome);
            this.panel_campos.Controls.Add(this.textBox_idPaciente);
            this.panel_campos.Controls.Add(this.label3);
            this.panel_campos.Controls.Add(this.label2);
            this.panel_campos.Controls.Add(this.label1);
            this.panel_campos.Enabled = false;
            this.panel_campos.Location = new System.Drawing.Point(12, 229);
            this.panel_campos.Name = "panel_campos";
            this.panel_campos.Size = new System.Drawing.Size(376, 163);
            this.panel_campos.TabIndex = 3;
            // 
            // button_voltar
            // 
            this.button_voltar.Location = new System.Drawing.Point(163, 122);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(75, 23);
            this.button_voltar.TabIndex = 7;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(82, 122);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 6;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(82, 79);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(282, 23);
            this.textBox_email.TabIndex = 5;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(82, 43);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(282, 23);
            this.textBox_nome.TabIndex = 4;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Location = new System.Drawing.Point(82, 7);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(74, 23);
            this.textBox_idPaciente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "idPaciente";
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(210, 182);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 4;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(313, 182);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 5;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 404);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.panel_campos);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.listView_pacientes);
            this.Controls.Add(this.button_conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_campos.ResumeLayout(false);
            this.panel_campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_conectar;
        private System.Windows.Forms.ListView listView_pacientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Panel panel_campos;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_idPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_editar;
    }
}

