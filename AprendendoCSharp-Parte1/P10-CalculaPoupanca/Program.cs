using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando projeto 10");

            double valorinvestido = 1000;
            int contadorMes = 1;

            
            while (contadorMes <= 12)
            {
                // 0.36% = 0.0036
                valorinvestido = valorinvestido + valorinvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, voçê terá R$" + valorinvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }


            Console.ReadLine();
        }
    }
}
