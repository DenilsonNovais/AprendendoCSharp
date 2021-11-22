using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 2: Criando Variaveis");

            int Idade;
            Idade = 32;
            Console.WriteLine(Idade);

            Idade = 10 + 5;
            Console.WriteLine(Idade);

            Idade = 10 + 5 * 2;
            Console.WriteLine(Idade);

            Idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + Idade);

            Console.WriteLine("Execução finalizada, tecle enter para finalizar");

            Console.ReadLine();
        }
    }
}
