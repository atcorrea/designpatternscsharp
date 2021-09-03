namespace designpattenscsharp.State
{
    internal class Finalizado : EstadoOrcamento
    {
        public override void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new InvalidOperationException("Um orçamento finalizado não pode receber mais descontos!");
        }

        public override void Aprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Este orcamento já foi finalizado!");
        }

        public override void Finalizar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Este orcamento já foi finalizado!");
        }

        public override void Reprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Este orcamento já foi finalizado!");
        }
    }
}