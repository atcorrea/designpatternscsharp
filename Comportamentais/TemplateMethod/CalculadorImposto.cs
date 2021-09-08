namespace designpattenscsharp.Comportamentais.TemplateMethod
{
    public static class CalculadorImposto
    {
        public static double Calcular(Imposto imposto, Orcamento orcamento)
        {
            return imposto.Calcular(orcamento);
        }
    }
}