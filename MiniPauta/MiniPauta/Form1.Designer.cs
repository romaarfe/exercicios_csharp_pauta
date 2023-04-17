namespace MiniPauta
{
    partial class Form1
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
            this.dgvPauta = new System.Windows.Forms.DataGridView();
            this.btnContarRaparigas = new System.Windows.Forms.Button();
            this.btnRapazesMaximinos = new System.Windows.Forms.Button();
            this.btnRapazesOuRaparigas = new System.Windows.Forms.Button();
            this.btnMaisVelho = new System.Windows.Forms.Button();
            this.btnReprovadosMaior12 = new System.Windows.Forms.Button();
            this.btn3MelhoresDecrescente = new System.Windows.Forms.Button();
            this.btnApelidosReprovados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPauta
            // 
            this.dgvPauta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPauta.Location = new System.Drawing.Point(12, 12);
            this.dgvPauta.Name = "dgvPauta";
            this.dgvPauta.Size = new System.Drawing.Size(1057, 513);
            this.dgvPauta.TabIndex = 0;
            // 
            // btnContarRaparigas
            // 
            this.btnContarRaparigas.Location = new System.Drawing.Point(13, 532);
            this.btnContarRaparigas.Name = "btnContarRaparigas";
            this.btnContarRaparigas.Size = new System.Drawing.Size(111, 98);
            this.btnContarRaparigas.TabIndex = 1;
            this.btnContarRaparigas.Text = "Quantas raparigas?";
            this.btnContarRaparigas.UseVisualStyleBackColor = true;
            this.btnContarRaparigas.Click += new System.EventHandler(this.btnContarRaparigas_Click);
            // 
            // btnRapazesMaximinos
            // 
            this.btnRapazesMaximinos.Location = new System.Drawing.Point(130, 532);
            this.btnRapazesMaximinos.Name = "btnRapazesMaximinos";
            this.btnRapazesMaximinos.Size = new System.Drawing.Size(114, 98);
            this.btnRapazesMaximinos.TabIndex = 2;
            this.btnRapazesMaximinos.Text = "Quantos rapazes são de Maximinos?";
            this.btnRapazesMaximinos.UseVisualStyleBackColor = true;
            this.btnRapazesMaximinos.Click += new System.EventHandler(this.btnRapazesMaximinos_Click);
            // 
            // btnRapazesOuRaparigas
            // 
            this.btnRapazesOuRaparigas.Location = new System.Drawing.Point(250, 532);
            this.btnRapazesOuRaparigas.Name = "btnRapazesOuRaparigas";
            this.btnRapazesOuRaparigas.Size = new System.Drawing.Size(108, 98);
            this.btnRapazesOuRaparigas.TabIndex = 3;
            this.btnRapazesOuRaparigas.Text = "Há mais rapazes ou raparigas?";
            this.btnRapazesOuRaparigas.UseVisualStyleBackColor = true;
            this.btnRapazesOuRaparigas.Click += new System.EventHandler(this.btnRapazesOuRaparigas_Click);
            // 
            // btnMaisVelho
            // 
            this.btnMaisVelho.Location = new System.Drawing.Point(364, 532);
            this.btnMaisVelho.Name = "btnMaisVelho";
            this.btnMaisVelho.Size = new System.Drawing.Size(107, 98);
            this.btnMaisVelho.TabIndex = 4;
            this.btnMaisVelho.Text = "Quem é o mais velho?";
            this.btnMaisVelho.UseVisualStyleBackColor = true;
            this.btnMaisVelho.Click += new System.EventHandler(this.btnMaisVelho_Click);
            // 
            // btnReprovadosMaior12
            // 
            this.btnReprovadosMaior12.Location = new System.Drawing.Point(477, 532);
            this.btnReprovadosMaior12.Name = "btnReprovadosMaior12";
            this.btnReprovadosMaior12.Size = new System.Drawing.Size(108, 98);
            this.btnReprovadosMaior12.TabIndex = 5;
            this.btnReprovadosMaior12.Text = "Quantos reprovados tem média superior a 12?";
            this.btnReprovadosMaior12.UseVisualStyleBackColor = true;
            this.btnReprovadosMaior12.Click += new System.EventHandler(this.btnReprovadosMaior12_Click);
            // 
            // btn3MelhoresDecrescente
            // 
            this.btn3MelhoresDecrescente.Location = new System.Drawing.Point(591, 532);
            this.btn3MelhoresDecrescente.Name = "btn3MelhoresDecrescente";
            this.btn3MelhoresDecrescente.Size = new System.Drawing.Size(107, 98);
            this.btn3MelhoresDecrescente.TabIndex = 6;
            this.btn3MelhoresDecrescente.Text = "Listar por ordem decrescente, os nomes dos 3 melhores ";
            this.btn3MelhoresDecrescente.UseVisualStyleBackColor = true;
            this.btn3MelhoresDecrescente.Click += new System.EventHandler(this.btn3MelhoresDecrescente_Click);
            // 
            // btnApelidosReprovados
            // 
            this.btnApelidosReprovados.Location = new System.Drawing.Point(705, 532);
            this.btnApelidosReprovados.Name = "btnApelidosReprovados";
            this.btnApelidosReprovados.Size = new System.Drawing.Size(118, 98);
            this.btnApelidosReprovados.TabIndex = 7;
            this.btnApelidosReprovados.Text = "Lista apelidos dos reprovados";
            this.btnApelidosReprovados.UseVisualStyleBackColor = true;
            this.btnApelidosReprovados.Click += new System.EventHandler(this.btnApelidosReprovados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 642);
            this.Controls.Add(this.btnApelidosReprovados);
            this.Controls.Add(this.btn3MelhoresDecrescente);
            this.Controls.Add(this.btnReprovadosMaior12);
            this.Controls.Add(this.btnMaisVelho);
            this.Controls.Add(this.btnRapazesOuRaparigas);
            this.Controls.Add(this.btnRapazesMaximinos);
            this.Controls.Add(this.btnContarRaparigas);
            this.Controls.Add(this.dgvPauta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPauta;
        private System.Windows.Forms.Button btnContarRaparigas;
        private System.Windows.Forms.Button btnRapazesMaximinos;
        private System.Windows.Forms.Button btnRapazesOuRaparigas;
        private System.Windows.Forms.Button btnMaisVelho;
        private System.Windows.Forms.Button btnReprovadosMaior12;
        private System.Windows.Forms.Button btn3MelhoresDecrescente;
        private System.Windows.Forms.Button btnApelidosReprovados;
    }
}

