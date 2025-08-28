using System; using System.IO; using System.Linq;
class Program { static void Main(){ Console.Write("File path? ");
 var p = Console.ReadLine(); if(string.IsNullOrWhiteSpace(p) || !File.Exists(p)){ Console.WriteLine("Not found."); return;}
 var text = File.ReadAllText(p); var words = text.Split(new[]{' ','\n','\r','\t'}, StringSplitOptions.RemoveEmptyEntries);
 Console.WriteLine($"Lines: {File.ReadAllLines(p).Length}, Words: {words.Length}, Chars: {text.Length}"); } }