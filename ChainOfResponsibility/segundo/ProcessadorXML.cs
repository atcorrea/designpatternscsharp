namespace designpattenscsharp.ChainOfResponsibility.segundo
{
    public class ProcessadorXML : IProcessadorRequisicao
    {
        IProcessadorRequisicao Proximo { get; set; }

        public ProcessadorXML(IProcessadorRequisicao proximo)
        {
            this.Proximo = proximo;
        }

        public string Processar(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
                return $"<Titular>{conta.NomeTitular}</Titular><Saldo>{conta.Saldo}</Saldo>";
    

        return Proximo.Processar(requisicao, conta);
        }
    }
}