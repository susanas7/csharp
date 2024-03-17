class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iintroduce tu salario anual:");
        
        double salarioAnual;
        while (!double.TryParse(Console.ReadLine(), out salarioAnual) || salarioAnual < 0)
        {
            Console.WriteLine("Introduce un salario anual válido:");
        }

        if (salarioAnual > 12000)
        {
            double excedente = salarioAnual - 12000;
            double impuesto = excedente * 0.15;

            Console.WriteLine(impuesto);
        }
        else
        {
            Console.WriteLine("No debe impuestos");
        }
    }
}
