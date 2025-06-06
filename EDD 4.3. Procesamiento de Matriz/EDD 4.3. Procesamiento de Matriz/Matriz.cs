// Clase para la gestion de la matriz
public class GestorMatriz
{
    // Se define la matriz y las variables para filas y columnas
    private int[,] datos = new int[1, 1];
    private int filas, columnas;

    public void CrearMatriz()
    {
        Console.WriteLine("=====Procesamiento de Matriz=====");
        Console.WriteLine("");

        Console.WriteLine("Especifíca los parametros de la matriz");
        Console.WriteLine("");

        // Se pide al usuario ingresar el número de filas
        while (true)
        {
            Console.Write("Filas: ");
            if (!int.TryParse(Console.ReadLine(), out filas))
            {
                // Si no se ingresa un número válido, se repite
                Console.WriteLine("Entrada inválida. Debe ser un número entero.");
                Console.WriteLine("");
                continue;
            }
            break;
        }

        // Se pide al usuario ingresar el número de columnas
        while (true)
        {
            Console.Write("Columnas: ");
            if (!int.TryParse(Console.ReadLine(), out columnas))
            {
                // Si no se ingresa un número válido, se repite
                Console.WriteLine("Entrada inválida. Debe ser un número entero.");
                Console.WriteLine("");
                continue;
            }
            break;
        }

        // Se inicializa la matriz con las filas y columnas que ingresó el usuario
        datos = new int[filas, columnas];

        // Se llena la matriz pidiendo al usuario que ingrese los números uno por uno
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
            {
                while (true)
                {
                    Console.Write($"[Fila {i + 1}, Columna {j + 1}]: ");
                    if (!int.TryParse(Console.ReadLine(), out datos[i, j]))
                    {
                        // Si no se ingresa un número válido, se repite
                        Console.WriteLine("Entrada inválida. Debe ser un número entero.");
                        Console.WriteLine("");
                        continue;
                    }
                    break;
                }
            }
    }

    public void Mostrar()
    {
        Console.WriteLine("");
        Console.WriteLine("Matriz:");
        Console.WriteLine("");

        // Se recorre la matriz y se imprime en forma de tabla
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{datos[i, j]}\t");

                if (j != filas - 1)
                    Console.Write("|");
            }

            Console.WriteLine("");

            if (i != filas - 1)
                Console.WriteLine(new string('-', columnas * 8 + 1));
        }
    }

    public void Procesar()
    {
        // Se inicializa el mayor y el menor con el primer elemento de la matriz
        int max = datos[0, 0];
        int min = datos[0, 0];

        // Variables para guardar la posición del mayor
        int Xmax = 0;
        int Ymax = 0;

        // Variables para guardar la posición del menor
        int Xmin = 0;
        int Ymin = 0;

        // Se recorre toda la matriz para encontrar el mayor y el menor
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
            {
                if (datos[i, j] > max)
                {
                    max = datos[i, j];
                    Xmax = i;
                    Ymax = j;
                }

                if (datos[i, j] < min)
                {
                    min = datos[i, j];
                    Xmin = i;
                    Ymin = j;
                }
            }

        // Se muestra el número mayor y menor junto a su posición
        Console.WriteLine("");
        Console.WriteLine($"Máximo: {max} en fila {Xmax + 1} y columna {Ymax + 1}");
        Console.WriteLine($"Mínimo: {min} en fila {Xmin + 1} y columna {Ymin + 1}");
    }
}
