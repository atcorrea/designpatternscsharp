namespace designpattenscsharp.Comportamentais.TemplateMethod
{
    public class ICMS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}