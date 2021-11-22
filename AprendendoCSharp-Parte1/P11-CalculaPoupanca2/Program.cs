using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eecultando projeto 11 - Calcula Poupança 2");

            double valorInvestido = 1000;

            //Declara-se a variavel, Define a expressao boleana, Após a execução o contadoer é encrementado 
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, voçê terá R$" + valorInvestido);
            }



            Console.ReadLine();
        }
    }
}
