namespace designpattenscsharp.Strategy
{
    public interface IEstrategiaInvestimento
    {
        decimal Render(decimal valorInvestido);
    }
}