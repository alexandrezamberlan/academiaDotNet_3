namespace PrimeiroWFADONET
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
            this.btn_SalvarDPTO = new System.Windows.Forms.Button();
            this.txb_NomeDPTO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_LocalizacaoDPTO = new System.Windows.Forms.TextBox();
            this.txb_OrcamentoDPTO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SalvarDPTO
            // 
            this.btn_SalvarDPTO.Location = new System.Drawing.Point(124, 152);
            this.btn_SalvarDPTO.Name = "btn_SalvarDPTO";
            this.btn_SalvarDPTO.Size = new System.Drawing.Size(75, 23);
            this.btn_SalvarDPTO.TabIndex = 0;
            this.btn_SalvarDPTO.Text = "Salvar";
            this.btn_SalvarDPTO.UseVisualStyleBackColor = true;
            this.btn_SalvarDPTO.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_NomeDPTO
            // 
            this.txb_NomeDPTO.Location = new System.Drawing.Point(99, 24);
            this.txb_NomeDPTO.Name = "txb_NomeDPTO";
            this.txb_NomeDPTO.Size = new System.Drawing.Size(100, 23);
            this.txb_NomeDPTO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localização";
            // 
            // txb_LocalizacaoDPTO
            // 
            this.txb_LocalizacaoDPTO.Location = new System.Drawing.Point(99, 62);
            this.txb_LocalizacaoDPTO.Name = "txb_LocalizacaoDPTO";
            this.txb_LocalizacaoDPTO.Size = new System.Drawing.Size(100, 23);
            this.txb_LocalizacaoDPTO.TabIndex = 4;
            // 
            // txb_OrcamentoDPTO
            // 
            this.txb_OrcamentoDPTO.Location = new System.Drawing.Point(99, 102);
            this.txb_OrcamentoDPTO.Name = "txb_OrcamentoDPTO";
            this.txb_OrcamentoDPTO.Size = new System.Drawing.Size(100, 23);
            this.txb_OrcamentoDPTO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Orçamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_OrcamentoDPTO);
            this.Controls.Add(this.txb_LocalizacaoDPTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_NomeDPTO);
            this.Controls.Add(this.btn_SalvarDPTO);
            this.Name = "Form1";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_SalvarDPTO;
        private TextBox txb_NomeDPTO;
        private Label label1;
        private Label label2;
        private TextBox txb_LocalizacaoDPTO;
        private TextBox txb_OrcamentoDPTO;
        private Label label3;
    }
}