using pdv.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdv.Persistencia
{
    public interface IProdutoDAO
    {
        Produto Busca(int codigo);
    }

    public class ProdutoDAOFake : IProdutoDAO
    {
        public Produto Busca(int codigo)
        {
            Produto p = null;

            if (codigo == 42025)
            {
                p = new Produto
                {
                    Codigo = codigo,
                    Descricao = "Ogro Multiação",
                    PrecoVenda = 9.9M,
                    Unidade = Unidade.UN
                };
            }

            return p;
        }
    }
}
