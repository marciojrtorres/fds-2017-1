using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaiasqlserver2
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSERT! ORM!
            Cliente c1 = new Cliente
            {
                Nome = "Gustavo Prestes"
            };
            // equivale ao EntityManager do JPA (Java)
            dbEntities db = new dbEntities();
            db.Clientes.Add(c1);

            Console.WriteLine(c1.Id);

            db.SaveChanges();

            Console.WriteLine(c1.Id);

            Pedido p1 = new Pedido
            {
                Descricao = "Um pedido do Gustavo"
            };

            c1.Pedidos.Add(p1);
            p1.Cliente = c1;

            db.SaveChanges();
            // LINQ
            var c2 = db.Clientes.Where(c => c.Nome.StartsWith("a"));
            
            Console.WriteLine(c2.ToList());

            
        }
    }
}
