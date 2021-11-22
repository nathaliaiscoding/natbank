namespace NatBank
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.25;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }


    }
}