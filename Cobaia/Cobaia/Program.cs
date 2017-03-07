using System;
using System.Collections.Generic;
// using System.Linq; // import System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobaia // package Cobaia;
{

    class Cliente
    {
        public int id; // atributos
        public string nome;
        public string cpf;
        /*
        @Override
        public String toString()
        {
            return "id: " + id;
        }
        */
        public override string ToString()
        {
            return string.Format("id: {0}, nome: {1}, cpf: {2}", id, nome, cpf);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // System.out.println("Hello World");
            Console.WriteLine("Hello World");

            // uint x = 4000000000; > 2.148 milhões
            // Int32 x = 2;
            int x = 2;
            // Int64 y = 3;
            long y = 3;

            String nome = "marcio";
            string sobrenome = "torres";

            int z = int.Parse("8");
            // System.out.println(nome.toUpperCase());
            Console.WriteLine(nome.ToUpper());

            Cliente c1 = new Cliente();
            c1.id = 1;
            c1.nome = "Teste";
            c1.cpf = "12345678901";

            Console.WriteLine(c1);

            Conta c2 = new Conta("22856-7", "12345-6");
            Console.WriteLine(c2.Agencia);
            Console.WriteLine(c2.Numero);

            Dependente d1 = new Dependente();
            d1.Nome = "Maria";
            // d1.Idade = -1;

            Cliente meuCliente = new Cliente();
            meuCliente.nome = "sdfsdf";
            meuCliente.cpf = "w23423423";
            
            Dependente d2 = new Dependente // Inicializador
            {
                Nome = "Laura",
                Idade = 25
            };


        }
    }
}
