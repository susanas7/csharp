class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce cinco números:");

        double numero1 = leerNumero();
        double numero2 = leerNumero();
        double numero3 = leerNumero();
        double numero4 = leerNumero();
        double numero5 = leerNumero();

        double menorNumero = encontrarMenor(numero1, numero2, numero3, numero4, numero5);

        Console.WriteLine(menorNumero);
    }

    static double leerNumero()
    {
        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número válido:");
        }
        return numero;
    }

    static double encontrarMenor(double num1, double num2, double num3, double num4, double num5)
    {
        double menor = num1;
        if (num2 < menor)
            menor = num2;
        if (num3 < menor)
            menor = num3;
        if (num4 < menor)
            menor = num4;
        if (num5 < menor)
            menor = num5;
        return menor;
    }
}
