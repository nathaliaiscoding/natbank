namespace NatBank
{
    public class Gerente : FuncionarioAutenticavel
    {
        public Gerente(string cpf) : base(cpf, 3800)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.2;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.3;
        }
    }
}