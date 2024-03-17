class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el primer número:");
        int numero1 = leerNumero();

        Console.WriteLine("Introduce el segundo número:");
        int numero2 = leerNumero();

        int residuo = numero1 % numero2;
        Console.WriteLine(residuo);
    }

    static int leerNumero()
    {
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número válido:");
        }
        return numero;
    }
}
