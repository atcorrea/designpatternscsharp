namespace designpattenscsharp.Comportamentais.TemplateMethod
{
    public class IKCV : ImpostoCondicionalTemplate
    {
        protected override bool DeveAplicarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamentoContemItemComValorMaiorQue100(orcamento);
        }

        protected override double ValorTaxaMaxima(Orcamento orcamento)
        {
            return 0.1d;
        }

        protected override double ValorTaxaMinima(Orcamento orcamento)
        {
            return 0.06d;
        }
        private bool orcamentoContemItemComValorMaiorQue100(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
                if (item.Valor > 100) return true;

            return false;
        }
    }
}