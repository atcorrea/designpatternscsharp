namespace designpattenscsharp.Comportamentais.Memento
{
    public class Memento
    {
        public static void Testar()
        {
            var historicoContrato = new HistoricoContrato();
            var contrato = new Contrato();

            contrato.AvancarEtapa();
            contrato.Conteudo = "fazendo...";
            var novoEstado = contrato.SalvaEstado();
            historicoContrato.CriarNovoRegistro(novoEstado);

            contrato.Conteudo = "mais coisas...";
            contrato.AvancarEtapa();
            contrato.Conteudo = "terminei";
            var maisEstado = contrato.SalvaEstado();
            historicoContrato.CriarNovoRegistro(maisEstado);

            Console.WriteLine("SYS: Conteúdo do contrato atual:");
            Console.WriteLine(contrato.Conteudo);
            Console.WriteLine("SYS: Listando histórico de alterações do contrato:");
            Console.WriteLine($"[{String.Join(',', historicoContrato.ListarHistorico())}]");
            Console.WriteLine("SYS: Conteúdo do primeiro registro do histórico");
            Console.WriteLine(historicoContrato.Pegar(0).Conteudo);
        }
    }
}