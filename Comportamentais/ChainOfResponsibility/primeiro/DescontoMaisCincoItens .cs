namespace designpattenscsharp.Comportamentais.ChainOfResponsibility.Primeiro
{
    public class DescontoMaisCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public int Descontar(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return 10;

            return Proximo.Descontar(orcamento);
        }
    }
}