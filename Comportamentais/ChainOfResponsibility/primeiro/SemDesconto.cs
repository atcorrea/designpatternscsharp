namespace designpattenscsharp.Comportamentais.ChainOfResponsibility.Primeiro
{
    public class SemDesconto : IDesconto
    {
        public int Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}