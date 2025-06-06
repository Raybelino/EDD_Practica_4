// Clase que representa la baraja completa de cartas
public class Baraja
{
    private List<Carta> cartas; // Lista de cartas en la baraja

    // Arreglos estáticos que contienen los palos y valores posibles
    private static string[] palos = { "Corazones", "Diamantes", "Tréboles", "Picas" };
    private static string[] valores = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    // Constructor que genera todas las combinaciones posibles de cartas
    public Baraja()
    {
        cartas = new List<Carta>();
        foreach (var palo in palos)
            foreach (var valor in valores)
                cartas.Add(new Carta { Valor = valor, Palo = palo }); // Crea las 52 cartas
    }

    // Mezcla aleatoriamente las cartas de la baraja
    public void Barajar()
    {
        Random rnd = new Random();
        for (int a = 0; a < cartas.Count; a++)
        {
            int b = rnd.Next(cartas.Count);

            // Intercambia dos cartas aleatoriamente
            Carta Carta_A = cartas[a];
            cartas[a] = cartas[b];
            cartas[b] = Carta_A;
        }
    }

    // Devuelve la cantidad de cartas restantes en la baraja
    public int CartasRestantes()
    {
        return cartas.Count;
    }

    // Reparte una cantidad de cartas especificadas, mostrándolas y eliminándolas de la baraja
    public void Repartir(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            cartas[0].MostrarCarta();   // Muestra la carta
            cartas.Remove(cartas[0]);   // Elimina la carta de la baraja
        }
    }
}
