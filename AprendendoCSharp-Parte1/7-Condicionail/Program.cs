using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando projeto 7: Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possue mais de 18 anos. Pode entrar...");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possue mais de 18 anos, mas está acompanhado . Pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possue mais de 18 anos, não pode entrar");
                } 
            }


            Console.ReadLine();
        }
    }
}
