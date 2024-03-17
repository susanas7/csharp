class Fraccion
{
    public int Numerador { get; set; }
    public int Denominador { get; set; }

    public Fraccion(int numerador, int denominador)
    {
        Numerador = numerador;
        Denominador = denominador;
    }

    public double ValorDecimal()
    {
        return (double)Numerador / Denominador;
    }

    public override string ToString()
    {
        return $"{Numerador}/{Denominador}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el numerador de la primera fracción:");
        int numerador1 = leerNumero();

        Console.WriteLine("Introduce el denominador de la primera fracción:");
        int denominador1 = leerNumero();

        Console.WriteLine("Introduce el numerador de la segunda fracción:");
        int numerador2 = leerNumero();

        Console.WriteLine("Introduce el denominador de la segunda fracción:");
        int denominador2 = leerNumero();

        Fraccion fraccion1 = new Fraccion(numerador1, denominador1);
        Fraccion fraccion2 = new Fraccion(numerador2, denominador2);

        Fraccion diferencia = restarFraccion(fraccion1, fraccion2);

        Console.WriteLine(diferencia);
    }

    static Fraccion restarFraccion(Fraccion fraccion1, Fraccion fraccion2)
    {
        int nuevoNumerador = (fraccion1.Numerador * fraccion2.Denominador) - (fraccion2.Numerador * fraccion1.Denominador);
        int nuevoDenominador = fraccion1.Denominador * fraccion2.Denominador;

        return reducirFraccion(new Fraccion(nuevoNumerador, nuevoDenominador));
    }

    static Fraccion reducirFraccion(Fraccion fraccion)
    {
        int mcd = MCD(fraccion.Numerador, fraccion.Denominador);
        return new Fraccion(fraccion.Numerador / mcd, fraccion.Denominador / mcd);
    }

    static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int leerNumero()
    {
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número entero válido:");
        }
        return numero;
    }
}
