using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçõesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando programa 6: Atribuiçoes de Variaveis");

            int idade = 31;
            int idadedenilson = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadedenilson);


            Console.ReadLine();
        }
    }
}
