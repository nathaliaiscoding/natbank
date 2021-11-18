using System;
using System.ComponentModel.DataAnnotations;

namespace NatBank
{
    public class ContaCorrente
    {
        [Required]
        public Cliente Titular { get; set; }
        [Required]
        public int Agencia { get; set; }
        [Required]
        public int Conta { get; set; }
        public double Saldo { get; set; }
        public double LimiteCredito { get; set; }
        public double LimiteChequeEspecial { get; set; }

        public ContaCorrente()
        {
        }
        public ContaCorrente(Cliente titular, int agencia, int conta)
        {
            Titular = titular;
            Agencia = agencia;
            Conta = conta;
        }
        /// <summary>
        /// Cria uma noma conta corrente, a partir dos dados fornecidos pelo usuário pelo console.
        /// </summary>
        /// <returns>Nova ContaCorrente</returns>
        public ContaCorrente CriarConta()
        {
            Console.WriteLine("Qual o nome do titular da conta?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o CPF do titular da conta?");
            string cpf = Console.ReadLine();
            Console.WriteLine("Qual a média de renda mensal do titular?");
            double rendaMensal = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a idade do titular?");
            int idade = int.Parse(Console.ReadLine());
            bool maior = VerificarMaioridade(idade);
            Cliente titular = new Cliente(nome, cpf, rendaMensal, maior);
            int numConta = GerarNumeroDaConta(10000, 99999);
            ContaCorrente conta = new ContaCorrente(titular, 1, numConta);
            Console.WriteLine("Verifique os dados da conta:");
            Console.WriteLine($"Nome do titular: {nome} - CPF: {cpf} - Média de renda mensal: R$ {rendaMensal} - Idade: {idade} anos");
            Console.WriteLine("Os dados estão corretos?");
            Console.WriteLine("Tecle 'S' para confirmar, 'N' para refazer a operação ou qualquer outra tecla para cancelar.");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
            {
                Console.WriteLine("Conta criada com sucesso!");
                Console.WriteLine("Anote os dados da sua nova conta:");
                Console.WriteLine($"Agência: 0001");
                Console.WriteLine($"Conta Corrente: {numConta}");
            }
            else if (resposta == "n" || resposta == "N")
            {
                CriarConta();
            }
            else
            {
                Console.WriteLine("Operação cancelada, reinicie a aplicação para criar uma nova conta.");
            }
            return conta;
        }

        /// <summary>
        /// Gera um número randômico para a conta, entre 10000 e 99999.
        /// </summary>
        /// <param name="min">Número mínimo de conta.</param>
        /// <param name="max">Número máximo de conta.</param>
        /// <returns>Número da Conta</returns>
        private int GerarNumeroDaConta(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
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
