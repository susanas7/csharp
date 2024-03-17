class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce un número:");

        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número entero no negativo:");
        }

        long factorial = calcularFactorial(numero);

        Console.WriteLine(factorial);
    }

    static long calcularFactorial(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return 1;
        }


        long resultado = 1;
        
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        
        return resultado;
    }
}
