using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class inverter
    {
        public static void Main()
        {
            Console.WriteLine("Digite uma string: ");
            String entrada = Console.ReadLine();

            char[] caracteres = entrada.ToCharArray();
            char[] caracteresInvertidos = new char[caracteres.Length];

            for(int i = 0, j = caracteres.Length - 1; i<caracteres.Length; i++, j--)
            {
                caracteresInvertidos[j] = caracteres[i];
            }

            Console.WriteLine("String invertida: ");
            foreach(char c in caracteresInvertidos)
            {
                Console.Write(c);
            }
        }
    }
}