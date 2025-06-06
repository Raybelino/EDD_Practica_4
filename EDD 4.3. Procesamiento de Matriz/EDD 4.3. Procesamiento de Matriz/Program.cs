using System;

namespace Matriz
{
    public class Program
    {
        static void Main()
        {
            // Se crea un objeto de la clase Matriz
            GestorMatriz matriz = new GestorMatriz();

            // Se llama al método que pide al usuario crear la matriz
            matriz.CrearMatriz();

            // Se muestra la matriz en pantalla
            matriz.Mostrar();

            // Se busca el número mayor y menor de la matriz y se muestran
            matriz.Procesar();
        }
    }
}
