using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando projeto 4");

            double salario = 1200.50;
            Console.WriteLine(salario);

            // O INT é uma variavel que suporta valores até 32 bits
            int salarioInt = (int)salario;
            Console.WriteLine(salarioInt);

            // O Long é uma variavel de 64 bits
            long idadeMundo = 13000000000000;
            Console.WriteLine(idadeMundo);

            // O Short é um tipo de variavel de 16 bits
            short qtdProduto = 1500;
            Console.WriteLine(qtdProduto);

            float altura = 1.70f;
            Console.WriteLine(altura);


            
            Console.ReadLine();
        }
    }
}
