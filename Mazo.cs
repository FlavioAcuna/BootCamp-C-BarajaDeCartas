/*
Dale a la clase Mazo una propiedad llamada "cartas" que es una lista de objetos de Carta.​
Al inicializar la baraja, asegúrate de que tenga una lista de 52 cartas únicas como propiedad "cartas", 
aunque también se puede escribir .Add e instanciar cada tarjeta por separado. 
¡Existe una forma más eficiente para hacer esto! Piensa en el patrón del mazo.​ 
Hay 4 pintas y 13 valores para cada una. ​No te preocupes todavía por el nombre de la carta 
(por ejemplo: As, Sota, Reina). ​Puedes añadir el nombre después de elaborar el patrón.​ 
Empieza por calcular cómo harías 4 cartas de cada pinta.​ Luego piensa cómo harías 13 cartas para cada uno de esas 4 pintas,
cada una con su propio valor único del 1 al 13.​ Estamos haciendo un conjunto de acciones repetidamente.
¿Cómo hacemos algo repetidamente en código?​
¡Revisa tu trabajo! Ahora instancia un Mazo para que cada carta se imprima en la consola.​
*/
namespace BarajaDeCartas
{
    public class Mazo
    {
       public List<Carta> cartas;
       

    }
}