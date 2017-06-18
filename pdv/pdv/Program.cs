using pdv.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            // Ambiente de Desenvolvimento
            IProdutoDAO dao = new ProdutoDAOFake();
            // IProdutoDAO dao = new ProdutoDAO();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PDV(dao));
        }
    }
}
