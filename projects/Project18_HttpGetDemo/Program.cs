using System; using System.Net.Http; using System.Threading.Tasks;
class Program { static async Task Main(){ using var http = new HttpClient(); 
 Console.Write("URL: "); var url = Console.ReadLine();
 try{ var s = await http.GetStringAsync(url!); Console.WriteLine($"Length: {s.Length}"); }
 catch(Exception ex){ Console.WriteLine("Error: "+ex.Message); } } }