using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 2, 7, 105, 14, 19, 38, 9 };
            lista = lista.OrderBy(i => i).ToList();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();
        }
    }
}
