/*
Crea una clase llamada "Carta".​
Dale a la Carta una propiedad llamada "nombre" que contendrá el valor de la carta ej. (As, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Reina, Rey). Esta propiedad "nombre" debe ser una cadena.​
Dale a la Carta una propiedad llamada "pinta" que contendrá la pinta de la carta (Tréboles, Picas, Corazones, Diamantes).​
Dale a la Carta una propiedad llamada "val" que contendrá el valor numérico de la tarjeta (1-13) como enteros.​
Añade una función Print a tu clase de cartas que imprima el nombre, valor y pinta de cada carta.​
¡Revisa tu trabajo! Ahora instancia una Carta en el archivo Program.cs y asegúrate que el nombre, el valor y la pinta se impriman en la consola.​
*/
namespace BarajaDeCartas
{
    public class Carta
    {
        public string? nombre { get; set; }
        public string? pinta { get; set; }
        public string? val { get; set; }

        public void ImprimeInformacion()
        {
            Console.WriteLine($"Nombre: {nombre} Valor: {val} Pinta {pinta}");
        }
    }
}