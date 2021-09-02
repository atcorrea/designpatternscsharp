using System.Linq;

namespace designpattenscsharp.Decorator
{
    public class IHIT : ImpostoCondicionalTemplate
    {
        public IHIT(Imposto imposto) : base(imposto) { }
        public IHIT() { }

        protected override bool DeveAplicarTaxaMaxima(Orcamento orcamento)
        {
            return ExistemDoisItensComMesmoNome(orcamento);
        }

        protected override double ValorTaxaMaxima(Orcamento orcamento)
        {
            return 0.13d + 100;
        }

        protected override double ValorTaxaMinima(Orcamento orcamento)
        {
            return orcamento.Itens.Count;
        }

        private bool ExistemDoisItensComMesmoNome(Orcamento orcamento)
        {
            return orcamento.Itens.Distinct().Count() != orcamento.Itens.Count;
        }
    }
}