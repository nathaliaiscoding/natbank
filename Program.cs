using System;

namespace NatBank
{
    class Program
    {
        static void Main(string[] args)
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
