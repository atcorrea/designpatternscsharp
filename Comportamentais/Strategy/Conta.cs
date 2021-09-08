namespace designpattenscsharp.Comportamentais.Strategy
{
    public class Conta
    {
        public decimal Saldo { get; private set; }

        public Conta(decimal saldo)
        {
            this.Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }
    }
}