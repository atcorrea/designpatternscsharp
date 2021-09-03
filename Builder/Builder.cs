namespace designpattenscsharp.Builder
{
    public class Builder
    {
        public static void Testar()
        {
            var builderNF = new NotaFiscalBuilder();
            var builderItem = new ItemDaNotaBuilder();

            var notaFiscal = builderNF
                .ComCnpj("123456789")
                .ComRazaoSocial("Builder LTDA")
                .ComImpostos(0.02)
                .Com(new ItemDaNota("item1", 3))
                .Com(new ItemDaNota("item2", 6))
                .Com(builderItem.ComDescricao("item3").ComValor(9).Build())
                .ComObservacao("uma observação")
                .Build();
        }
    }
}