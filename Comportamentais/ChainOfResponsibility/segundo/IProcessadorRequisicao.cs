namespace designpattenscsharp.Comportamentais.ChainOfResponsibility.Segundo
{
    public interface IProcessadorRequisicao
    {
        string Processar(Requisicao requisicao, Conta conta);
    }
}