using System.ComponentModel.DataAnnotations;

namespace NatBank
{
    public class Cliente
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }
        public string Profissao { get; set; }
        [Required]
        public double RendaMensal { get; set; }
        [Required]
        public bool MaiorDeIdade { get; set; }

        public Cliente(string nome, string cpf, double rendaMensal, int idade)
        {
            Nome = nome;
            CPF = cpf;
            RendaMensal = rendaMensal;
            MaiorDeIdade = VerificarMaioridade(idade);
        }

        /// <summary>
        /// Verifica se o cliente é maior de idade, a partir da idade fornecida no método de criação da conta.
        /// </summary>
        /// <param name="idade">Idade do titular da conta</param>
        /// <returns></returns>
        private bool VerificarMaioridade(int idade)
        {
            if (idade < 18)
            {
                return false;
            }
            return true;
        }
    }
}
