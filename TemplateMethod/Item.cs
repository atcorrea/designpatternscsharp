namespace designpattenscsharp.TemplateMethod
{
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