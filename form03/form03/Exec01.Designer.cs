
namespace form03
{
    partial class Exec01
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
            this.Cb01 = new System.Windows.Forms.ComboBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dgNome = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgNome)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb01
            // 
            this.Cb01.FormattingEnabled = true;
            this.Cb01.Location = new System.Drawing.Point(69, 53);
            this.Cb01.Name = "Cb01";
            this.Cb01.Size = new System.Drawing.Size(248, 44);
            this.Cb01.TabIndex = 0;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(214, 136);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(103, 42);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // dgNome
            // 
            this.dgNome.AllowUserToAddRows = false;
            this.dgNome.AllowUserToDeleteRows = false;
            this.dgNome.AllowUserToOrderColumns = true;
            this.dgNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NomeCol,
            this.CpfCol,
            this.IdadeCol});
            this.dgNome.Location = new System.Drawing.Point(11, 263);
            this.dgNome.Name = "dgNome";
            this.dgNome.ReadOnly = true;
            this.dgNome.Size = new System.Drawing.Size(710, 210);
            this.dgNome.TabIndex = 3;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "ID";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            // 
            // CpfCol
            // 
            this.CpfCol.HeaderText = "CPF";
            this.CpfCol.Name = "CpfCol";
            this.CpfCol.ReadOnly = true;
            // 
            // IdadeCol
            // 
            this.IdadeCol.HeaderText = "Idade";
            this.IdadeCol.Name = "IdadeCol";
            this.IdadeCol.ReadOnly = true;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.dgNome);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.Cb01);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Exec01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec01_FormClosed);
            this.Load += new System.EventHandler(this.Exec01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb01;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridView dgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeCol;
    }
}