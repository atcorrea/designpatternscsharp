namespace designpattenscsharp.Comportamentais.Memento
{
    public class Contrato
    {
        public string Conteudo { get; set; }

        public EtapaContrato Etapa { get; set; }

        public void AvancarEtapa()
        {
            this.Etapa = this.Etapa switch
            {
                EtapaContrato.NOVO => EtapaContrato.EM_ANDAMENTO,
                EtapaContrato.EM_ANDAMENTO => EtapaContrato.FINALIZADO,
                EtapaContrato.FINALIZADO => throw new InvalidOperationException("Contrato já foi finalizado!")
            };
        }

        public EstadoContrato SalvaEstado()
        {
            return new EstadoContrato(new Contrato() { Conteudo = this.Conteudo, Etapa = this.Etapa });
        }

        public void RestauraEstado(EstadoContrato estadoContrato)
        {
            this.Conteudo = estadoContrato.Contrato.Conteudo;
            this.Etapa = estadoContrato.Contrato.Etapa;
        }
    }
}