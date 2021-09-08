namespace designpattenscsharp.Comportamentais.State
{
    public class State
    {
        public static void Testar()
        {
            var orcamento = new Orcamento(100);
            orcamento.AdicionarItem(new Item("caneta", 100));
            orcamento.AdicionarItem(new Item("banana", 100));

            orcamento.AplicarDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Aprovar();

            orcamento.AplicarDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Finalizar();

            orcamento.AplicarDescontoExtra();

            //2
            var orcamento2 = new Orcamento(1000);

            orcamento2.AplicarDescontoExtra();
            orcamento2.AplicarDescontoExtra();
        }
    }
}