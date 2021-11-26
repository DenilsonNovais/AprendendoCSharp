using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBanck
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.numero = 563;
            conta.agencia = 5634527;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            */

            Pessoa guilherme = new Pessoa();
            guilherme.nome = "Guilherme";
            guilherme.endereco.logradouro = "Avenida XYZ";

            Console.ReadLine();


        }
    }
}
