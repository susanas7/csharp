class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el radio del circulo:");

        double radio;
        while (!double.TryParse(Console.ReadLine(), out radio)) {
            Console.WriteLine("Entrada inválida. Por favor, introduce un número válido:");
        }
        var circ = new Circulo();

        circ.Radio = radio;

        var resultado_perim = circ.Perimetro();

        Console.WriteLine(resultado_perim);
    }
}
class Circulo
{
    public double Radio { get; set; }

    public double Perimetro() => 2 * Math.PI * Radio;
}