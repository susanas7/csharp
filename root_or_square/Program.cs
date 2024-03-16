class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce un número:");
        
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero)) {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número válido:");
        }

        double resultado = (numero >= 0) ? Math.Sqrt(numero) : Math.Pow(numero, 2);

        Console.WriteLine($"El resultado es: {resultado}");
    }
}
