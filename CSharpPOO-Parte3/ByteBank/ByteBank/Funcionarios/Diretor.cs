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
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }
        //Comportamento de sobrepor o Get do funcionario pelo do Diretor (Obter/Get) 
        //Utilizando override para sobrepor o comportamento do metodo getBonificação do funcionario
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
        //Usando base para fezer referencia a membros da classe base.
        
    }
}
