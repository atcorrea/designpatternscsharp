namespace designpattenscsharp.Decorator
{
    public class Decorator
    {
        public static void Testar()
        {
            var orcamento = new Orcamento(100);
            orcamento.AdicionarItem(new Item("caneta", 100));

            var imposto1 = new IKCV(new ICMS(new ISS()));
            var valorImposto = CalculadorImposto.Calcular(imposto1, orcamento);

            var imposto2 = new ImpostoMuitoAlto(new ICMS(new ISS(new IHIT(new IKCV(new ICPP(new ImpostoMuitoAlto()))))));
            var valorImposto2 = CalculadorImposto.Calcular(imposto2, orcamento);

            Console.WriteLine(valorImposto);
            Console.WriteLine(valorImposto2);
        }
    }
}