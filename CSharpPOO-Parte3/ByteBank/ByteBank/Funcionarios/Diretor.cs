using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //A classe Diretor é derivada da classe Funcionario - Chama se Heranca
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base (5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //Comportamento de sobrepor o Get do funcionario pelo do Diretor (Obter/Get) 
        //Utilizando override para sobrepor o comportamento do metodo getBonificação do funcionario
        public override double GetBonificacao()
        {
            return Salario * 0.5;
            //Usando base para fezer referencia a membros da classe base.
        }
    }
}
