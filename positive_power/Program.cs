Console.WriteLine("Por favor, introduce un número positivo para elevarlo al cuadrado:");
string input = Console.ReadLine();

if (double.TryParse(input, out double number)) {
    if (number > 0) {
        double resultado = Math.Pow(number, 2);
        Console.WriteLine($"El cuadrado de {number} es: {resultado}");
        return;
    }
    
    Console.WriteLine("El número ingresado no es positivo.");
    return;
}
    
Console.WriteLine("El dato es inválida. Por favor, introduce un número válido.");