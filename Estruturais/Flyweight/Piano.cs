namespace designpattenscsharp.Estruturais.Flyweight
{
    public class Piano
    {
        public void Toca(IEnumerable<INota> notas)
        {
            foreach (var nota in notas)
                Console.Beep(nota.Frequencia(), 300);
        }
    }
}