using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //classe de funcionario
    //Classe base da heranca
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        //Construtor da classe Funcionario
        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;

            TotalDeFuncionarios++;
        }

        //Comportamento do funcionario (Obter/Get) - Metodo/Função
        //O virtual permite que uma class derivada possa sobrepor ao seu comportamento
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        } 
    }
}
