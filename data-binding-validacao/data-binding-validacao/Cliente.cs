using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_binding_validacao
{
    public class Cliente
    {
        // numérico positivo
        public int Codigo { get; set; }
        // entre 5 e 50 caracteres
        public string Nome { get; set; }
        // 11 números (sem formato)        
        public string CPF { get; set; }
        // formato #####-###
        public string CEP { get; set; }
        // data no passado
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}",
                Codigo, Nome, CPF, CEP, DataNascimento);
        }
    }
}
