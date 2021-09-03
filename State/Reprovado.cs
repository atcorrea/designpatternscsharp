namespace designpattenscsharp.State
{
    internal class Reprovado : EstadoOrcamento
    {
        public override void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new InvalidOperationException("Este orcamento já foi reprovado, não pode receber mais descontos!");            
        }

        public override void Aprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Este orcamento já foi reprovado!");            
        }

        public override void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public override void Reprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("este orçamento já está reprovado!");            
        }
    }
}