namespace NatBank
{
    public abstract class Funcionario
    {
        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}