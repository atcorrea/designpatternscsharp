namespace designpattenscsharp.Decorator
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }
        public ImpostoMuitoAlto() { }

        public override double Calcular(Orcamento orcamento)
        {
            return 0.2 + CalcularOutroImposto(orcamento);
        }
    }
}