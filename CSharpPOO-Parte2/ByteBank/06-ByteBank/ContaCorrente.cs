

namespace _06_ByteBank
{
    //A Class é o molde para se construir o objeto
    public class ContaCorrente
    {//O tipo do titular é uma referencia do objeto Cliente
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            
            
            this.saldo = saldo;
            
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        //É comum chamar de Função, mas pode ser chamado de método
        public bool Sacar(double valor)
        { //O this se refere à instancia, que envocou o método Sacar
            if (saldo < valor)
            {
                return false;
            }


            saldo -= valor;
            return true;

        }

        //É mais comum chamar de Método, mas também é uma função
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }


            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }


    }
}



