using NatBank.Contas;

namespace NatBank
{
    public class Cliente
    {
        // public bool AceitaTermos { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public byte Idade { get; set; }
        public string Email { get; set; }
        public string NomeCompletoMae { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string EnderecoRua { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoEstado { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoEntrega { get; set; }
        public int Senha { get; set; }
        public byte CelularDDD { get; set; }
        public int CelularNumero { get; set; }
        public double RendaMensal { get; set; }
        public bool MaiorDeIdade { get; set; }
        public Conta Conta { get; set; }
        public Cliente()
        {
        }

    }
}
