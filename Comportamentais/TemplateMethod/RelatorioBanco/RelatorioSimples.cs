using System.Text;

namespace designpattenscsharp.Comportamentais.TemplateMethod.RelatorioBanco
{
    public class RelatorioSimples : Relatorio
    {
        protected override string ObterDadosCabecalho()
        {
            return "Banco DP - 4321-1234";
        }

        protected override string ObterCorpoRelatorio(IEnumerable<Conta> contas)
        {
            var corpo = new StringBuilder("");
            foreach (var conta in contas)
                corpo.AppendLine($"{conta.NomeTitular} - Saldo: {conta.Saldo}");

            return corpo.ToString();
        }

        protected override string ObterDadosRodape()
        {
            return "Banco DP - 4321-1234";
        }
    }
}