namespace designpattenscsharp.State
{
    public class Aprovado : EstadoOrcamento
    {
        public override void AplicarDescontoExtra(Orcamento orcamento)
        {
            if(!descontoFoiAplicado)
                orcamento.Valor -= orcamento.Valor * 0.02;
            
            throw new InvalidOperationException("Desconto extra já foi aplicado!");
        }

        public override void Aprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orcamento ja esta aprovado!");
        }

        public override void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public override void Reprovar(Orcamento orcamento)
        {
            throw new InvalidOperationException("Orcamento já foi aprovado!");
        }
    }
}