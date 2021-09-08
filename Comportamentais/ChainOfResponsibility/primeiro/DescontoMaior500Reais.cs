namespace designpattenscsharp.Comportamentais.ChainOfResponsibility.Primeiro
{
    public class DescontoMaior500Reais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public int Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return 7;

            return Proximo.Descontar(orcamento);
        }
    }
}