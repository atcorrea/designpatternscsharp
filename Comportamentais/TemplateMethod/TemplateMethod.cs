namespace designpattenscsharp.Comportamentais.TemplateMethod
{
    public class TemplateMethod
    {
        public static void Testar()
        {
            var orcamento = new Orcamento(100);
            orcamento.AdicionarItem(new Item("caneta", 100));

            var imposto1 = new IKCV();
            var valorImposto = CalculadorImposto.Calcular(imposto1, orcamento);


            var imposto2 = new ICPP();
            var valorImposto2 = CalculadorImposto.Calcular(imposto2, orcamento);

            Console.WriteLine(valorImposto);
            Console.WriteLine(valorImposto2);
        }
    }
}