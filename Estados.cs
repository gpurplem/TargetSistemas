using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Estados
    {
        public static void Main()
        {
            Double[] valores = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
            Double soma = 0;
            for(int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            String[] estados = { "SP", "RJ", "MG", "ES", "Outros" };

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(estados[i] + ": " + String.Format("{0:0.00}", (valores[i] / soma) * 100) + "%");
            }
        }
    }
}