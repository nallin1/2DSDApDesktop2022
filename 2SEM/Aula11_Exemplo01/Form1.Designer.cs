
namespace Aula11_Exemplo01
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCandidato01 = new System.Windows.Forms.Label();
            this.lblCandidato02 = new System.Windows.Forms.Label();
            this.lblCandidato03 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLimparDatas = new System.Windows.Forms.Button();
            this.btnApagarEvento = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnApagarEvento);
            this.tabPage1.Controls.Add(this.btnLimparDatas);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.mskData);
            this.tabPage1.Controls.Add(this.txtEvento);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(511, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Votação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // txtEvento
            // 
            this.txtEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvento.Location = new System.Drawing.Point(124, 25);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(298, 35);
            this.txtEvento.TabIndex = 1;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData.Location = new System.Drawing.Point(124, 78);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(298, 35);
            this.mskData.TabIndex = 2;
            this.mskData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskData_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 238);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(321, 144);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(155, 238);
            this.listBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Controls.Add(this.btnVotar);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidatos";
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnVotar.Location = new System.Drawing.Point(7, 131);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(486, 34);
            this.btnVotar.TabIndex = 0;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 17;
            this.listBox3.Items.AddRange(new object[] {
            "Lula <3",
            "Sofia Manzano",
            "Léo Péricles"});
            this.listBox3.Location = new System.Drawing.Point(7, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(486, 106);
            this.listBox3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblCandidato03);
            this.groupBox2.Controls.Add(this.lblCandidato02);
            this.groupBox2.Controls.Add(this.lblCandidato01);
            this.groupBox2.Location = new System.Drawing.Point(7, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lblCandidato01
            // 
            this.lblCandidato01.AutoSize = true;
            this.lblCandidato01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCandidato01.Location = new System.Drawing.Point(18, 48);
            this.lblCandidato01.Name = "lblCandidato01";
            this.lblCandidato01.Size = new System.Drawing.Size(112, 20);
            this.lblCandidato01.TabIndex = 0;
            this.lblCandidato01.Text = "Candidato 01:";
            // 
            // lblCandidato02
            // 
            this.lblCandidato02.AutoSize = true;
            this.lblCandidato02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCandidato02.Location = new System.Drawing.Point(19, 87);
            this.lblCandidato02.Name = "lblCandidato02";
            this.lblCandidato02.Size = new System.Drawing.Size(112, 20);
            this.lblCandidato02.TabIndex = 1;
            this.lblCandidato02.Text = "Candidato 02:";
            // 
            // lblCandidato03
            // 
            this.lblCandidato03.AutoSize = true;
            this.lblCandidato03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCandidato03.Location = new System.Drawing.Point(19, 125);
            this.lblCandidato03.Name = "lblCandidato03";
            this.lblCandidato03.Size = new System.Drawing.Size(112, 20);
            this.lblCandidato03.TabIndex = 2;
            this.lblCandidato03.Text = "Candidato 03:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(137, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox2.Location = new System.Drawing.Point(137, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(314, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox3.Location = new System.Drawing.Point(137, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(314, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "0";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLimpar.Location = new System.Drawing.Point(22, 167);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 34);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLimparDatas
            // 
            this.btnLimparDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLimparDatas.Location = new System.Drawing.Point(34, 427);
            this.btnLimparDatas.Name = "btnLimparDatas";
            this.btnLimparDatas.Size = new System.Drawing.Size(84, 34);
            this.btnLimparDatas.TabIndex = 4;
            this.btnLimparDatas.Text = "Limpar";
            this.btnLimparDatas.UseVisualStyleBackColor = true;
            this.btnLimparDatas.Click += new System.EventHandler(this.btnLimparDatas_Click);
            // 
            // btnApagarEvento
            // 
            this.btnApagarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnApagarEvento.Location = new System.Drawing.Point(34, 388);
            this.btnApagarEvento.Name = "btnApagarEvento";
            this.btnApagarEvento.Size = new System.Drawing.Size(134, 33);
            this.btnApagarEvento.TabIndex = 5;
            this.btnApagarEvento.Text = "Apagar Evento";
            this.btnApagarEvento.UseVisualStyleBackColor = true;
            this.btnApagarEvento.Click += new System.EventHandler(this.btnApagarEvento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCandidato03;
        private System.Windows.Forms.Label lblCandidato02;
        private System.Windows.Forms.Label lblCandidato01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLimparDatas;
        private System.Windows.Forms.Button btnApagarEvento;
    }
}

