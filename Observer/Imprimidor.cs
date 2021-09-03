namespace designpattenscsharp.Observer
{
    public class Imprimidor : AcaoGerarNotaFiscal
    {
        public void Executar(NotaFiscal nota)
        {
            Console.WriteLine("imprimindo nota fiscal");
        }
    }
}