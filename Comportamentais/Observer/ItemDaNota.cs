namespace designpattenscsharp.Comportamentais.Observer
{
    public class ItemDaNota
    {
        public string Descricao { get; private set; }
        public int Valor { get; private set; }

        public ItemDaNota(string descricao, int Valor)
        {
            this.Descricao = descricao;
            this.Valor = Valor;
        }
    }
}