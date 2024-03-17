class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, introduce una palabra:");
        string palabra = Console.ReadLine();

        int cantidadVocales = contarVocales(palabra);

        Console.WriteLine(cantidadVocales);
    }

    static int contarVocales(string palabra)
    {
        int conteo = 0;
        foreach (char letra in palabra)
        {
            if (esVocal(letra))
            {
                conteo++;
            }
        }
        return conteo;
    }

    static bool esVocal(char letra)
    {
        letra = char.ToLower(letra);
        return letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u';
    }
}
