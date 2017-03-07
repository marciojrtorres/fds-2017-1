using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobaia
{
    // classes de dados
    class Dependente
    {
        int idade;

        public string Nome { get; set; }

        public int Idade
        {
            get
            {
                return this.idade;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("idade inválida: não pode ser negativo");

                this.idade = value;
            }
        }
    }
}
