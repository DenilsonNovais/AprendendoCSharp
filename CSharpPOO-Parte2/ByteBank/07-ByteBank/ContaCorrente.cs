

namespace _07_ByteBank
{
    //A Class é o molde para se construir o objeto
    public class ContaCorrente
    {//O tipo do titular é uma referencia do objeto Cliente
        public Cliente Titular { get; set; }

        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;

            }
        }
        public int Numero { get; set; }

        private double _saldo = 100;

        //Propriedades Get e Set
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //Forma correta de construir objeto da conta corrente
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

                

        //É comum chamar de Função, mas pode ser chamado de método
        public bool Sacar(double valor)
        { //O this se refere à instancia, que envocou o método Sacar
            if (_saldo < valor)
            {
                return false;
            }


            _saldo -= valor;
            return true;

        }

        //É mais comum chamar de Método, mas também é uma função
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }


            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }


    }
}



