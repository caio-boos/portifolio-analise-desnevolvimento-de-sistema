namespace Portifolio
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultadoQuestaoA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultadoQuestaoB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadoQuestaoC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultadoQuestaoD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ResultadoQuestaoE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "A)Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a" +
    " 40.\r\n\r\n";
            // 
            // ResultadoQuestaoA
            // 
            this.ResultadoQuestaoA.AutoSize = true;
            this.ResultadoQuestaoA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResultadoQuestaoA.Location = new System.Drawing.Point(35, 59);
            this.ResultadoQuestaoA.Name = "ResultadoQuestaoA";
            this.ResultadoQuestaoA.Size = new System.Drawing.Size(52, 13);
            this.ResultadoQuestaoA.TabIndex = 1;
            this.ResultadoQuestaoA.Text = "Resposta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "B)Apresentar o total da soma dos 100 primeiros números inteiros, representados pe" +
    "la sequência\r\n1+2+3+4...+98+99+100\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResultadoQuestaoB
            // 
            this.ResultadoQuestaoB.AutoSize = true;
            this.ResultadoQuestaoB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResultadoQuestaoB.Location = new System.Drawing.Point(35, 120);
            this.ResultadoQuestaoB.Name = "ResultadoQuestaoB";
            this.ResultadoQuestaoB.Size = new System.Drawing.Size(52, 13);
            this.ResultadoQuestaoB.TabIndex = 3;
            this.ResultadoQuestaoB.Text = "Resposta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "c) Apresentar todos os números divisíveis por 4 que sejam menores que 40. Iniciar" +
    " a contagem com o valor 1\r\n(um).\r\n";
            // 
            // ResultadoQuestaoC
            // 
            this.ResultadoQuestaoC.AutoSize = true;
            this.ResultadoQuestaoC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResultadoQuestaoC.Location = new System.Drawing.Point(35, 169);
            this.ResultadoQuestaoC.Name = "ResultadoQuestaoC";
            this.ResultadoQuestaoC.Size = new System.Drawing.Size(52, 13);
            this.ResultadoQuestaoC.TabIndex = 5;
            this.ResultadoQuestaoC.Text = "Resposta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(35, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "d) Apresentar os quadrados dos números inteiros de 15 a 200.";
            // 
            // ResultadoQuestaoD
            // 
            this.ResultadoQuestaoD.AutoSize = true;
            this.ResultadoQuestaoD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResultadoQuestaoD.Location = new System.Drawing.Point(35, 216);
            this.ResultadoQuestaoD.Name = "ResultadoQuestaoD";
            this.ResultadoQuestaoD.Size = new System.Drawing.Size(52, 13);
            this.ResultadoQuestaoD.TabIndex = 7;
            this.ResultadoQuestaoD.Text = "Resposta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(35, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "e) Apresentar o resultado da soma de todos os valores pares existentes na faixa n" +
    "umérica de 1 a 50.\r\n";
            // 
            // ResultadoQuestaoE
            // 
            this.ResultadoQuestaoE.AutoSize = true;
            this.ResultadoQuestaoE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResultadoQuestaoE.Location = new System.Drawing.Point(35, 359);
            this.ResultadoQuestaoE.Name = "ResultadoQuestaoE";
            this.ResultadoQuestaoE.Size = new System.Drawing.Size(52, 13);
            this.ResultadoQuestaoE.TabIndex = 9;
            this.ResultadoQuestaoE.Text = "Resposta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadoQuestaoE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ResultadoQuestaoD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultadoQuestaoC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultadoQuestaoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultadoQuestaoA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultadoQuestaoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultadoQuestaoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ResultadoQuestaoC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ResultadoQuestaoD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ResultadoQuestaoE;
    }
}

