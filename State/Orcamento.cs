namespace designpattenscsharp.State
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public IList<Item> Itens { get; private set; }
        public EstadoOrcamento EstadoAtual { get; internal set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
        }

        public void AplicarDescontoExtra()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void Aprovar()
        {
            EstadoAtual.Aprovar(this);
        }

        public void Reprovar()
        {
            EstadoAtual.Reprovar(this);
        }

        public void Finalizar()
        {
            EstadoAtual.Finalizar(this);
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