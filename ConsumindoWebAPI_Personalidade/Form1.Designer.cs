namespace ConsumindoWebAPI_Personalidade
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
            this.txtURI = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnOterPersonalidades = new System.Windows.Forms.Button();
            this.btnPersonalidadePorId = new System.Windows.Forms.Button();
            this.btnIncluirPersonalidade = new System.Windows.Forms.Button();
            this.btnAtualizaPersonalidade = new System.Windows.Forms.Button();
            this.btnDeletarPersonalidade = new System.Windows.Forms.Button();
            this.btnGetBySexo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI - WebAPI:";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(96, 12);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(566, 20);
            this.txtURI.TabIndex = 1;
            this.txtURI.Text = "http://localhost:54787/api/Personalidade";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 38);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(650, 278);
            this.dgvDados.TabIndex = 2;
            // 
            // btnOterPersonalidades
            // 
            this.btnOterPersonalidades.Location = new System.Drawing.Point(15, 322);
            this.btnOterPersonalidades.Name = "btnOterPersonalidades";
            this.btnOterPersonalidades.Size = new System.Drawing.Size(100, 23);
            this.btnOterPersonalidades.TabIndex = 3;
            this.btnOterPersonalidades.Text = "Get All";
            this.btnOterPersonalidades.UseVisualStyleBackColor = true;
            this.btnOterPersonalidades.Click += new System.EventHandler(this.btnOterPersonalidades_Click);
            // 
            // btnPersonalidadePorId
            // 
            this.btnPersonalidadePorId.Location = new System.Drawing.Point(124, 322);
            this.btnPersonalidadePorId.Name = "btnPersonalidadePorId";
            this.btnPersonalidadePorId.Size = new System.Drawing.Size(100, 23);
            this.btnPersonalidadePorId.TabIndex = 4;
            this.btnPersonalidadePorId.Text = "Get By Id";
            this.btnPersonalidadePorId.UseVisualStyleBackColor = true;
            this.btnPersonalidadePorId.Click += new System.EventHandler(this.btnPersonalidadePorId_Click);
            // 
            // btnIncluirPersonalidade
            // 
            this.btnIncluirPersonalidade.Location = new System.Drawing.Point(342, 322);
            this.btnIncluirPersonalidade.Name = "btnIncluirPersonalidade";
            this.btnIncluirPersonalidade.Size = new System.Drawing.Size(100, 23);
            this.btnIncluirPersonalidade.TabIndex = 5;
            this.btnIncluirPersonalidade.Text = "Create";
            this.btnIncluirPersonalidade.UseVisualStyleBackColor = true;
            this.btnIncluirPersonalidade.Click += new System.EventHandler(this.btnIncluirPersonalidade_Click);
            // 
            // btnAtualizaPersonalidade
            // 
            this.btnAtualizaPersonalidade.Location = new System.Drawing.Point(451, 322);
            this.btnAtualizaPersonalidade.Name = "btnAtualizaPersonalidade";
            this.btnAtualizaPersonalidade.Size = new System.Drawing.Size(100, 23);
            this.btnAtualizaPersonalidade.TabIndex = 6;
            this.btnAtualizaPersonalidade.Text = "Update";
            this.btnAtualizaPersonalidade.UseVisualStyleBackColor = true;
            this.btnAtualizaPersonalidade.Click += new System.EventHandler(this.btnAtualizaPersonalidade_Click);
            // 
            // btnDeletarPersonalidade
            // 
            this.btnDeletarPersonalidade.Location = new System.Drawing.Point(560, 322);
            this.btnDeletarPersonalidade.Name = "btnDeletarPersonalidade";
            this.btnDeletarPersonalidade.Size = new System.Drawing.Size(100, 23);
            this.btnDeletarPersonalidade.TabIndex = 7;
            this.btnDeletarPersonalidade.Text = "Delete";
            this.btnDeletarPersonalidade.UseVisualStyleBackColor = true;
            this.btnDeletarPersonalidade.Click += new System.EventHandler(this.btnDeletarPersonalidade_Click);
            // 
            // btnGetBySexo
            // 
            this.btnGetBySexo.Location = new System.Drawing.Point(233, 322);
            this.btnGetBySexo.Name = "btnGetBySexo";
            this.btnGetBySexo.Size = new System.Drawing.Size(100, 23);
            this.btnGetBySexo.TabIndex = 8;
            this.btnGetBySexo.Text = "Get By Sexo";
            this.btnGetBySexo.UseVisualStyleBackColor = true;
            this.btnGetBySexo.Click += new System.EventHandler(this.btnGetBySexo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 357);
            this.Controls.Add(this.btnGetBySexo);
            this.Controls.Add(this.btnDeletarPersonalidade);
            this.Controls.Add(this.btnAtualizaPersonalidade);
            this.Controls.Add(this.btnIncluirPersonalidade);
            this.Controls.Add(this.btnPersonalidadePorId);
            this.Controls.Add(this.btnOterPersonalidades);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnOterPersonalidades;
        private System.Windows.Forms.Button btnPersonalidadePorId;
        private System.Windows.Forms.Button btnIncluirPersonalidade;
        private System.Windows.Forms.Button btnAtualizaPersonalidade;
        private System.Windows.Forms.Button btnDeletarPersonalidade;
        private System.Windows.Forms.Button btnGetBySexo;
    }
}

