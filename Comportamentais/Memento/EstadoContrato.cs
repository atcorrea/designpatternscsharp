namespace designpattenscsharp.Comportamentais.Memento
{
    public class EstadoContrato
    {

        public Contrato Contrato { get; }
        public DateTime Data { get; }

        public EstadoContrato(Contrato contrato)
        {
            this.Contrato = contrato;
            this.Data = DateTime.Now;
        }
    }
}