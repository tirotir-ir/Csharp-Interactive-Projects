using System;
class Program { static void Main() {
    Console.Write("Enter first number: ");
    if (!int.TryParse(Console.ReadLine(), out int a)) { Console.WriteLine("Invalid"); return; }
    Console.Write("Enter second number: ");
    if (!int.TryParse(Console.ReadLine(), out int b)) { Console.WriteLine("Invalid"); return; }
    Console.WriteLine($"Sum = {a + b}");
}}