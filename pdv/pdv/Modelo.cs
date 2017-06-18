using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdv.Modelo
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoVenda { get; set; }
        public Unidade Unidade { get; set; }
    }

    public enum Unidade
    {
        UN, KG, MT, LT
    }

    public class Item
    {
        public int Numero { get; set; }
        public Produto Produto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal SubTotal
        {
            get
            {
                return this.Quantidade * this.ValorUnitario;
            }
        }
    }

    public class Venda
    {
        public Venda()
        {
            this.Itens = new List<Item>();
        }
        
        public List<Item> Itens { get; set; }
        // Language INtegrated Query
        public decimal Total
        {
            get
            {
                return      
                    this.Itens
                        .Select(i => i.SubTotal) // Map
                        .Aggregate((a, b) => a + b); // Reduce
            }
        }

        private int num = 1;

        public void Inclui(Produto p, decimal qtd = 1)
        {
            Itens.Add(new Item
            {
                Numero = num++,
                Produto = p,
                Quantidade = qtd,
                ValorUnitario = p.PrecoVenda
            });
        }
    }


}
