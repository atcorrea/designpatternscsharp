namespace designpattenscsharp.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new Conta(5000);
            var investidor = new RealizadorDeInvestimentos();

            IEstrategiaInvestimento estrategia = new InvestimentoArrojado();

            investidor.Investir(estrategia, conta);

            Console.WriteLine($"Agora seu saldo é {conta.Saldo}");

            IEstrategiaInvestimento estrategia2 = new InvestimentoModerado();

            investidor.Investir(estrategia2, conta);

            Console.WriteLine($"Agora seu saldo é {conta.Saldo}");
        }
    }
}