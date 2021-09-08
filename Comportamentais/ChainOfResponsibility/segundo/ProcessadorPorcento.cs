namespace designpattenscsharp.Comportamentais.ChainOfResponsibility.Segundo
{
    public class ProcessadorPorcento : IProcessadorRequisicao
    {
        IProcessadorRequisicao Proximo { get; set; }

        public ProcessadorPorcento(IProcessadorRequisicao proximo)
        {
            this.Proximo = proximo;
        }

        public string Processar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
                return $"{conta.NomeTitular}%{conta.Saldo}";

            if (Proximo == null)
                throw new InvalidOperationException("Formato não encontrado!");

            return Proximo.Processar(requisicao, conta);
        }
    }
}