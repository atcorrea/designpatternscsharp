namespace designpattenscsharp.Observer
{
    public class NotaFiscal
    {
        private string RazaoSocial { get; set; }
        private string Cnpj { get; set; }
        private DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        private double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; private set; }
        public string Observacoes { get; private set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao,
                      double valorBruto, double impostos, IList<ItemDaNota> itens,
                      string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }

        public void Notificar()
        {
        }
    }
}