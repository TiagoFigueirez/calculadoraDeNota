namespace RevisaoAula1
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcularExame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotaAnual = new System.Windows.Forms.TextBox();
            this.lblNotaExame = new System.Windows.Forms.Label();
            this.txtNotaExame = new System.Windows.Forms.TextBox();
            this.lblMediaExame = new System.Windows.Forms.Label();
            this.txtMediaExame = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblMensagem2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(25, 49);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(45, 13);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1 :";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(76, 46);
            this.txtNota1.MaxLength = 2;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(47, 20);
            this.txtNota1.TabIndex = 0;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(25, 91);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 13);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "Nota 2:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(76, 88);
            this.txtNota2.MaxLength = 2;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(47, 20);
            this.txtNota2.TabIndex = 1;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(25, 137);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 13);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "Nota 3:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(76, 134);
            this.txtNota3.MaxLength = 2;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(47, 20);
            this.txtNota3.TabIndex = 2;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(25, 181);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(42, 13);
            this.lblNota4.TabIndex = 6;
            this.lblNota4.Text = "Nota 4:";
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(76, 178);
            this.txtNota4.MaxLength = 2;
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(47, 20);
            this.txtNota4.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(48, 338);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 39);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Cal&cular Media";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(340, 338);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 39);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcularExame
            // 
            this.btnCalcularExame.Location = new System.Drawing.Point(281, 178);
            this.btnCalcularExame.Name = "btnCalcularExame";
            this.btnCalcularExame.Size = new System.Drawing.Size(71, 45);
            this.btnCalcularExame.TabIndex = 7;
            this.btnCalcularExame.Text = "Calcular Exame";
            this.btnCalcularExame.UseVisualStyleBackColor = true;
            this.btnCalcularExame.Visible = false;
            this.btnCalcularExame.Click += new System.EventHandler(this.btnCalcularExame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nota Anual:";
            // 
            // txtNotaAnual
            // 
            this.txtNotaAnual.Enabled = false;
            this.txtNotaAnual.Location = new System.Drawing.Point(134, 233);
            this.txtNotaAnual.Name = "txtNotaAnual";
            this.txtNotaAnual.Size = new System.Drawing.Size(32, 20);
            this.txtNotaAnual.TabIndex = 12;
            // 
            // lblNotaExame
            // 
            this.lblNotaExame.AutoSize = true;
            this.lblNotaExame.Location = new System.Drawing.Point(260, 49);
            this.lblNotaExame.Name = "lblNotaExame";
            this.lblNotaExame.Size = new System.Drawing.Size(83, 13);
            this.lblNotaExame.TabIndex = 13;
            this.lblNotaExame.Text = "Nota do Exame:";
            this.lblNotaExame.Visible = false;
            // 
            // txtNotaExame
            // 
            this.txtNotaExame.Location = new System.Drawing.Point(349, 46);
            this.txtNotaExame.MaxLength = 2;
            this.txtNotaExame.Name = "txtNotaExame";
            this.txtNotaExame.Size = new System.Drawing.Size(42, 20);
            this.txtNotaExame.TabIndex = 4;
            this.txtNotaExame.Visible = false;
            // 
            // lblMediaExame
            // 
            this.lblMediaExame.AutoSize = true;
            this.lblMediaExame.Location = new System.Drawing.Point(254, 88);
            this.lblMediaExame.Name = "lblMediaExame";
            this.lblMediaExame.Size = new System.Drawing.Size(89, 13);
            this.lblMediaExame.TabIndex = 15;
            this.lblMediaExame.Text = "Media do Exame:";
            this.lblMediaExame.Visible = false;
            // 
            // txtMediaExame
            // 
            this.txtMediaExame.Enabled = false;
            this.txtMediaExame.Location = new System.Drawing.Point(349, 84);
            this.txtMediaExame.Name = "txtMediaExame";
            this.txtMediaExame.Size = new System.Drawing.Size(42, 20);
            this.txtMediaExame.TabIndex = 5;
            this.txtMediaExame.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMensagem.Location = new System.Drawing.Point(88, 291);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(58, 13);
            this.lblMensagem.TabIndex = 16;
            this.lblMensagem.Text = "mensagem";
            this.lblMensagem.Visible = false;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(184, 338);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(85, 39);
            this.btnLimparCampos.TabIndex = 17;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblMensagem2
            // 
            this.lblMensagem2.AutoSize = true;
            this.lblMensagem2.Location = new System.Drawing.Point(281, 136);
            this.lblMensagem2.Name = "lblMensagem2";
            this.lblMensagem2.Size = new System.Drawing.Size(64, 13);
            this.lblMensagem2.TabIndex = 18;
            this.lblMensagem2.Text = "mensagem2";
            this.lblMensagem2.Visible = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 407);
            this.Controls.Add(this.lblMensagem2);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtMediaExame);
            this.Controls.Add(this.lblMediaExame);
            this.Controls.Add(this.txtNotaExame);
            this.Controls.Add(this.lblNotaExame);
            this.Controls.Add(this.txtNotaAnual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularExame);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcularExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotaAnual;
        private System.Windows.Forms.Label lblNotaExame;
        private System.Windows.Forms.TextBox txtNotaExame;
        private System.Windows.Forms.Label lblMediaExame;
        private System.Windows.Forms.TextBox txtMediaExame;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblMensagem2;
    }
}

