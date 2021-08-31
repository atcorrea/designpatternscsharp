namespace designpattenscsharp.TemplateMethod
{
    public abstract class ImpostoCondicionalTemplate : Imposto
    {

        public double Calcular(Orcamento orcamento)
        {
            if (DeveAplicarTaxaMaxima(orcamento))
                return ValorTaxaMaxima(orcamento);

            return ValorTaxaMinima(orcamento);
        }

        protected abstract double ValorTaxaMinima(Orcamento orcamento);
        protected abstract double ValorTaxaMaxima(Orcamento orcamento);
        protected abstract bool DeveAplicarTaxaMaxima(Orcamento orcamento);
    }
}