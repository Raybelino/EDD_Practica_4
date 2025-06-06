using System;

namespace Estudiantes
{
    public class Program
    {
        static void Main()
        {
            // Creamos el gestor que se encargará de manejar los estudiantes
            GestorEstudiantes gestor = new GestorEstudiantes();

            int opcion = 0;

            // Mostramos un menú hasta que el usuario quiera salir
            while (opcion != 5)
            {
                Console.WriteLine("");
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Modificar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("5. Salir");
                Console.WriteLine("");
                Console.Write("Opción: ");

                // Validamos que la opción sea un número
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Debe ser un número entre 1 y 5");
                    Console.WriteLine("");
                    continue;
                }

                Console.WriteLine("");

                // Llamamos a la opción seleccionada
                switch (opcion)
                {
                    case 1: gestor.Agregar(); break;
                    case 2: gestor.Modificar(); break;
                    case 3: gestor.Eliminar(); break;
                    case 4: gestor.Buscar(); break;
                }
            }
        }
    }
}
