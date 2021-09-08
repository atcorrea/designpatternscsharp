namespace designpattenscsharp.Comportamentais.Memento
{
    public class HistoricoContrato
    {
        private IList<EstadoContrato> Historico = new List<EstadoContrato>();

        public Contrato Pegar(int indiceHistorico)
        {
            return Historico[indiceHistorico].Contrato;
        }

        public void CriarNovoRegistro(EstadoContrato estado) => this.Historico.Add(estado);

        public int[] ListarHistorico()
        {
            var indexes = new List<int>();
            for (int i = 0; i < Historico.Count; i++)
                indexes.Add(i);

            return indexes.ToArray();
        }
    }
}