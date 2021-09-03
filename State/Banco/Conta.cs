namespace designpattenscsharp.State.Banco
{
    public class Conta
    {
        private EstadoConta Estado { get; set; }
        private interface EstadoConta
        {
            void Sacar(double valor, Conta conta);
            void Depositar(double valor, Conta conta);
        }
        private class ContaNegativa : EstadoConta
        {
            public void Depositar(double valor, Conta conta)
            {
                conta.Saldo += valor * 0.95;
                if (conta.Saldo > 0)
                    conta.Estado = new ContaPositiva();
            }

            public void Sacar(double valor, Conta conta)
            {
                throw new InvalidOperationException("Saque não pode ser feito em uma conta negativa!");
            }
        }
        private class ContaPositiva : EstadoConta
        {
            public void Depositar(double valor, Conta conta)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Sacar(double valor, Conta conta)
            {
                conta.Saldo -= valor;
                if (conta.Saldo < 0)
                    conta.Estado = new ContaNegativa();
            }
        }

        public Conta(double saldo, DateTime dataAbertura, string nomeTitular)
        {
            this.Saldo = saldo;
            this.DataAbertura = dataAbertura;
            this.NomeTitular = nomeTitular;
            this.Estado = new ContaPositiva();
        }

        public Conta(double saldo)
        {
            this.Saldo = saldo;
            this.Estado = new ContaPositiva();
        }

        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public string NomeTitular { get; set; }

        public void Sacar(double valor)
        {
            Estado.Sacar(valor, this);
        }

        public void Depositar(double valor)
        {
            Estado.Depositar(valor, this);
        }

        public override string ToString()
        {
            return $"{NomeTitular} - Abertura {DataAbertura.Day}/{DataAbertura.Month}/{DataAbertura.Year} - Saldo: [{Saldo}]";
        }
    }
}