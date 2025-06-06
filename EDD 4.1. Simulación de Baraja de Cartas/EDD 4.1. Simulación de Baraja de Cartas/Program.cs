using System;

namespace BarajaCartas
{
    // Clase principal del programa
    public class Program
    {
        static void Main()
        {
            Baraja baraja = new Baraja(); // Crea una nueva baraja
            bool salir = false;

            Console.WriteLine($"===== SIMULADOR DE BARAJA DE CARTAS =====");
            Console.WriteLine("");

            while (!salir)
            {
                // Pregunta si se desea barajar la baraja
                Console.Write("¿Desea barajar la baraja? (s/n): ");
                while (true)
                {
                    string? opcion = Console.ReadLine()?.Trim().ToLower();

                    if (opcion != "s" && opcion != "n")
                    {
                        Console.WriteLine("Debes de poner s (si) o n (no)");
                        continue;
                    }

                    if (opcion == "s")
                    {
                        baraja.Barajar();
                        Console.WriteLine("Baraja mezclada.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("no se barajo la baraja");
                        Console.WriteLine("");
                    }
                    break;
                }

                // Pide al usuario cuántas cartas desea repartir
                while (true)
                {
                    Console.Write($"¿Cuántas cartas desea repartir? (1 - {baraja.CartasRestantes()}): ");

                    if (!int.TryParse(Console.ReadLine(), out int cantidad) || (cantidad > 0 && cantidad > baraja.CartasRestantes()))
                    {
                        Console.WriteLine("Cantidad inválida o no hay suficientes cartas.");
                        Console.WriteLine("");
                        continue;
                    }

                    Console.WriteLine("--- CARTAS REPARTIDAS ---");
                    baraja.Repartir(cantidad); // Reparte las cartas
                    Console.WriteLine("");
                    break;
                }

                // Si no quedan cartas, termina el programa
                if (baraja.CartasRestantes() == 0)
                {
                    Console.WriteLine("No quedan más cartas en la baraja.");
                    salir = true;
                }
                else
                {
                    // Pregunta si desea repartir de nuevo
                    while (true)
                    {
                        Console.Write("¿Desea repartir de nuevo? (s/n): ");
                        string? repetir = Console.ReadLine()?.Trim().ToLower();
                        Console.WriteLine("");

                        if (repetir != "s" && repetir != "n")
                        {
                            Console.WriteLine("Debes de poner s (si) o n (no)");
                            Console.WriteLine("");
                            continue;
                        }

                        if (repetir == "n")
                        {
                            Console.WriteLine("Se termino la simulacion.");
                            Console.WriteLine("");
                            salir = true;
                            break;
                        }
                        else
                            break;
                    }
                }
            }
        }
    }
}

