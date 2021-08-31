namespace designpattenscsharp.ChainOfResponsibility.segundo
{
    public class ProcessadorCSV : IProcessadorRequisicao
    {
        IProcessadorRequisicao Proximo { get; set; }

        public ProcessadorCSV(IProcessadorRequisicao proximo)
        {
            this.Proximo = proximo;
        }

        public string Processar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
                return $"{conta.NomeTitular},{conta.Saldo}";


            return Proximo.Processar(requisicao, conta);
        }
    }
}