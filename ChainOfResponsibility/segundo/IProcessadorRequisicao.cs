namespace designpattenscsharp.ChainOfResponsibility.segundo
{
    public interface IProcessadorRequisicao
    {
        string Processar(Requisicao requisicao, Conta conta);
    }
}