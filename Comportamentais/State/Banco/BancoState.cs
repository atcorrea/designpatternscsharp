namespace designpattenscsharp.Comportamentais.State.Banco
{
    public class BancoState
    {
        public static void Testar()
        {
            var conta = new Conta(1000);
            conta.Sacar(1005);
            Console.WriteLine(conta.Saldo);
            conta.Depositar(5);
            Console.WriteLine(conta.Saldo);
            try
            {
                conta.Sacar(1000);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            conta.Depositar(5000);
            conta.Sacar(1000);
            Console.WriteLine(conta.Saldo);
        }
    }
}