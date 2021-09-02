namespace designpattenscsharp.Decorator
{
    public abstract class Imposto
    {
        private Imposto outroImposto;
        public Imposto(Imposto imposto)
        {
            this.outroImposto = imposto;
        }

        public Imposto() { }

        public abstract double Calcular(Orcamento orcamento);

        protected virtual double CalcularOutroImposto(Orcamento orcamento)
        {
            if (outroImposto == null)
                return 0;

            return outroImposto.Calcular(orcamento);
        }
    }
}