namespace designpattenscsharp.Builder
{
    public class ItemDaNotaBuilder
    {
        private string descricao;
        private int valor;

        public ItemDaNota Build()
        {
            return new ItemDaNota(descricao, valor);
        }

        public ItemDaNotaBuilder ComDescricao(string descricao)
        {
            this.descricao = descricao;
            return this;
        }
        public ItemDaNotaBuilder ComValor(int valor)
        {
            this.valor = valor;
            return this;
        }
    }
}