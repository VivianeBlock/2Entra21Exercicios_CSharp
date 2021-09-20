
namespace Estacionamento
{
    partial class Saida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saida));
            this.lblSaindo = new System.Windows.Forms.Label();
            this.lblinstrucao2 = new System.Windows.Forms.Label();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.btnConfirmar2 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaindo
            // 
            this.lblSaindo.AutoSize = true;
            this.lblSaindo.BackColor = System.Drawing.Color.DeepPink;
            this.lblSaindo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaindo.Location = new System.Drawing.Point(361, 9);
            this.lblSaindo.Name = "lblSaindo";
            this.lblSaindo.Size = new System.Drawing.Size(139, 36);
            this.lblSaindo.TabIndex = 0;
            this.lblSaindo.Text = "Saida de Veiculo";
            // 
            // lblinstrucao2
            // 
            this.lblinstrucao2.AutoSize = true;
            this.lblinstrucao2.BackColor = System.Drawing.Color.Indigo;
            this.lblinstrucao2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblinstrucao2.Location = new System.Drawing.Point(56, 26);
            this.lblinstrucao2.Name = "lblinstrucao2";
            this.lblinstrucao2.Size = new System.Drawing.Size(216, 36);
            this.lblinstrucao2.TabIndex = 1;
            this.lblinstrucao2.Text = "Informe a placa do veiculo:";
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(89, 74);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(183, 44);
            this.cbPlaca.TabIndex = 2;
            // 
            // btnConfirmar2
            // 
            this.btnConfirmar2.Location = new System.Drawing.Point(161, 137);
            this.btnConfirmar2.Name = "btnConfirmar2";
            this.btnConfirmar2.Size = new System.Drawing.Size(111, 38);
            this.btnConfirmar2.TabIndex = 3;
            this.btnConfirmar2.Text = "Confirmar";
            this.btnConfirmar2.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Indigo;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(389, 137);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 38);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 214);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar2);
            this.Controls.Add(this.cbPlaca);
            this.Controls.Add(this.lblinstrucao2);
            this.Controls.Add(this.lblSaindo);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida";
            this.Load += new System.EventHandler(this.Saida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaindo;
        private System.Windows.Forms.Label lblinstrucao2;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.Button btnConfirmar2;
        private System.Windows.Forms.Button btnVoltar;
    }
}