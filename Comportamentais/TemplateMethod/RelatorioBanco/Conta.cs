namespace designpattenscsharp.Comportamentais.TemplateMethod.RelatorioBanco
{
    public class Conta
    {
        public string NomeTitular { get; }
        public int Numero { get; }
        public short Agencia { get; }

        public decimal Saldo { get; private set; }

        public Conta(string nomeTitular, int numero, short agencia)
        {
            this.Agencia = agencia;
            this.Numero = numero;
            this.NomeTitular = nomeTitular;
        }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }
    }
}
