namespace designpattenscsharp.Estruturais.Decorator
{
    public static class CalculadorImposto
    {
        public static double Calcular(Imposto imposto, Orcamento orcamento)
        {
            return imposto.Calcular(orcamento);
        }
    }
}