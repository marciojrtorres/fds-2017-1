namespace AmigoSecretoForms
{
    partial class Form1
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbParticipantes = new System.Windows.Forms.ListBox();
            this.btSortear = new System.Windows.Forms.Button();
            this.lbSorteados = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(13, 40);
            this.tbNome.MaxLength = 15;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 0;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(13, 66);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btAdicionar.TabIndex = 1;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amigo(a):";
            // 
            // lbParticipantes
            // 
            this.lbParticipantes.FormattingEnabled = true;
            this.lbParticipantes.Location = new System.Drawing.Point(128, 21);
            this.lbParticipantes.Name = "lbParticipantes";
            this.lbParticipantes.Size = new System.Drawing.Size(121, 212);
            this.lbParticipantes.TabIndex = 3;
            // 
            // btSortear
            // 
            this.btSortear.Location = new System.Drawing.Point(255, 21);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(75, 68);
            this.btSortear.TabIndex = 4;
            this.btSortear.Text = "Sortear";
            this.btSortear.UseVisualStyleBackColor = true;
            this.btSortear.Click += new System.EventHandler(this.btSortear_Click);
            // 
            // lbSorteados
            // 
            this.lbSorteados.FormattingEnabled = true;
            this.lbSorteados.Location = new System.Drawing.Point(337, 21);
            this.lbSorteados.Name = "lbSorteados";
            this.lbSorteados.Size = new System.Drawing.Size(123, 212);
            this.lbSorteados.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remover Selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(467, 21);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(96, 52);
            this.btCopiar.TabIndex = 7;
            this.btCopiar.Text = "Copiar para Área de Transferência";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(467, 80);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(96, 58);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar em Arquivo";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 241);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSorteados);
            this.Controls.Add(this.btSortear);
            this.Controls.Add(this.lbParticipantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.tbNome);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Amigo Secreto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbParticipantes;
        private System.Windows.Forms.Button btSortear;
        private System.Windows.Forms.ListBox lbSorteados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.Button btSalvar;
    }
}

