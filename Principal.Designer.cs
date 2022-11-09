namespace EntradaMatrix
{
    partial class Principal
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.txbAno = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txbAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(100, 170);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(63, 216);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(90, 18);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(12, 260);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(142, 18);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano de Nascimento:";
            this.lblAno.Click += new System.EventHandler(this.lblAno_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(159, 171);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(159, 217);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txbSobrenome.TabIndex = 4;
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(159, 262);
            this.txbAno.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txbAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(100, 20);
            this.txbAno.TabIndex = 5;
            this.txbAno.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txbAno.ValueChanged += new System.EventHandler(this.txbAno_ValueChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(159, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(159, 305);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(494, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(12, 415);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 12);
            this.lblResultado.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Engravers MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(37, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(499, 41);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "ENTER THE MATRIX";
            // 
            // pibIcone
            // 
            this.pibIcone.Location = new System.Drawing.Point(283, 107);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(286, 299);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 9;
            this.pibIcone.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pibIcone);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.txbAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.NumericUpDown txbAno;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pibIcone;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTitulo;
    }
}