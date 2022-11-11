namespace _13_WinFormsAppConectandoBD
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
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.button_conectarBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_idMedida = new System.Windows.Forms.TextBox();
            this.textBox_dataMedicao = new System.Windows.Forms.TextBox();
            this.textBox_valorGlicemia = new System.Windows.Forms.TextBox();
            this.panel_campos = new System.Windows.Forms.Panel();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.panel_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(12, 12);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(623, 182);
            this.listView_medidasGlicemias.TabIndex = 0;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            this.listView_medidasGlicemias.SelectedIndexChanged += new System.EventHandler(this.listView_medidasGlicemias_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idMedida";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "idPaciente";
            this.columnHeader5.Width = 80;
            // 
            // button_conectarBD
            // 
            this.button_conectarBD.Location = new System.Drawing.Point(12, 200);
            this.button_conectarBD.Name = "button_conectarBD";
            this.button_conectarBD.Size = new System.Drawing.Size(75, 23);
            this.button_conectarBD.TabIndex = 1;
            this.button_conectarBD.Text = "Conectar";
            this.button_conectarBD.UseVisualStyleBackColor = true;
            this.button_conectarBD.Click += new System.EventHandler(this.button_conectarBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "idGlicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Glicemia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Medição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "idPaciente";
            // 
            // textBox_idMedida
            // 
            this.textBox_idMedida.Enabled = false;
            this.textBox_idMedida.Location = new System.Drawing.Point(100, 6);
            this.textBox_idMedida.Name = "textBox_idMedida";
            this.textBox_idMedida.Size = new System.Drawing.Size(100, 23);
            this.textBox_idMedida.TabIndex = 6;
            // 
            // textBox_dataMedicao
            // 
            this.textBox_dataMedicao.Location = new System.Drawing.Point(100, 65);
            this.textBox_dataMedicao.Name = "textBox_dataMedicao";
            this.textBox_dataMedicao.Size = new System.Drawing.Size(100, 23);
            this.textBox_dataMedicao.TabIndex = 7;
            // 
            // textBox_valorGlicemia
            // 
            this.textBox_valorGlicemia.Location = new System.Drawing.Point(100, 36);
            this.textBox_valorGlicemia.Name = "textBox_valorGlicemia";
            this.textBox_valorGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBox_valorGlicemia.TabIndex = 8;
            // 
            // panel_campos
            // 
            this.panel_campos.Controls.Add(this.textBox_idPaciente);
            this.panel_campos.Controls.Add(this.button_gravar);
            this.panel_campos.Controls.Add(this.textBox_dataMedicao);
            this.panel_campos.Controls.Add(this.label1);
            this.panel_campos.Controls.Add(this.textBox_valorGlicemia);
            this.panel_campos.Controls.Add(this.label2);
            this.panel_campos.Controls.Add(this.label3);
            this.panel_campos.Controls.Add(this.textBox_idMedida);
            this.panel_campos.Controls.Add(this.label4);
            this.panel_campos.Enabled = false;
            this.panel_campos.Location = new System.Drawing.Point(12, 256);
            this.panel_campos.Name = "panel_campos";
            this.panel_campos.Size = new System.Drawing.Size(237, 182);
            this.panel_campos.TabIndex = 10;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Location = new System.Drawing.Point(100, 97);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBox_idPaciente.TabIndex = 11;
            // 
            // button_gravar
            // 
            this.button_gravar.Location = new System.Drawing.Point(100, 143);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 23);
            this.button_gravar.TabIndex = 10;
            this.button_gravar.Text = "Salvar";
            this.button_gravar.UseVisualStyleBackColor = true;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Enabled = false;
            this.button_cadastrar.Location = new System.Drawing.Point(93, 200);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 11;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Enabled = false;
            this.button_deletar.Location = new System.Drawing.Point(174, 200);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 12;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(255, 200);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 13;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 440);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.panel_campos);
            this.Controls.Add(this.button_conectarBD);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestão de medidas glicêmicas";
            this.panel_campos.ResumeLayout(false);
            this.panel_campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView_medidasGlicemias;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button_conectarBD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_idMedida;
        private TextBox textBox_dataMedicao;
        private TextBox textBox_valorGlicemia;
        private Panel panel_campos;
        private Button button_gravar;
        private Button button_cadastrar;
        private ColumnHeader columnHeader5;
        private TextBox textBox_idPaciente;
        private Button button_deletar;
        private Button button_editar;
    }
}