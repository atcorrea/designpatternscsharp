namespace designpattenscsharp.Estruturais.Decorator.Banco
{
    public abstract class Filtro
    {
        private readonly Filtro outroFiltro;

        public Filtro(Filtro outroFiltro)
        {
            this.outroFiltro = outroFiltro;
        }
        public Filtro()
        {
        }
        public IEnumerable<Conta> Filtrar(IEnumerable<Conta> contas)
        {
            return AplicarOutroFiltro(contas.Where(c => CondicaoFiltro(c)));
        }

        protected abstract bool CondicaoFiltro(Conta conta);

        private IEnumerable<Conta> AplicarOutroFiltro(IEnumerable<Conta> contas)
        {
            if (outroFiltro != null)
                return outroFiltro.Filtrar(contas);

            return contas;
        }
    }
}