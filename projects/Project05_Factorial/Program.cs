using System;
class Program { static long Fact(int n){ long f=1; for(int i=2;i<=n;i++) f*=i; return f; }
static void Main(){ Console.Write("n? "); if(!int.TryParse(Console.ReadLine(), out int n)) return;
Console.WriteLine($"n! = {Fact(n)}"); } }