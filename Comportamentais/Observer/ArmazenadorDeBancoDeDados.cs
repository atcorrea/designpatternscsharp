namespace designpattenscsharp.Comportamentais.Observer
{
    public class ArmazenadorDeBancoDeDados : AcaoGerarNotaFiscal
    {
        public void Executar(NotaFiscal nota)
        {
            Console.WriteLine("Salvando no banco");
        }
    }
}