namespace designpattenscsharp.Estruturais.Decorator
{
    public class ISS : Imposto
    {
        public ISS(Imposto imposto) : base(imposto) { }
        public ISS() { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalcularOutroImposto(orcamento);
        }
    }
}