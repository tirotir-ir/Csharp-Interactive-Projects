using System; using System.Linq;
class Program { static void Main(){ Console.Write("Length: "); int n=int.Parse(Console.ReadLine()!);
 const string chars="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
 var rnd=new Random(); string pw=new string(Enumerable.Range(0,n).Select(_=>chars[rnd.Next(chars.Length)]).ToArray());
 Console.WriteLine(pw); } }