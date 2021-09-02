namespace designpattenscsharp.Decorator.Banco
{
    public class FiltroPorSaldoAbaixo100Reais : Filtro
    {
        public FiltroPorSaldoAbaixo100Reais()
        {
        }

        public FiltroPorSaldoAbaixo100Reais(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        protected override bool CondicaoFiltro(Conta conta) => conta.Saldo < 100;
    }
}