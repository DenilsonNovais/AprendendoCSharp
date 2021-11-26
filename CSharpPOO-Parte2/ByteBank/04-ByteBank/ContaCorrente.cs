


//A Class é o molde para se construir o objeto
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //É comum chamar de Função, mas pode ser chamado de método
    public bool Sacar (double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    //É mais comum chamar de Método, mas também é uma função
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }


}


