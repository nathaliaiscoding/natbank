namespace NatBank
{
    public class Caixa : Funcionario
    {
        public Caixa(string cpf) : base(cpf, 2600)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.2;
        }
    }
}