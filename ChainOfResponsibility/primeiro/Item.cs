namespace designpattenscsharp.ChainOfResponsibility
{
    public class Item
    {
        public string Nome { get; private set; }
        public int Valor { get; private set; }

        public Item(string nome, int valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}