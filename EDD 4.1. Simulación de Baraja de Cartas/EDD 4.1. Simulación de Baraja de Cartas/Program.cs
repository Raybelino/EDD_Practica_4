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

                    if (!int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0 && cantidad <= baraja.CartasRestantes())
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
            if (cartas.Count < cantidad - 1)
            {
                Console.WriteLine($"Solo hay {cartas.Count} en la baraja");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                cartas[0].MostrarCarta();   // Muestra la carta
                cartas.Remove(cartas[0]);   // Elimina la carta de la baraja
            }
        }
    }
}

