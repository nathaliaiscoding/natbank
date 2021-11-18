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

        public Cliente(string nome, string cpf, double rendaMensal, bool maiorDeIdade)
        {
            Nome = nome;
            CPF = cpf;
            RendaMensal = rendaMensal;
            MaiorDeIdade = maiorDeIdade;
        }

        // POST
        // GET 
        // PUT
        // DELETE

    }
}
