using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando projeto 3: Criando Variaveis ponto Flutuante");

            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            double idade;
            idade = 17 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine(idade);

            idade = 5.3 / 3;
            Console.WriteLine(idade);

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            int dia = 4;
            int outroDia = 4 + dia;
            Console.WriteLine(outroDia);

            double preco = 5.5;
            int ingressos = 4;
            Console.WriteLine(preco * ingressos);

            Console.WriteLine("A execução acabou, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
