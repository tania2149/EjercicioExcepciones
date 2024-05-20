using EjercicioExcepciones;

class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();
        int opcion;

        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                int num1, num2, resultado;
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el primer número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = operaciones.Sumar(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 2:
                        // Implementar Restar
                        break;
                    case 3:
                        // Implementar Multiplicar
                        break;
                    case 4:
                        // Implementar Dividir
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número válido para la opción.");
            }

        } while (opcion != 5);
    }
}