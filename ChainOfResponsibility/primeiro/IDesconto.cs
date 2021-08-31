namespace designpattenscsharp.ChainOfResponsibility
{
    public interface IDesconto
    {
        int Descontar(Orcamento orcamento);
    }
}