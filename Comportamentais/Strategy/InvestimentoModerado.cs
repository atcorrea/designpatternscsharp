namespace designpattenscsharp.Comportamentais.Strategy
{
    public class InvestimentoModerado : IEstrategiaInvestimento
    {
        public decimal Render(decimal valorInvestido)
        {
            var chance = new Random().Next(2);

            if (chance == 0)
                return valorInvestido * 0.025m;

            return valorInvestido * 0.007m;
        }
    }
}