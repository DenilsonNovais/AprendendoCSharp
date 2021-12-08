using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //classe de funcionario
    public class Funcionario
    {
        // 0 - Funcionarios | 1 - Diretor | 2 - Designer | N - ...
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //Construtor para o _tipo, campo privado
        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        //Comportamento do funcionario (Obter/Get) - Metodo/Função
        public double GetBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }

            return Salario * 0.10;
        } 
    }
}
