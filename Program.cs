using System;

namespace NatBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CriarConta();
            CriarFuncionarios();
        }
        public static void CriarFuncionarios()
        {
            Diretor diretor = new Diretor("192.889.003-45");
            diretor.Nome = "Roberta";
            diretor.Senha = "123";
            Gerente gerente = new Gerente("139.007.223-10");
            gerente.Nome = "Marcio";
            gerente.Senha = "abc";
            Caixa caixa = new Caixa("102.020.220-10");
            caixa.Nome = "Carla";
            Auxiliar auxiliar = new Auxiliar("778.908.224-23");
            auxiliar.Nome = "Brenda";
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "cba";

            Console.WriteLine($"{diretor.Nome} - Salário: R${diretor.Salario}");
            Console.WriteLine($"{gerente.Nome} - Salário: R${gerente.Salario}");
            Console.WriteLine($"{caixa.Nome} - Salário: R${caixa.Salario}");
            Console.WriteLine($"{auxiliar.Nome} - Salário: R${auxiliar.Salario}");

            SistemaInterno sistema = new SistemaInterno();
            sistema.Logar(diretor, "123");
            sistema.Logar(gerente, "abc");
            sistema.Logar(parceiro, "cba");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            gerenciador.RegistrarBonificacao(diretor);
            gerenciador.RegistrarBonificacao(gerente);
            gerenciador.RegistrarBonificacao(caixa);
            gerenciador.RegistrarBonificacao(auxiliar);

            Console.WriteLine(diretor.Salario);
            Console.WriteLine(gerente.Salario);
            Console.WriteLine(auxiliar.Salario);
            Console.WriteLine(caixa.Salario);
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }

        public static void CriaConta()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Bem-vindo ao NatBank!");
            Console.WriteLine("================================");
            Console.WriteLine("Tecle enter para continuar...");
            Console.ReadLine();
            Console.WriteLine(
                   "Digite [C] para criar uma nova conta ou qualquer outra tecla para sair da aplicação... "
            );
            var resposta = Console.ReadLine();
            if (resposta == "C" || resposta == "c")
            {
                ContaCorrente novaConta = new ContaCorrente();
                novaConta.CriarConta();
                Console.WriteLine("Obrigada por acessar o NatBank!");
            }
            else
            {
                Console.WriteLine("Obrigada por acessar o NatBank!");
                Console.ReadLine();
            }
        }
    }
}
