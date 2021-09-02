namespace designpattenscsharp.TemplateMethod.RelatorioBanco
{
    public class RelatorioBanco
    {
        public static void Testar()
        {
            var contas = new List<Conta>()
            {
                { new Conta("André", 1, 0) },
                { new Conta("Patricia", 2, 0) },
                { new Conta("Ronaldo", 3, 0) },
                { new Conta("Lourdes", 4, 0) },
                { new Conta("Amanda", 5, 0) },
                { new Conta("Vinicius", 6, 0) },
            };

            contas[0].Depositar(25);
            contas[3].Depositar(100);

            var gerador = new GeradorRelatorios();
            gerador.ImprimirRelatorio(new RelatorioSimples(), contas);
            gerador.ImprimirRelatorio(new RelatorioCompleto(), contas);
        }
    }
}