namespace designpattenscsharp.Estruturais.Decorator
{
    public class ICPP : ImpostoCondicionalTemplate
    {
        public ICPP(Imposto imposto) : base(imposto) { }
        public ICPP() { }

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