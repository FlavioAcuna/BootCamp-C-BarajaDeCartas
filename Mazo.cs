/*
1- Dale a la clase Mazo una propiedad llamada "cartas" que es una lista de objetos de Carta.​
2- Al inicializar la baraja, asegúrate de que tenga una lista de 52 cartas únicas como propiedad "cartas", aunque también se puede escribir .Add e instanciar cada tarjeta por separado. ¡Existe una forma más eficiente para hacer esto! Piensa en el patrón del mazo.​ Hay 4 pintas y 13 valores para cada una. ​No te preocupes todavía por el nombre de la carta (por ejemplo: As, Sota, Reina). ​Puedes añadir el nombre después de elaborar el patrón.​ Empieza por calcular cómo harías 4 cartas de cada pinta.​ Luego piensa cómo harías 13 cartas para cada uno de esas 4 pintas, cada una con su propio valor único del 1 al 13.​ Estamos haciendo un conjunto de acciones repetidamente. ¿Cómo hacemos algo repetidamente en código?​
3- ¡Revisa tu trabajo! Ahora instancia un Mazo para que cada carta se imprima en la consola.​

Metodos
1- Dale al Mazo un método de reparto que seleccione la carta "más alta", la elimine de la lista, y la devuelva.​
2- Dale al Mazo un método de reinicio que restablezca la propiedad Cartas para que contenga las 52 cartas originales.​
3- Dale al mazo un método de barajado que reordene aleatoriamente las cartas del mazo. ​
4- Revisa tu trabajo imprimiendo toda la baraja y/o el recuento de barajas después de llamar a cada método.​
*/
namespace BarajaDeCartas
{
    public class Mazo
    {
        public List<Carta> cartas = new List<Carta>();

        public Mazo()
        {
            Reset();
            Barajar();
            ImprimirBaraja();
        }
        public Carta MasAlta()
        {
            if (cartas.Count > 0)
            {
                Carta alta = cartas[0];
                cartas.RemoveAt(0);
                return alta;
            }
            else
            {
                Reset();
                return MasAlta();
            }

        }
        public Mazo Reset()
        {
            string[] pintas = { "Trebol", "Picas", "Corazones", "Diamantes" };
            string[] CartaValor = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Reina", "Rey" };
            for (int idxCarta = 0; idxCarta < CartaValor.Length; idxCarta++)
            {
                for (int idxPintas = 0; idxPintas < pintas.Length; idxPintas++)
                {
                    cartas.Add(new Carta(CartaValor[idxCarta], pintas[idxPintas], idxCarta));
                }
            }
            return this;
        }
        public Mazo Barajar()
        {
            Random rand = new Random();
            for (int idxcard = cartas.Count - 1; idxcard > 0; idxcard--)
            {
                int RandomCard = rand.Next(idxcard);
                Carta Temp = cartas[RandomCard];
                cartas[RandomCard] = cartas[idxcard];
                cartas[idxcard] = Temp;
            }
            return this;
        }
        public void ImprimirBaraja()
        {
            foreach (var carta in cartas)
            {
                Console.WriteLine($"Nombre: {carta.nombre} Pinta: {carta.pinta}");
            }
        }
    }
}