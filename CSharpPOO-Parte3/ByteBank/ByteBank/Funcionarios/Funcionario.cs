using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //classe de funcionario
    //Classe base da heranca
    //Classe abstratas não podem ser diretamente instanciadas
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //Construtor da classe Funcionario
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        //Comportamento do funcionario (Obter/Get) - Metodo/Função
        //O virtual permite que uma class derivada possa sobrepor ao seu comportamento
        public abstract double GetBonificacao();
    }
}
