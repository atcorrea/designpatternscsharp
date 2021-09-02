namespace designpattenscsharp.Decorator
{
    public abstract class ImpostoCondicionalTemplate : Imposto
    {
        public ImpostoCondicionalTemplate(Imposto imposto) : base(imposto) { }
        public ImpostoCondicionalTemplate() { }

        public override double Calcular(Orcamento orcamento)
        {
            if (DeveAplicarTaxaMaxima(orcamento))
                return ValorTaxaMaxima(orcamento) + CalcularOutroImposto(orcamento);

            return ValorTaxaMinima(orcamento) + CalcularOutroImposto(orcamento);
        }

        protected abstract double ValorTaxaMinima(Orcamento orcamento);
        protected abstract double ValorTaxaMaxima(Orcamento orcamento);
        protected abstract bool DeveAplicarTaxaMaxima(Orcamento orcamento);
    }
}