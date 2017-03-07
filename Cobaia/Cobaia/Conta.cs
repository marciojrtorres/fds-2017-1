using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobaia
{
    class Conta
    {
        string agencia, numero;

        public Conta(string agencia, string numero)
        {
            this.agencia = agencia;
            this.numero = numero;
        }

        /*
        public string getAgencia() {
            return this.agencia;
        }
        */
        public string Agencia // Propriedade: meio de expor os atributos
        {
            get
            {
                return this.agencia;
            }
        }

        public string Numero
        {
            get
            {
                return this.numero;
            }
        }

    }
}
