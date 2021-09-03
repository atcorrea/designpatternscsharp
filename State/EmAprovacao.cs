namespace designpattenscsharp.State
{
    public class EmAprovacao : EstadoOrcamento
    {
        public override void AplicarDescontoExtra(Orcamento orcamento)
        {
            if(!descontoFoiAplicado)
                orcamento.Valor -= orcamento.Valor * 0.05;
                
            throw new InvalidOperationException("Desconto extra já foi aplicado!");
        }

        public override void Aprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public override void Finalizar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Este orçamento ainda não foi aprovado!");
        }

        public override void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}