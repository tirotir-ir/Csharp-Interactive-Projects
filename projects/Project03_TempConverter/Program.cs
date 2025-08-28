using System;
class Program { static void Main() {
    Console.Write("Celsius: "); if (!double.TryParse(Console.ReadLine(), out double c)) return;
    double f = c*9/5+32; Console.WriteLine($"Fahrenheit = {f:F2}");
}}