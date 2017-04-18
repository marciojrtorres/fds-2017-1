using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecretoForms
{
    static class ListExtensions
    {
        public static void Shuffle<T>(this List<T> lista)
        {
            Random r = new Random();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                int n = r.Next(i);
                T o = lista[i];
                lista[i] = lista[n];
                lista[n] = o;
            }
        }
    }
}
