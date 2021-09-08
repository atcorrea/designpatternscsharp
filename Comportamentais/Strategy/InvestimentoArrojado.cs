namespace designpattenscsharp.Comportamentais.Strategy
{
    public class InvestimentoArrojado : IEstrategiaInvestimento
    {
        public decimal Render(decimal valorInvestido)
        {
            var chance = new Random().Next(101);

            if (chance <= 20)
                return valorInvestido * 0.05m;
            else if (chance > 20 && chance <= 50)
                return valorInvestido * 0.03m;
            else
                return valorInvestido * 0.006m;
        }
    }
}