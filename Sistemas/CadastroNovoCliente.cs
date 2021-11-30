using System;
using NatBank.Contas;

namespace NatBank.Sistemas
{
    public class CadastroNovoCliente
    {
        public Cliente Cliente { get; set; }

        public CadastroNovoCliente(Cliente cliente, Conta conta)
        {
            Cliente = cliente;
            CadastraDados(cliente, conta);
            cliente.MaiorDeIdade = VerificarMaioridade(cliente.Idade);
        }

        private void CadastraDados(Cliente cliente, Conta conta)
        {
            Console.Write("Digite o seu CPF: ");
            cliente.CPF = Console.ReadLine();
            Console.Write("Digite o seu nome completo: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            cliente.Idade = Convert.ToByte(Console.ReadLine());
            ConfirmarEmail(cliente);
            Console.Write("Digite o nome completo da sua mãe: ");
            cliente.NomeCompletoMae = Console.ReadLine();
            Console.Write("Digite o seu CEP: ");
            cliente.CEP = Console.ReadLine();
            Console.Write("Digite a rua: ");
            cliente.EnderecoRua = Console.ReadLine();
            Console.Write("Digite o número: ");
            cliente.EnderecoNumero = Console.ReadLine();
            Console.Write("Digite o complemento: ");
            cliente.EnderecoComplemento = Console.ReadLine();
            Console.Write("Digite o bairro: ");
            cliente.EnderecoBairro = Console.ReadLine();
            Console.Write("Digite a cidade: ");
            cliente.EnderecoCidade = Console.ReadLine();
            Console.Write("Digite o seu estado: ");
            cliente.EnderecoEstado = Console.ReadLine();
            cliente.Endereco = $"{cliente.EnderecoRua} {cliente.EnderecoNumero} {cliente.EnderecoComplemento} - {cliente.EnderecoBairro} - {cliente.EnderecoCidade}/{cliente.EnderecoEstado} - {cliente.CEP}";
            Console.Write("Crie sua senha de 6 dígitos numéricos: ");
            cliente.Senha = Convert.ToInt32(Console.ReadLine());
            ConfirmarSenha(cliente.Senha);
            Console.Write("Digite o número do DDD do seu celular: ");
            cliente.CelularDDD = Convert.ToByte(Console.ReadLine());
            Console.Write("Digite o número seu celular: ");
            cliente.CelularNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a sua renda mensal: ");
            cliente.RendaMensal = Convert.ToDouble(Console.ReadLine());
            ConfirmarEnderecoEntrega(cliente);
            cliente.Conta = conta;
        }

        private void ConfirmarEnderecoEntrega(Cliente cliente)
        {
            Console.WriteLine("O endereço de entrega dos cartões será o mesmo cadastrado? [S] Sim [N] Não, cadastrar outro endereço.");
            char resposta = Convert.ToChar(Console.ReadLine());

            if (resposta == 'N' || resposta == 'n')
            {
                Console.WriteLine("Digite o endereço de entrega completo, com CEP.");
                string enderecoEntrega = Console.ReadLine();
                cliente.EnderecoEntrega = enderecoEntrega;
            }
            else if (resposta == 'S' || resposta == 's')
            {
                cliente.EnderecoEntrega = cliente.Endereco;
            }
            else
            {
                Console.WriteLine("Escolha uma resposta válida!");
                ConfirmarEnderecoEntrega(cliente);
            }
        }



        private void ConfirmarSenha(int senha)
        {
            Console.Write("Confirme a sua senha: ");
            int confirmaSenha = Convert.ToInt32(Console.ReadLine());
            if (senha != confirmaSenha)
            {
                Console.WriteLine("As senhas não coincidem...");
                ConfirmarSenha(senha);
            }
            else
            {
                return;
            }
        }

        private void ConfirmarEmail(Cliente cliente)
        {
            Console.Write("Digite o seu e-mail: ");
            cliente.Email = Console.ReadLine();
            Console.Write("Confirme o seu e-mail: ");
            string confirmaEmail = Console.ReadLine();
            if (cliente.Email != confirmaEmail)
            {
                Console.WriteLine("Os e-mails não coincidem...");
                ConfirmarEmail(cliente);
            }
            else
            {
                return;
            }

        }


        /// <summary>
        /// Verifica se o cliente é maior de idade, a partir da idade fornecida no método de criação da conta.
        /// </summary>
        /// <param name="idade">Idade do titular da conta</param>
        /// <returns></returns>
        private bool VerificarMaioridade(byte idade)
        {
            if (idade < 18)
            {
                return false;
            }
            return true;
        }
    }
}
