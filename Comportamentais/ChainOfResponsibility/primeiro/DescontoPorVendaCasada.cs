namespace designpattenscsharp.Comportamentais.ChainOfResponsibility.Primeiro
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public int Descontar(Orcamento orcamento)
        {
            var temItemQualificador = false;
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome == "LAPIS" || item.Nome == "CANETA")
                {
                    temItemQualificador = true;
                    break;
                }
            }

            if (temItemQualificador)
                return 5;

            return Proximo.Descontar(orcamento);
        }
    }
}