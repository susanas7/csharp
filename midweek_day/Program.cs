class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce un número entre 1 y 7:");

        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 7)
        {
            Console.WriteLine("Introduce un número válido entre 1 y 7:");
        }
        
        switch (numero)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            default:
                Console.WriteLine("Número fuera del rango laboral");
                break;
        }
    }
}
