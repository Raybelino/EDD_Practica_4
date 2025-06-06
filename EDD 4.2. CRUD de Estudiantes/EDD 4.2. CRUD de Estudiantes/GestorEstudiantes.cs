// Clase que gestiona a varios estudiantes
public class GestorEstudiantes
{
    private Estudiante[] estudiantes;
    private int contador;

    // Constructor que pide cuántos estudiantes se van a registrar
    public GestorEstudiantes()
    {
        Console.WriteLine("======Gestor Estudiantes======");
        Console.WriteLine("");
        Console.WriteLine("¿Cuántos estudiantes se registrarán? ");

        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out int cantidad))
            {
                Console.WriteLine("Debes poner un número");
                Console.WriteLine("");
                continue;
            }

            // Creamos el arreglo con la cantidad indicada
            estudiantes = new Estudiante[cantidad];
            break;
        }
    }

    // Agrega un estudiante nuevo
    public void Agregar()
    {
        // Validamos si hay espacio
        if (contador >= estudiantes.Length)
        {
            Console.WriteLine("Ya no hay más espacio para estudiantes.");
            return;
        }

        Console.WriteLine("======Agregar Estudiantes======");
        Console.WriteLine("");

        Estudiante estudiante = new Estudiante();

        // Pedimos y validamos los datos uno por uno
        Console.WriteLine("Debes llenar los siguientes campos:");
        Console.WriteLine("");

        while (true)
        {
            Console.Write("Matrícula: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.Length >= 8)
            {
                estudiante.Matricula = input;
                break;
            }
            Console.WriteLine("Matrícula inválida. Debe tener al menos 4 caracteres.");
            Console.WriteLine("");
        }

        while (true)
        {
            Console.Write("Nombre: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter))
            {
                estudiante.Nombre = input;
                break;
            }
            Console.WriteLine("Nombre inválido. Solo letras permitidas.");
            Console.WriteLine("");
        }

        while (true)
        {
            Console.Write("Apellido: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter))
            {
                estudiante.Apellido = input;
                break;
            }
            Console.WriteLine("Apellido inválido. Solo letras permitidas.");
            Console.WriteLine("");
        }

        while (true)
        {
            Console.Write("Teléfono: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsDigit) && input.Length >= 10)
            {
                estudiante.Telefono = input;
                break;
            }
            Console.WriteLine("Teléfono inválido. Debe contener al menos 10 dígitos.");
            Console.WriteLine("");
        }

        while (true)
        {
            Console.Write("Correo: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.Contains("gmail.com"))
            {
                estudiante.Correo = input;
                break;
            }
            Console.WriteLine("Correo inválido. Debe ser tipo usuario@gmail.com.");
            Console.WriteLine("");
        }

        while (true)
        {
            Console.Write("Carrera: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                estudiante.Carrera = input;
                break;
            }
            Console.WriteLine("Carrera no puede estar vacía.");
            Console.WriteLine("");
        }

        while (true)
        {
            Console.Write("Grado (1-10): ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int grado) && grado >= 1 && grado <= 10)
            {
                estudiante.Grado = grado.ToString();
                break;
            }
            Console.WriteLine("Grado inválido. Debe ser un número entre 1 y 10.");
            Console.WriteLine("");
        }

        // Lo guardamos en el arreglo
        estudiantes[contador++] = estudiante;
        Console.WriteLine("");
        Console.WriteLine("Estudiante agregado.");
    }

    // Modifica los datos de un estudiante existente
    public void Modificar()
    {
        string matricula;

        Console.WriteLine("======Modificar Estudiantes======");
        Console.WriteLine("");

        // Pedimos matrícula para buscar al estudiante
        while (true)
        {
            Console.Write("¿Cuál es la matrícula? ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.Length >= 8)
            {
                matricula = input;
                break;
            }
            Console.WriteLine("Matrícula inválida.");
            Console.WriteLine("");
        }

        // Buscamos el estudiante en el arreglo
        for (int i = 0; i < contador; i++)
        {
            if (estudiantes[i].Matricula == matricula)
            {
                // Si lo encontramos, pedimos nuevos datos
                while (true)
                {
                    Console.Write("Nuevo Nombre: ");
                    string? input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter))
                    {
                        estudiantes[i].Nombre = input;
                        break;
                    }
                    Console.WriteLine("Nombre inválido. Solo letras permitidas.");
                    Console.WriteLine("");
                }

                while (true)
                {
                    Console.Write("Nuevo Apellido: ");
                    string? input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter))
                    {
                        estudiantes[i].Apellido = input;
                        break;
                    }
                    Console.WriteLine("Apellido inválido. Solo letras permitidas.");
                    Console.WriteLine("");
                }

                while (true)
                {
                    Console.Write("Nuevo Teléfono: ");
                    string? input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsDigit) && input.Length >= 10)
                    {
                        estudiantes[i].Telefono = input;
                        break;
                    }
                    Console.WriteLine("Teléfono inválido. Debe contener al menos 10 dígitos numéricos.");
                    Console.WriteLine("");
                }

                while (true)
                {
                    Console.Write("Nuevo Correo: ");
                    string? input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input) && input.Contains("gmail.com"))
                    {
                        estudiantes[i].Correo = input;
                        break;
                    }
                    Console.WriteLine("Correo inválido. Debe tener formato tipo usuario@gmail.com.");
                    Console.WriteLine("");
                }

                while (true)
                {
                    Console.Write("Nueva Carrera: ");
                    string? input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        estudiantes[i].Carrera = input;
                        break;
                    }
                    Console.WriteLine("Carrera no puede estar vacía.");
                    Console.WriteLine("");
                }

                while (true)
                {
                    Console.Write("Nuevo Grado: ");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int grado) && grado >= 1 && grado <= 10)
                    {
                        estudiantes[i].Grado = input;
                        break;
                    }
                    Console.WriteLine("Grado inválido. Debe ser un número entre 1 y 10.");
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.WriteLine("Estudiante modificado.");
                return;
            }
        }
        // Si no lo encuentra, se lo avisa al usuario
        Console.WriteLine("");
        Console.WriteLine("Estudiante no encontrado.");
        Console.WriteLine("");
    }

    // Elimina un estudiante según la matrícula
    public void Eliminar()
    {
        string matricula;

        Console.WriteLine("======Eliminar Estudiantes======");
        Console.WriteLine("");

        while (true)
        {
            Console.Write("¿Cuál es la matrícula? ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.Length >= 8)
            {
                matricula = input;
                break;
            }
            Console.WriteLine("Matrícula inválida.");
            Console.WriteLine("");
        }

        for (int i = 0; i < contador; i++)
        {
            if (estudiantes[i].Matricula == matricula)
            {
                // Si lo encontramos, lo eliminamos moviendo los demás hacia atrás
                for (int j = i; j < contador - 1; j++)
                    estudiantes[j] = estudiantes[j + 1];

                contador--;
                Console.WriteLine("");
                Console.WriteLine("Estudiante eliminado.");
                Console.WriteLine("");
                return;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Estudiante no encontrado.");
        Console.WriteLine("");
    }

    // Busca y muestra un estudiante
    public void Buscar()
    {
        string matricula;

        Console.WriteLine("======Buscar Estudiantes======");
        Console.WriteLine("");

        while (true)
        {
            Console.Write("¿Cuál es la matrícula? ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.Length >= 8)
            {
                matricula = input;
                break;
            }
            Console.WriteLine("Matrícula inválida.");
            Console.WriteLine("");
        }

        for (int i = 0; i < contador; i++)
        {
            if (estudiantes[i].Matricula == matricula)
            {
                estudiantes[i].Mostrar();
                return;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Estudiante no encontrado.");
        Console.WriteLine("");
    }
}
