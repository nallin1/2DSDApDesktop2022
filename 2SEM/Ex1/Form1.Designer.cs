
namespace Ex1
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
            this.components = new System.ComponentModel.Container();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.Location = new System.Drawing.Point(162, 46);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(284, 73);
            this.lblCronometro.TabIndex = 0;
            this.lblCronometro.Text = "00:00:00";
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnLigar.Location = new System.Drawing.Point(12, 12);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(97, 40);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnDesligar.Location = new System.Drawing.Point(12, 58);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(116, 45);
            this.btnDesligar.TabIndex = 1;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnZerar.Location = new System.Drawing.Point(12, 109);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(116, 45);
            this.btnZerar.TabIndex = 1;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 167);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblCronometro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Timer timer1;
    }
}

