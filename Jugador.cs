/*
Dale a la clase Jugador una propiedad nombre.​
Dale al Jugador una propiedad de mano que sea una Lista de tipo Carta.​
Dale al Jugador un método de robo en el que roba una carta de la baraja, se añada a la mano del jugador, y devuelve la Carta.
Nota: este método requerirá una referencia a un objeto mazo.

Revisa tu trabajo robando tres cartas e imprimiendo la mano del jugador en la consola.​
Dale al Jugador un método de descarte que descarta la Carta en el índice especificado de la mano del jugador y devuelve esa Carta o null si el índice no existe.​
Revisa tu trabajo imprimiendo la mano del Jugador después de ejecutar el método de descarte.​
*/
namespace BarajaDeCartas
{

    public class Jugador
    {
        public string nombre { get; set; }
        public List<Carta> mano { get; set; }
        public Jugador(string Nombre)
        {
            nombre = Nombre;
            mano = new List<Carta>();
        }
        public Carta Robo(Mazo mazo)
        {
            Carta tomarCarta = mazo.MasAlta();
            mano.Add(tomarCarta);
            return tomarCarta;
        }

        public Carta? Descartar(int idx)
        {
            if (idx < 0 || idx > mano.Count)
            {
                Console.WriteLine("");
                return null;
            }
            else
            {
                Carta eliminar = mano[idx];
                mano.RemoveAt(idx);
                return eliminar;
            }

        }
    }
}