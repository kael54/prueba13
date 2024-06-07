
using CalculadoraDemo;

Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese el primer numero por favor:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero por favor:");
int n2 = Convert.ToInt32(Console.ReadLine());
int resultado = 0;
resultado = Mathematics.Multiplication(n1 , n2);
Console.WriteLine($"El resultado de su multiplicacion es: {resultado}");



