namespace designpattenscsharp.Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(IEstrategiaInvestimento estrategia, Conta conta)
        {
            var valorRendido = estrategia.Render(conta.Saldo) * 0.75m;
            conta.Depositar(valorRendido);

            Console.WriteLine("O investimento rendeu:");
            Console.WriteLine(valorRendido);
        }
    }
}