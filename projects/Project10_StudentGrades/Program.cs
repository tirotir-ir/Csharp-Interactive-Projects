using System; using System.Linq;
class Program { static void Main(){ Console.Write("Enter grades (0-20) separated by space: ");
 var nums=(Console.ReadLine()??"").Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(s=>double.Parse(s)).ToArray();
 double avg = nums.Average(); Console.WriteLine($"Avg={avg:F2} {(avg>=10?"PASS":"FAIL")}");
 Console.WriteLine("Top3: "+string.Join(", ", nums.OrderByDescending(x=>x).Take(3))); } }