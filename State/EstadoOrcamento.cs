namespace designpattenscsharp.State
{
    public abstract class EstadoOrcamento
    {
        protected bool descontoFoiAplicado;

        public abstract void AplicarDescontoExtra(Orcamento orcamento);

        public abstract void Aprovar(Orcamento orcamento);

        public abstract void Reprovar(Orcamento orcamento);

        public abstract void Finalizar(Orcamento orcamento);
    }
}