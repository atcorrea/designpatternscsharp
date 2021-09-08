namespace designpattenscsharp.Estruturais.Decorator.Banco
{
    public class Conta
    {
        public Conta(double saldo, DateTime dataAbertura, string nomeTitular)
        {
            this.Saldo = saldo;
            this.DataAbertura = dataAbertura;
            this.NomeTitular = nomeTitular;

        }
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public string NomeTitular { get; set; }

        public override string ToString()
        {
            return $"{NomeTitular} - Abertura {DataAbertura.Day}/{DataAbertura.Month}/{DataAbertura.Year} - Saldo: [{Saldo}]";
        }
    }
}