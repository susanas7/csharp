using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce cuatro números:");

        double numero1 = leerNumero();
        double numero2 = leerNumero();
        double numero3 = leerNumero();
        double numero4 = leerNumero();

        double promedio = CalcularPromedio(numero1, numero2, numero3, numero4);

        Console.WriteLine(promedio);
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

    static double CalcularPromedio(double numero1, double numero2, double numero3, double numero4)
    {
        return (numero1 + numero2 + numero3 + numero4) / 4;
    }
}
