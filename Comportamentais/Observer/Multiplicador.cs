namespace designpattenscsharp.Comportamentais.Observer
{
    public class Multiplicador : AcaoGerarNotaFiscal
    {
        private readonly int fator;

        public Multiplicador(int fator)
        {
            this.fator = fator;
        }

        public void Executar(NotaFiscal nota)
        {
            Console.WriteLine($"O valor da nota multiplicado po {fator} é {nota.ValorBruto * fator}");
        }
    }
}