namespace designpattenscsharp.Decorator.Banco
{
    public class FiltroPorSaldoAcimaDe500MilReais : Filtro
    {
        public FiltroPorSaldoAcimaDe500MilReais()
        {
        }

        public FiltroPorSaldoAcimaDe500MilReais(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        protected override bool CondicaoFiltro(Conta conta) => conta.Saldo > 500_000;
    }
}