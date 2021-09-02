namespace designpattenscsharp.Decorator.Banco
{
    public class FiltroDataAberturaMesCorrente : Filtro
    {
        public FiltroDataAberturaMesCorrente()
        {
        }

        public FiltroDataAberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        protected override bool CondicaoFiltro(Conta conta) => conta.DataAbertura.Month == DateTime.Now.Month && 
                                                               conta.DataAbertura.Year == DateTime.Now.Year;
    }
}