using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //O projeto class transformado em um objeto -Instancia da Class ContaCorrente
            ContaCorrente contaDaGabriela = new ContaCorrente();

            //Declarando valor ao objeto
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;



            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
