namespace designpattenscsharp.Estruturais.Decorator
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto imposto) : base(imposto) { }
        public ICMS() { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalcularOutroImposto(orcamento);
        }
    }
}