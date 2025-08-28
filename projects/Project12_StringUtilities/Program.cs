using System; using System.Linq;
class Program { static void Main(){ Console.Write("Text: "); string s=Console.ReadLine()??"";
 string rev = new string(s.Reverse().ToArray()); Console.WriteLine($"Reverse: {rev}");
 Console.WriteLine($"Palindrome: {string.Equals(s, rev, StringComparison.OrdinalIgnoreCase)}"); } }