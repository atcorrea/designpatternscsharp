namespace designpattenscsharp.TemplateMethod.RelatorioBanco
{
    public abstract class Relatorio
    {
        public string GerarRelatorio(IEnumerable<Conta> contas) 
        {
            return $@"
            {ObterDadosCabecalho()}
            -------------------
            {ObterCorpoRelatorio(contas)}
            -------------------
            {ObterDadosRodape()}
            ";
        }

        protected abstract string ObterDadosRodape();
        protected abstract string ObterCorpoRelatorio(IEnumerable<Conta> contas);
        protected abstract string ObterDadosCabecalho();
    }
}