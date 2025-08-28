using System; using System.Linq;
class Program { static void Main(){ int[] a = {1,2,3,4,5,6,7,8,9};
 var evens = a.Where(x=>x%2==0).Select(x=>x*x); Console.WriteLine(string.Join(", ", evens)); } }