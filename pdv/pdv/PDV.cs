using pdv.Modelo;
using pdv.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv
{
    public partial class PDV : Form
    {
        IProdutoDAO dao;
        Venda venda;

        public PDV()
        {
            InitializeComponent();
        }

        public PDV(IProdutoDAO dao) : this()
        { 
            this.dao = dao;
        }

        private void PDV_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            // tbDescricao.Text += e.KeyChar;
        }

        private void textBox1_KeyUp(object sender, 
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Produto p = 
                    dao.Busca(int.Parse(textBox1.Text));
                venda.Inclui(p, decimal.Parse(tbQuantidade.Text));
                atualizaTela();
            }            
        }

        private void atualizaTela()
        {
            tbSubTotal.Text = 
                venda.Itens.Last().SubTotal.ToString("C");
            tbPrecoUnitario.Text =
                venda.Itens.Last().ValorUnitario.ToString("C");
            tbDescricao.Text =
                venda.Itens.Last().Produto.Descricao;
            tbTotal.Text = venda.Total.ToString("C");

            tbCupom.Clear();
            foreach (var item in venda.Itens)
            {
                tbCupom.Text += item.Numero + "  "
                    + item.Produto.Descricao + "\n"
                    + item.Quantidade + "   "
                    + item.Produto.Unidade + "   "            
                    + item.ValorUnitario.ToString("C") + "  "
                    + item.SubTotal + "\n";
            }
        }

        private void textBox1_KeyDown(object sender, 
            KeyEventArgs e)
        {
                
        }

        private void PDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void PDV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                venda = new Venda();
                MessageBox.Show(this, "Venda Iniciada");
            }
        }
    }
}
