using System; 
class Program { static void Main(){ Console.Write("Start (yyyy-mm-dd): "); var s=DateTime.Parse(Console.ReadLine()!);
 Console.Write("End (yyyy-mm-dd): "); var e=DateTime.Parse(Console.ReadLine()!);
 var d=e-s; Console.WriteLine($"Days: {d.TotalDays:F0}, Hours: {d.TotalHours:F0}"); } }