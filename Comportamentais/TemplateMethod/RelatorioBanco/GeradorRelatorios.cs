namespace designpattenscsharp.Comportamentais.TemplateMethod.RelatorioBanco
{
    public class GeradorRelatorios
    {
        public void ImprimirRelatorio(Relatorio tipoRelatorio, IEnumerable<Conta> contas)
        {
            Console.WriteLine(tipoRelatorio.GerarRelatorio(contas));
        }
    }
}