namespace designpattenscsharp.Comportamentais.Observer
{
    public class Observer
    {
        public static void Testar()
        {
            var builderNF = new NotaFiscalBuilder();

            builderNF.AdicionarAcao(new Imprimidor())
                     .AdicionarAcao(new EnviadorDeEmail())
                     .AdicionarAcao(new ArmazenadorDeBancoDeDados())
                     .AdicionarAcao(new Multiplicador(5));

            var notaFiscal = builderNF
                .ComCnpj("123456789")
                .ComRazaoSocial("Builder LTDA")
                .ComImpostos(0.02)
                .Com(new ItemDaNota("item1", 3))
                .Com(new ItemDaNota("item2", 6))
                .ComObservacao("uma observação")
                .Build();
        }
    }
}