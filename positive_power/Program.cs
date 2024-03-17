Console.WriteLine("Por favor, introduce un número positivo para elevarlo al cuadrado:");
string input = Console.ReadLine();

if (double.TryParse(input, out double number)) {
    if (number > 0) {
        double resultado = Math.Pow(number, 2);
        Console.WriteLine(resultado);
        return;
    }
    
    Console.WriteLine("Número negativo");
    return;
}
    
Console.WriteLine("El dato es inválido. Por favor, introduce un número válido.");