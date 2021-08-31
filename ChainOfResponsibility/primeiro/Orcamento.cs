
namespace designpattenscsharp.ChainOfResponsibility
{
    public class Orcamento
    {
        public decimal Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(decimal valor)
        {
            this.Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
        }
    }
}