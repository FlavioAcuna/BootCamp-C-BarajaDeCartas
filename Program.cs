namespace BarajaDeCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            Mazo NuevoMazo = new Mazo();
            Jugador Flavio = new Jugador("Flavio");
            Console.WriteLine($"Recuento Baraja : {NuevoMazo.cartas.Count}");
            Flavio.Robo(NuevoMazo);
            Flavio.Robo(NuevoMazo);
            Flavio.Robo(NuevoMazo);
            foreach (var item in Flavio.mano)
            {
                Console.WriteLine($"Cartas Robadas Jugador: {Flavio.mano.Count} Carta Robada: {item.nombre} {item.pinta}");
            }
            Flavio.Descartar(2);
            Console.WriteLine($"Recuento Cartas Jugador: {Flavio.mano.Count}");
        }
    }
}