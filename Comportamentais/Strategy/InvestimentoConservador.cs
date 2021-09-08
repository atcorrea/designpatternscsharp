namespace designpattenscsharp.Comportamentais.Strategy
{
    class InvestimentoConservador : IEstrategiaInvestimento
    {
        public decimal Render(decimal valorInvestido)
        {
            return valorInvestido * 0.008m;
        }
    }
}
