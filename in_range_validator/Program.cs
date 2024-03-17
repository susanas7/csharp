class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, introduce un número:");

        int numero;
        
        while (!int.TryParse(Console.ReadLine(), out numero)) {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número entero válido:");
        }
        
        if (numero >= 10 && numero <= 20) {
            Console.WriteLine("Está en el rango");
        } else {
            Console.WriteLine("Fuera del rango");
        }
    }
}
