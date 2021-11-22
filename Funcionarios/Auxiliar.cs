using System;

namespace NatBank
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 1800)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.15;
        }
    }
}