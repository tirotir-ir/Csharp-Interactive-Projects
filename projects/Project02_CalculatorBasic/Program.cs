using System;
class Program { static void Main() {
    Console.Write("a = "); if (!double.TryParse(Console.ReadLine(), out double a)) return;
    Console.Write("op (+,-,*,/): "); string op = Console.ReadLine() ?? "+";
    Console.Write("b = "); if (!double.TryParse(Console.ReadLine(), out double b)) return;
    double r = op switch { "+" => a+b, "-" => a-b, "*" => a*b, "/" when b!=0 => a/b, _ => double.NaN };
    Console.WriteLine(double.IsNaN(r) ? "Error" : $"Result = {r}");
}}