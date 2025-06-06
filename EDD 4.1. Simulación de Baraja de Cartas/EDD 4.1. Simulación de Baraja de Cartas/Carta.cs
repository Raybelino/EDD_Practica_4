// Clase que representa una carta individual
public class Carta
{
    public string? Valor { get; set; } // Valor de la carta (A, 2, 3, ..., K)
    public string? Palo { get; set; }  // Palo de la carta (Corazones, Diamantes, etc.)

    // Muestra en consola el valor y palo de la carta
    public void MostrarCarta()
    {
        Console.WriteLine($"{Valor} de {Palo}");
    }
}
