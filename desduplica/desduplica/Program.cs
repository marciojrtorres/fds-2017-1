using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desduplica
{
    class Program
    {
        static void Main(string[] args)
        {
            // IO: ler/gravar diretórios e arquivos
            // Console.WriteLine(Directory.Exists(path));
            // @"c:\cobaia";            
            var path = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory(); 

            Console.WriteLine("Lendo o diretório " + path);
            var arquivos = Directory.GetFiles(path);

            for (int i = 0; i < arquivos.Length - 1; i++)
            {                
                for (int j = i + 1; j < arquivos.Length; j++)
                {
                    var umInfo = new FileInfo(arquivos[i]);
                    var outroInfo = new FileInfo(arquivos[j]);
                    
                    if (umInfo.Length == outroInfo.Length)
                    {
                        var iguais = true;
                        using (var um = File.Open(arquivos[i], FileMode.Open))
                        using (var outro = File.Open(arquivos[j], FileMode.Open))
                        { 
                            var b = -1;
                            while ((b = um.ReadByte()) != -1)
                            {
                                if (b != outro.ReadByte())
                                {
                                    iguais = false;
                                    break;
                                }
                            }
                        }
                        if (iguais)
                        {
                            Console.WriteLine(arquivos[i] + " e " + arquivos[j] + " sao iguais");
                            Console.Write("Deseja excluir (S/N)?");
                            int resposta = Console.Read();
                            if (resposta == 's' || resposta == 'S')
                            {
                                File.Delete(arquivos[i]);
                                break;
                            }
                        }
                    }
                }
            }

            /*
            foreach (var a in arquivos)
            {
                Console.WriteLine(a);
            }

            var arq = File.ReadAllText(arquivos[0]);
            Console.WriteLine(arq);
            using (var file = File.Open(arquivos[1], FileMode.Open))
            {
                Console.WriteLine(file.Length);
            }
            */
        }
    }
}
