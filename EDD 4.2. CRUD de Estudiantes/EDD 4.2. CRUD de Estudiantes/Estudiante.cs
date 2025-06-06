// Esta clase representa a un estudiante
public class Estudiante
{
    // Propiedades del estudiante
    public string? Matricula { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
    public string? Carrera { get; set; }
    public string? Grado { get; set; }

    // Método para mostrar los datos en consola
    public void Mostrar()
    {
        Console.WriteLine("");
        Console.WriteLine($"Datos del estudiante:");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Teléfono: {Telefono}");
        Console.WriteLine($"Correo: {Correo}");
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Grado: {Grado}");
        Console.WriteLine("");
    }
}


