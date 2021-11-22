using System;

namespace NatBank
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine($"Seja bem-vindo(a) ao sistema do NatBank!");
                return true;
            }
            else
            {
                Console.WriteLine($"Senha incorreta! Tente novamente.");
                return true;
            }
        }
    }
}