using System.Linq;

namespace designpattenscsharp.Comportamentais.TemplateMethod
{
    public class IHIT : ImpostoCondicionalTemplate
    {
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