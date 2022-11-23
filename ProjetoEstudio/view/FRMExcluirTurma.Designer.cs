
namespace ProjetoEstudio.view
{
    partial class FRMExcluirTurma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.cbDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.cbTurmas = new System.Windows.Forms.ComboBox();
            this.BTNexcluirTurma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbHora);
            this.groupBox1.Controls.Add(this.cbDiaDaSemana);
            this.groupBox1.Controls.Add(this.cbTurmas);
            this.groupBox1.Controls.Add(this.BTNexcluirTurma);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(39, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia da Semana:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbHora
            // 
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(157, 155);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(367, 28);
            this.cbHora.TabIndex = 1;
            this.cbHora.SelectedIndexChanged += new System.EventHandler(this.cbHora_SelectedIndexChanged);
            // 
            // cbDiaDaSemana
            // 
            this.cbDiaDaSemana.FormattingEnabled = true;
            this.cbDiaDaSemana.Location = new System.Drawing.Point(157, 107);
            this.cbDiaDaSemana.Name = "cbDiaDaSemana";
            this.cbDiaDaSemana.Size = new System.Drawing.Size(367, 28);
            this.cbDiaDaSemana.TabIndex = 1;
            this.cbDiaDaSemana.SelectedIndexChanged += new System.EventHandler(this.dbDiaDaSemana_SelectedIndexChanged);
            // 
            // cbTurmas
            // 
            this.cbTurmas.FormattingEnabled = true;
            this.cbTurmas.Location = new System.Drawing.Point(157, 58);
            this.cbTurmas.Name = "cbTurmas";
            this.cbTurmas.Size = new System.Drawing.Size(367, 28);
            this.cbTurmas.TabIndex = 1;
            this.cbTurmas.SelectedIndexChanged += new System.EventHandler(this.cbTurmas_SelectedIndexChanged);
            // 
            // BTNexcluirTurma
            // 
            this.BTNexcluirTurma.BackColor = System.Drawing.Color.Lime;
            this.BTNexcluirTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNexcluirTurma.Location = new System.Drawing.Point(26, 218);
            this.BTNexcluirTurma.Name = "BTNexcluirTurma";
            this.BTNexcluirTurma.Size = new System.Drawing.Size(498, 44);
            this.BTNexcluirTurma.TabIndex = 0;
            this.BTNexcluirTurma.Text = "Excluir Turma";
            this.BTNexcluirTurma.UseVisualStyleBackColor = false;
            this.BTNexcluirTurma.Click += new System.EventHandler(this.BTNexcluirTurma_Click);
            // 
            // FRMExcluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMExcluirTurma";
            this.Text = "Excluir Turma";
            this.Load += new System.EventHandler(this.FRMExcluirTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTurmas;
        private System.Windows.Forms.Button BTNexcluirTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.ComboBox cbDiaDaSemana;
    }
}