namespace designpattenscsharp.Factory
{
    public class Factory
    {
       public static void Testar() 
       {
           var factory = new ConnectionFactory();
           var conexao = factory.GetConnection();
       }
    }
}