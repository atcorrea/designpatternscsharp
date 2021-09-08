namespace designpattenscsharp.Estruturais.Flyweight
{
    public class Flyweight
    {
        public static void Testar()
        {
            var musica = new List<INota>()
            {
                {NotasMusicais.Pega("do")},
                {NotasMusicais.Pega("re")},
                {NotasMusicais.Pega("mi")},
                {NotasMusicais.Pega("fa")},
                {NotasMusicais.Pega("fa")},
                {NotasMusicais.Pega("fa")},

                {NotasMusicais.Pega("do")},
                {NotasMusicais.Pega("re")},
                {NotasMusicais.Pega("do")},
                {NotasMusicais.Pega("re")},
                {NotasMusicais.Pega("re")},
                {NotasMusicais.Pega("re")},

                {NotasMusicais.Pega("do")},
                {NotasMusicais.Pega("sol")},
                {NotasMusicais.Pega("fa")},
                {NotasMusicais.Pega("mi")},
                {NotasMusicais.Pega("mi")},
                {NotasMusicais.Pega("mi")},

                {NotasMusicais.Pega("do")},
                {NotasMusicais.Pega("re")},
                {NotasMusicais.Pega("mi")},
                {NotasMusicais.Pega("fa")},
                {NotasMusicais.Pega("fa")},
                {NotasMusicais.Pega("fa")},
            };

            var piano = new Piano();
            piano.Toca(musica);
        }
    }
}