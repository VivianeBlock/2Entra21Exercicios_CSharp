
namespace form03
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
            this.RBExec01 = new System.Windows.Forms.RadioButton();
            this.RBExec02 = new System.Windows.Forms.RadioButton();
            this.btnInicia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RBExec01
            // 
            this.RBExec01.AutoSize = true;
            this.RBExec01.Location = new System.Drawing.Point(22, 28);
            this.RBExec01.Name = "RBExec01";
            this.RBExec01.Size = new System.Drawing.Size(115, 40);
            this.RBExec01.TabIndex = 0;
            this.RBExec01.TabStop = true;
            this.RBExec01.Text = "Exercicio 1";
            this.RBExec01.UseVisualStyleBackColor = true;
            // 
            // RBExec02
            // 
            this.RBExec02.AutoSize = true;
            this.RBExec02.Location = new System.Drawing.Point(22, 91);
            this.RBExec02.Name = "RBExec02";
            this.RBExec02.Size = new System.Drawing.Size(117, 40);
            this.RBExec02.TabIndex = 1;
            this.RBExec02.TabStop = true;
            this.RBExec02.Text = "Exercicio 2";
            this.RBExec02.UseVisualStyleBackColor = true;
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(22, 159);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(129, 47);
            this.btnInicia.TabIndex = 2;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.RBExec02);
            this.Controls.Add(this.RBExec01);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBExec01;
        private System.Windows.Forms.RadioButton RBExec02;
        private System.Windows.Forms.Button btnInicia;
    }
}

