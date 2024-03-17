namespace DoubleOrTriple;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el primer número:");
        double numero1 = leerNumero();

        Console.WriteLine("Introduce el segundo número:");
        double numero2 = leerNumero();

        double resultado = (numero1 > numero2) ? numero1 * 2 : numero2 * 3;

        Console.WriteLine(resultado);
    }

    static double leerNumero()
    {
        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero)) {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número válido:");
        }

        return numero;
    }
}
