using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando projeto 12 - Calcula investimento");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            //for encadeado, um for dentro do outro.
            for (int contadorAno =1; contadorAno <=5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;

            }

            Console.WriteLine("Ao terminio do investimento você terá R$" + valorInvestido);


            Console.ReadLine();
        }
    }
}
