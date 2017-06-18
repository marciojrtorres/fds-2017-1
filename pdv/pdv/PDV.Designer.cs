namespace pdv
{
    partial class PDV
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
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbPrecoUnitario = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCupom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.White;
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricao.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(13, 13);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ReadOnly = true;
            this.tbDescricao.Size = new System.Drawing.Size(617, 51);
            this.tbDescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço Unitário";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 41);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.BackColor = System.Drawing.Color.White;
            this.tbQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantidade.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidade.Location = new System.Drawing.Point(13, 173);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(130, 41);
            this.tbQuantidade.TabIndex = 6;
            this.tbQuantidade.Text = "1";
            this.tbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrecoUnitario
            // 
            this.tbPrecoUnitario.BackColor = System.Drawing.Color.White;
            this.tbPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoUnitario.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoUnitario.Location = new System.Drawing.Point(13, 244);
            this.tbPrecoUnitario.Name = "tbPrecoUnitario";
            this.tbPrecoUnitario.ReadOnly = true;
            this.tbPrecoUnitario.Size = new System.Drawing.Size(284, 41);
            this.tbPrecoUnitario.TabIndex = 7;
            this.tbPrecoUnitario.Text = "R$ 0,00";
            this.tbPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.BackColor = System.Drawing.Color.White;
            this.tbSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubTotal.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(13, 327);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(284, 41);
            this.tbSubTotal.TabIndex = 8;
            this.tbSubTotal.Text = "R$ 0,00";
            this.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.White;
            this.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotal.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(346, 318);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(284, 51);
            this.tbTotal.TabIndex = 10;
            this.tbTotal.Text = "R$ 0,00";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // tbCupom
            // 
            this.tbCupom.BackColor = System.Drawing.Color.White;
            this.tbCupom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCupom.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCupom.Location = new System.Drawing.Point(346, 115);
            this.tbCupom.Multiline = true;
            this.tbCupom.Name = "tbCupom";
            this.tbCupom.ReadOnly = true;
            this.tbCupom.Size = new System.Drawing.Size(284, 197);
            this.tbCupom.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Código Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Qtd    Unidade   Valor Unit  Sub-total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "F8: Inicia Venda";
            // 
            // PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 406);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCupom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.tbPrecoUnitario);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescricao);
            this.KeyPreview = true;
            this.Name = "PDV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PDV_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PDV_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PDV_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbPrecoUnitario;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCupom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

