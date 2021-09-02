using System.Text;

namespace designpattenscsharp.TemplateMethod.RelatorioBanco
{
    public class RelatorioCompleto : Relatorio
    {
        protected override string ObterDadosCabecalho()
        {
            return "Banco DP - Rua Design Patterns 123 - TEL: 4321-1234";
        }

        protected override string ObterCorpoRelatorio(IEnumerable<Conta> contas)
        {
            var corpo = new StringBuilder("");
            foreach (var conta in contas)
                corpo.AppendLine($"{conta.NomeTitular} [Agencia {conta.Agencia} Conta {conta.Numero}] - Saldo: {conta.Saldo}");

            return corpo.ToString();
        }

        protected override string ObterDadosRodape()
        {
            var data = DateTime.Now;
            return $"contato@bancodp.com.br - {data.Day}/{data.Month}/{data.Year}";
        }
    }
}