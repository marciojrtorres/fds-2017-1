using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace buscacep
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var url = string.Format("https://viacep.com.br/ws/{0}/json/", line);
            var req = (HttpWebRequest) HttpWebRequest.Create(url);
            req.Method = "GET";
            var resp = req.GetResponse(); // invocar
            // FAZENDO REQUISICAO WEB

            ViaCep cep = null;

            using (Stream stream = resp.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var str = reader.ReadToEnd();
                // Console.WriteLine(str);
                cep = JsonConvert.DeserializeObject<ViaCep>(str);
            }

            Console.WriteLine("Rua: " + cep.logradouro);
            Console.WriteLine("Bairro: " + cep.bairro);

            // COMO SERIALIZAR/DESERIALIZAR
            // NewtonSoft JSON
            Pet p1 = new Pet
            {
                nome = "Bidu",
                tipo = "Catiorro",
                raca = "Vira-lata"
            };

            var s = JsonConvert.SerializeObject(p1);
            // Console.WriteLine(s);
            
        }

        class Pet
        {
            public string nome { get; set; }
            public string tipo { get; set; }
            public string raca { get; set; }
        }

        class ViaCep
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string unidade { get; set; }
            public int ibge { get; set; }
            public int? gia { get; set; }
        }
    }
}
/*
 * {
  "cep": "96206-410",
  "logradouro": "Rua Antônio Baptista das Neves",
  "complemento": "(Posto Sete e Nove)",
  "bairro": "Cassino",
  "localidade": "Rio Grande",
  "uf": "RS",
  "unidade": "",
  "ibge": "4315602",
  "gia": ""
}
*/