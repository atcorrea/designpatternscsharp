namespace designpattenscsharp.Estruturais.Decorator.Banco
{
    public class DecoratorBanco
    {
        public static void Testar()
        {
            var c1 = new Conta(99, new DateTime(2021,1,2), "conta1");
            var c2 = new Conta(100, new DateTime(2021,1,2), "conta2");
            var c3 = new Conta(500_001, new DateTime(2021,1,2), "conta3");
            var c4 = new Conta(499_999, new DateTime(2021,1,2), "conta4");
            var c5 = new Conta(0, new DateTime(2021,9,2), "conta5");
            var c6 = new Conta(0, new DateTime(2021,9,2), "conta6");

            var listaContas = new List<Conta>();
            listaContas.Add(c1);
            listaContas.Add(c2);
            listaContas.Add(c3);
            listaContas.Add(c4);
            listaContas.Add(c5);
            listaContas.Add(c6);

            var contasFiltradas = new FiltroPorSaldoAbaixo100Reais(new FiltroDataAberturaMesCorrente()).Filtrar(listaContas);

           foreach (var conta in contasFiltradas)
               Console.WriteLine(conta);
        }
    }
}