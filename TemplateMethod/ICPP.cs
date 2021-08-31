namespace designpattenscsharp.TemplateMethod
{
    public class ICPP : ImpostoCondicionalTemplate
    {
        protected override bool DeveAplicarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        protected override double ValorTaxaMaxima(Orcamento orcamento)
        {
            return 0.07d;
        }

        protected override double ValorTaxaMinima(Orcamento orcamento)
        {
            return 0.05d;
        }
    }
}