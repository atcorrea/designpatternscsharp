namespace designpattenscsharp.Comportamentais.Observer
{
    public class EnviadorDeEmail : AcaoGerarNotaFiscal
    {
        public void Executar(NotaFiscal nota)
        {
            Console.WriteLine("enviando email");
        }
    }
}