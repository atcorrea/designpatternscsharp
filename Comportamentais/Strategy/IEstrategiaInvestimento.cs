namespace designpattenscsharp.Comportamentais.Strategy
{
    public interface IEstrategiaInvestimento
    {
        decimal Render(decimal valorInvestido);
    }
}