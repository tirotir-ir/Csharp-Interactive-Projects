using System; using System.IO; using System.Linq;
class Program { static void Main(){ Console.Write("CSV path? "); var p=Console.ReadLine();
 if(string.IsNullOrWhiteSpace(p) || !File.Exists(p)){ Console.WriteLine("Not found"); return; }
 var lines = File.ReadAllLines(p); foreach(var row in lines.Select(l=>l.Split(','))) Console.WriteLine(string.Join(" | ", row)); } }