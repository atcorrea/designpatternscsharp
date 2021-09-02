namespace designpattenscsharp.ChainOfResponsibility.segundo
{
    public class ChainOfResponsibility
    {
        public static void Testar()
        {
            var conta = new Conta(2000d, "Martin");

            var requisicao = new Requisicao(Formato.XML);

            IProcessadorRequisicao processadorXML = new ProcessadorXML(null);
            IProcessadorRequisicao processadorPorcento = new ProcessadorPorcento(processadorXML);
            IProcessadorRequisicao processadorCsv = new ProcessadorCSV(processadorPorcento);

            Console.WriteLine(processadorPorcento.Processar(requisicao, conta));
        }
    }
}