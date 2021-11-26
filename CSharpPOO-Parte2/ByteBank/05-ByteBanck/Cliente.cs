using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBanck
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;
    }

    public class Pessoa
    {
        public string nome;
        public string cpf;
        public int idade;
        public Endereco endereco;
    }

    public class Empresa
    {
        public string razaoSocial;
        public string cnpjs;
        public Endereco endereco;
    }

    public class Endereco
    {
        public string logradouro;
        public int numero;
        public string bairro;
        public string cidade;
        public string estado;
        public string cep;
    }
}
