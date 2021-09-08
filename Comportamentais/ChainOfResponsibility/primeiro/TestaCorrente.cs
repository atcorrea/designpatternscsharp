namespace designpattenscsharp.Comportamentais.ChainOfResponsibility.Primeiro
{
    public class TestaCorrente
    {
        public static void Main(string[] args)
        {
            var d1 = new DescontoMaisCincoItens();
            var d2 = new DescontoMaior500Reais();
            var d3 = new DescontoPorVendaCasada();
            var d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;


            var orcamento = new Orcamento(200);
            orcamento.AdicionarItem(new Item("ps4", 1000));
            orcamento.AdicionarItem(new Item("xbox", 2000));
            orcamento.AdicionarItem(new Item("água", 5));
            orcamento.AdicionarItem(new Item("boneco", 200));
            orcamento.AdicionarItem(new Item("LAPIS", 500));

            var desconto = d1.Descontar(orcamento);
            Console.WriteLine($"Valor desconto: {desconto}");
        }
    }
}