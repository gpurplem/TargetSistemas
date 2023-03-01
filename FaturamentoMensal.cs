using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class FaturamentoMensal
    {
        public static void Main()
        {

            List<Valores> valoresJson;

            using (StreamReader r = new StreamReader("dados.json"))
            {
                string json = r.ReadToEnd();
                valoresJson = JsonConvert.DeserializeObject<List<Valores>>(json);
            }

            List<Double> valores = new List<Double>();

            for (int i = 0; i < valoresJson.Count; i++)
            {
                valores.Add(valoresJson.ElementAt(i).valor);
            }

            valores.Sort();

            for (int i = 0; i < valores.Count; i++)
            {
                if (valores.ElementAt(i) != 0)
                {
                    Console.WriteLine("O menor valor é: " + valores.ElementAt(i));
                    break;
                }
            }

            Console.WriteLine("O maior valor é: " + valores.ElementAt(valores.Count - 1));

            valores.RemoveAll(valor => valor == 0);
            Double soma = 0;
            for (int i = 0; i < valores.Count; i++)
            {
                soma += valores[i];
            }
            Double media = soma / valores.Count;

            int contador = 0;
            for (int i = 0; i < valores.Count; i++)
            {
                if (valores[i] > media) contador++;
            }

            Console.WriteLine("Dias em que faturamento foi maior que média mensal: " + contador);
        }

        public class Valores
        {
            public int dia;
            public double valor;
        }
    }
}
