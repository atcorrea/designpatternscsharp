namespace designpattenscsharp.Comportamentais.Observer
{
    public class NotaFiscalBuilder
    {
        private string razaoSocial;
        private string cnpj;
        private DateTime dataDeEmissao;
        private double ValorBruto;
        private double impostos;
        private readonly IList<ItemDaNota> itens;
        public string observacoes;

        private List<AcaoGerarNotaFiscal> acoesASeremExecutadas = new List<AcaoGerarNotaFiscal>();

        public NotaFiscalBuilder()
        {
            this.itens = new List<ItemDaNota>();
            this.dataDeEmissao = DateTime.Now;
        }

        public NotaFiscal Build()
        {
            var nota = new NotaFiscal(razaoSocial, cnpj, dataDeEmissao, ValorBruto, impostos, itens, observacoes);

            foreach (var acao in acoesASeremExecutadas)
               acao.Executar(nota); 
            
            return nota;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            dataDeEmissao = data;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            itens.Add(item);
            this.ValorBruto += item.Valor;
            return this;
        }

        public NotaFiscalBuilder ComObservacao(string observacao)
        {
            observacoes = observacao;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComImpostos(double impostos)
        {
            this.impostos = impostos;
            return this;
        }

        public NotaFiscalBuilder AdicionarAcao(AcaoGerarNotaFiscal observador)
        {
            this.acoesASeremExecutadas.Add(observador);
            return this;
        }

    }
}