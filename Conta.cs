using System;
using NatBank.Sistemas;

namespace NatBank.Contas
{
    public class Conta
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double SaldoCorrente { get; set; }
        public double SaldoPoupanca { get; set; }


        public Conta()
        {
        }
        public Conta(Cliente titular, int agencia, int conta)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = conta;
        }
        /// <summary>
        ///     Cria uma noma conta corrente, a partir dos dados fornecidos pelo usuário pelo console.
        /// </summary>
        /// <returns>Nova Conta</returns>
        public Conta CriarConta()
        {
            Cliente titular = new Cliente();
            int numConta = GerarNumeroDaConta(10000, 99999);
            Conta conta = new Conta(titular, 1, numConta);
            CadastroNovoCliente cadastro = new CadastroNovoCliente(titular, conta);
            VerificarDadosDaConta(titular, conta);
            return conta;
        }

        /// <summary>
        ///     Verifica os dados inseridos para a criação da conta.
        /// </summary>
        /// <param name="titular">Cliente titular da conta que está sendo criada.</param>
        /// <param name="conta">Conta corrente que está sendo criada para o titular.</param>
        private void VerificarDadosDaConta(Cliente titular, Conta conta)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Verifique os dados da sua nova conta:");
            Console.WriteLine("========================================");
            Console.WriteLine($"Nome do titular: {titular.Nome}");
            Console.WriteLine($"CPF: {titular.CPF}");
            Console.WriteLine($"Idade: {titular.Idade} anos");
            string maior = titular.MaiorDeIdade ? "Sim" : "Não";
            Console.WriteLine($"Maior de Idade: {maior}");
            Console.WriteLine($"E-mail: {titular.Email}");
            Console.WriteLine($"Endereço: {titular.Endereco}");
            Console.WriteLine($"Endereço de entrega do cartão: {titular.EnderecoEntrega}");
            Console.WriteLine($"Celular: ({titular.CelularDDD}){titular.CelularNumero}");
            Console.WriteLine($"Renda Mensal: {titular.RendaMensal}");
            Console.WriteLine("Os dados estão corretos?");
            Console.WriteLine("Tecle 'S' para confirmar, 'N' para refazer a operação ou qualquer outra tecla para cancelar.");
            char resposta = Convert.ToChar(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Conta criada com sucesso!");
                Console.WriteLine("Anote os dados da sua nova conta:");
                Console.WriteLine($"Agência: 0001");
                Console.WriteLine($"Conta Corrente: {conta.Numero}");
            }
            else if (resposta == 'n' || resposta == 'N')
            {
                CriarConta();
            }
            else
            {
                Console.WriteLine("Operação cancelada, reinicie a aplicação para criar uma nova conta.");
            }

        }

        /// <summary>
        ///     Gera um número randômico para a conta, entre 10000 e 99999.
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
        ///     Tenta retirar dinheiro da conta: se o saldo for maior ou igual à R$ 1,00, realiza a operação.
        /// </summary>
        /// <param name="valor">Valor a ser sacado.</param>
        /// <returns>Valor booleano para verificar se a operação foi bem sucedida.</returns>
        public bool Sacar(int valor)
        {
            if (SaldoCorrente <= 0)
            {
                Console.WriteLine($"Não é possível realizar o saque! Saldo atual: R$ {SaldoCorrente}");
                return false;
            }
            else
            {
                SaldoCorrente += valor;
                Console.WriteLine("Operação realizada com sucesso!");
                return true;
            }
        }

        /// <summary>
        ///     Deposita dinheiro na conta.
        /// </summary>
        /// <param name="valor">Valor a ser acrescido ao saldo da conta.</param>
        public void Depositar(int valor)
        {
            SaldoCorrente += valor;
            Console.WriteLine("Operação realizada com sucesso!");
        }

        /// <summary>   
        ///     Tenta transferir dinheiro da conta: se o saldo for maior ou igual à R$ 1,00, realiza a operação.
        /// </summary>
        /// <param name="valor">Valor a ser transferido.</param>
        /// <param name="contaDestino">Conta para a qual o valor será transferido.</param>
        /// <returns>Valor booleano para verificar se a operação foi bem sucedida.</returns>
        public bool Transferir(int valor, Conta contaDestino)
        {
            if (SaldoCorrente <= 0)
            {
                Console.WriteLine($"Não é possível realizar a transferência! Saldo atual: R$ {SaldoCorrente}");
                return false;
            }
            else
            {
                SaldoCorrente -= valor;
                contaDestino.SaldoCorrente += valor;
                Console.WriteLine("Operação realizada com sucesso!");
                return true;
            }
        }

        public bool PagarBoleto()
        {
            Console.WriteLine("Digite o código do boleto: ");
            string codigo = Console.ReadLine();
            Console.WriteLine("Digite o valor a pagar: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (SaldoCorrente <= valor)
            {
                Console.WriteLine($"Não é possível realizar o pagamento! Saldo insuficiente.\nSaldo atual: R$ {SaldoCorrente}");
                return false;
            }
            else
            {
                SaldoCorrente -= valor;
                Console.WriteLine("Operação realizada com sucesso!");
                return true;
            }
        }
    }
}

