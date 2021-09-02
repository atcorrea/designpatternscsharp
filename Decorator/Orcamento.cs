namespace designpattenscsharp.Decorator
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
        }
    }

    public class Item
    {
        public string Nome { get; private set; }
        public int Valor { get; private set; }

        public Item(string nome, int Valor)
        {
            this.Nome = nome;
            this.Valor = Valor;
        }
    }
}