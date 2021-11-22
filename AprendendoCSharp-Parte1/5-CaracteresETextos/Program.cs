using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando projeto 5");

            char primeiraletra = 'a';
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)61;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);

            string titulo = "Alura cursos de tecnologia " + 2021;
            Console.WriteLine(titulo);

            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.ReadLine();
        }
    }
}
