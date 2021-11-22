using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_LacoDeRepeticaoWhile
{
    class Program
    {

        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;  //mais usado!;
            }
            Console.ReadLine();


            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

        }



      
    }
}
