
namespace ProjetoEstudio.view
{
    partial class FRMConsultarModalidade
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
            this.btnAtualizarConsulta = new System.Windows.Forms.Button();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.txtQtdAulas = new System.Windows.Forms.TextBox();
            this.txtQtdAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualizarConsulta);
            this.groupBox1.Controls.Add(this.cbModalidade);
            this.groupBox1.Controls.Add(this.txtQtdAulas);
            this.groupBox1.Controls.Add(this.txtQtdAlunos);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Modalidade";
            // 
            // btnAtualizarConsulta
            // 
            this.btnAtualizarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAtualizarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarConsulta.Location = new System.Drawing.Point(42, 188);
            this.btnAtualizarConsulta.Name = "btnAtualizarConsulta";
            this.btnAtualizarConsulta.Size = new System.Drawing.Size(522, 35);
            this.btnAtualizarConsulta.TabIndex = 6;
            this.btnAtualizarConsulta.Text = "Consultar";
            this.btnAtualizarConsulta.UseVisualStyleBackColor = false;
            this.btnAtualizarConsulta.Click += new System.EventHandler(this.btnAtualizarConsulta_Click);
            // 
            // cbModalidade
            // 
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(182, 48);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(382, 28);
            this.cbModalidade.TabIndex = 5;
            this.cbModalidade.SelectedIndexChanged += new System.EventHandler(this.cbModalidade_SelectedIndexChanged);
            // 
            // txtQtdAulas
            // 
            this.txtQtdAulas.Location = new System.Drawing.Point(182, 149);
            this.txtQtdAulas.Name = "txtQtdAulas";
            this.txtQtdAulas.ReadOnly = true;
            this.txtQtdAulas.Size = new System.Drawing.Size(382, 26);
            this.txtQtdAulas.TabIndex = 4;
            // 
            // txtQtdAlunos
            // 
            this.txtQtdAlunos.Location = new System.Drawing.Point(182, 115);
            this.txtQtdAlunos.Name = "txtQtdAlunos";
            this.txtQtdAlunos.ReadOnly = true;
            this.txtQtdAlunos.Size = new System.Drawing.Size(382, 26);
            this.txtQtdAlunos.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(182, 82);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(382, 26);
            this.txtPreco.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Qtd. de Aulas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Qtd. de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // FRMConsultarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 286);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMConsultarModalidade";
            this.Text = "Consultar Modalidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMConsultarModalidade_FormClosed);
            this.Load += new System.EventHandler(this.FRMConsultarModalidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.TextBox txtQtdAulas;
        private System.Windows.Forms.TextBox txtQtdAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizarConsulta;
    }
}