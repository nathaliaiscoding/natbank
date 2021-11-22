namespace NatBank
{
    public class GerenciadorBonificacao
    {
        public double _totalBonificacao;

        public void RegistrarBonificacao(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }


    }
}